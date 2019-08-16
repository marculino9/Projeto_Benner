using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class SolicitacaoLicencaDAO
    {
        public void Adiciona(SolicitacaoLicenca solicitacaoLicenca)
        {
            using (var context = new Context())
            {
                context.Add(solicitacaoLicenca);
                context.SaveChanges();
            }
        }
        public void Remover(SolicitacaoLicenca solicitacaoLicenca)
        {
            using (var context = new Context())
            {
                context.SolicitacaoLicencas.Remove(solicitacaoLicenca);
                context.SaveChanges();
            }
        }

        public IList<SolicitacaoLicenca> Lista()
        {
            using (var contexto = new Context())
            {
                return contexto.SolicitacaoLicencas.ToList();
            }
        }

        public SolicitacaoLicenca BuscaPorId(int id)
        {
            using (var contexto = new Context())
            {
                return contexto.SolicitacaoLicencas.Find(id);
            }
        }

        public SolicitacaoLicenca BuscaPorIdWhere(int id)
        {
            using (var contexto = new Context())
            {
                return contexto.SolicitacaoLicencas.Where(u => u.Id == id).FirstOrDefault();
            }
        }

        public void Atualiza(SolicitacaoLicenca solicitacaoLicenca)
        {
            using (var contexto = new Context())
            {
                contexto.Entry(solicitacaoLicenca).State = EntityState.Modified;
                contexto.SolicitacaoLicencas.Update(solicitacaoLicenca);
                contexto.SaveChanges();
            }
        }

        public SolicitacaoLicenca Busca(string nome, int protocolo)
        {
            using (var contexto = new Context())
            {
                return contexto.SolicitacaoLicencas.FirstOrDefault(u => u.Protocolo == protocolo);
            }
        }
    }
}