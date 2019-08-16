using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class LicencaDAO
    {
        Context contexto = new Context();

        public void Adiciona(Licenca licenca)
        {
            contexto.Add(licenca);
            contexto.SaveChanges();
        }
        public void Remover(Licenca licenca)
        {
            contexto.Licencas.Remove(licenca);
            contexto.SaveChanges();
        }

        public IList<Licenca> Lista()
        {
            return contexto.Licencas.Include(t => t.Software).ToList();
        }

        public void Atualiza(Licenca licenca)
        {
            contexto.Entry(licenca).State = EntityState.Modified;
            contexto.Licencas.Update(licenca);
            contexto.SaveChanges();
        }

        public Licenca BuscaPorIdWhere(int id)
        {
            return contexto.Licencas.Where(u => u.Id == id).FirstOrDefault();
        }

        public Licenca BuscaPorId(int id)
        {
            return contexto.Licencas.Find(id);
        }
    }
}