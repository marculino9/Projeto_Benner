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
        Context contexto = new Context();

        public void Adiciona(SolicitacaoLicenca solicitacaoLicenca)
        {
            contexto.Add(solicitacaoLicenca);
            contexto.SaveChanges();
        }
        public void Remover(SolicitacaoLicenca solicitacaoLicenca)
        {
            contexto.SolicitacaoLicencas.Remove(solicitacaoLicenca);
            contexto.SaveChanges();
        }

        public IList<SolicitacaoLicenca> Lista()
        {
            return contexto.SolicitacaoLicencas.Include(t => t.Software).Include(t => t.Usuario).ToList();
        }

        public SolicitacaoLicenca BuscaPorId(int id)
        {
            return contexto.SolicitacaoLicencas.Include(u => u.Usuario).Where(s => s.Id == id).FirstOrDefault();
        }

        public int SelecionarNumeroMaiorProtocolo()
        {
            if (contexto.SolicitacaoLicencas.Count() == 0)
                return 0;
            else
                return contexto.SolicitacaoLicencas.Max(r => r.Protocolo);
        }

        public SolicitacaoLicenca BuscaPorIdWhere(int id)
        {
            return contexto.SolicitacaoLicencas.Where(u => u.Id == id).FirstOrDefault();
        }

        public void Atualiza(SolicitacaoLicenca solicitacaoLicenca)
        {
            contexto.Entry(solicitacaoLicenca).State = EntityState.Modified;
            contexto.SolicitacaoLicencas.Update(solicitacaoLicenca);
            contexto.SaveChanges();
        }

        public SolicitacaoLicenca Busca(int protocolo)
        {
            return contexto.SolicitacaoLicencas.FirstOrDefault(u => u.Protocolo == protocolo);
        }

        public void AlterarSituacao(SolicitacaoLicenca solicitacaoLicenca)
        {
            contexto.Entry(solicitacaoLicenca).Property(j => j.Justificacao).IsModified = true;
            contexto.Entry(solicitacaoLicenca).Property(e => e.Status).IsModified = true;
            contexto.SaveChanges();
        }
    }
}