using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class CargoDAO
    {
        Context contexto = new Context();

        public void Adiciona(Cargo cargo)
        {
            contexto.Add(cargo);
            contexto.SaveChanges();
        }
        public void Remover(Cargo cargo)
        {
            contexto.Cargos.Remove(cargo);
            contexto.SaveChanges();
        }

        public IList<Cargo> Lista()
        {
            return contexto.Cargos.ToList();
        }

        public void Atualiza(Cargo cargo)
        {
            contexto.Entry(cargo).State = EntityState.Modified;
            contexto.Cargos.Update(cargo);
            contexto.SaveChanges();
        }

        public Cargo BuscaPorIdWhere(int id)
        {
            return contexto.Cargos.Where(u => u.Id == id).FirstOrDefault();
        }

        public Cargo BuscaPorId(int id)
        {
            return contexto.Cargos.Find(id);
        }
    }
}