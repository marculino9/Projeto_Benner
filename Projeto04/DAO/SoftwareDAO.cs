using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class SoftwareDAO
    {
        Context contexto = new Context();

        public void Adiciona(Software software)
        {
            contexto.Softwares.Add(software);
            contexto.SaveChanges();
        }

        public void Remover(Software software)
        {
            contexto.Softwares.Remove(software);
            contexto.SaveChanges();
        }

        public IList<Software> Lista()
        {
            return contexto.Softwares.ToList();
        }

        public Software BuscaPorId(int id)
        {
            return contexto.Softwares.Find(id);
        }

        public Software BuscaPorIdWhere(int id)
        {
            return contexto.Softwares.Where(u => u.Id == id).FirstOrDefault();
        }

        public void Atualiza(Software Softwares)
        {
            contexto.Entry(Softwares).State = EntityState.Modified;
            contexto.Softwares.Update(Softwares);
            contexto.SaveChanges();
        }
    }
}