using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class EquipeDAO
    {
        Context contexto = new Context();

        public void Adiciona(Equipe equipe)
        {
            contexto.Add(equipe);
            contexto.SaveChanges();
        }
        public void Remover(Equipe equipe)
        {
            contexto.Equipes.Remove(equipe);
            contexto.SaveChanges();
        }

        public IList<Equipe> Lista()
        {
            return contexto.Equipes.Include(t => t.Gestor).ToList();
        }

        public void Atualiza(Equipe equipe)
        {
            contexto.Entry(equipe).State = EntityState.Modified;
            contexto.Equipes.Update(equipe);
            contexto.SaveChanges();
        }
        public Equipe BuscaPorIdWhere(int id)
        {
            return contexto.Equipes.Where(u => u.Id == id).FirstOrDefault();
        }
        public Equipe BuscaPorId(int id)
        {
            return contexto.Equipes.Find(id);
        }
    }
}