using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class FuncionarioDAO
    {
        Context contexto = new Context();
        public void Adiciona(Funcionario funcionario)
        {
            contexto.Add(funcionario);
            contexto.SaveChanges();
        }

        public void Remover(Funcionario funcionario)
        {
            contexto.Funcionarios.Remove(funcionario);
            contexto.SaveChanges();
        }

        public IList<Funcionario> Lista()
        {
            return contexto.Funcionarios.Include(t => t.Equipe).Include(t => t.Cargo).ToList();
        }

        public Funcionario BuscaPorId(int id)
        {
            return contexto.Funcionarios.Find(id);
        }

        public Funcionario BuscaPorIdWhere(int id)
        {
            return contexto.Funcionarios.Where(u => u.Id == id).FirstOrDefault();
        }

        public int BuscarPorCodigoVerificacao(int codigoVerificacao)
        {
            var funcionario = contexto.Funcionarios.Where(x => x.CodigoVerificacao == codigoVerificacao).FirstOrDefault();

            if (funcionario != null)
                return funcionario.Id;
            else
                return 0;
        }

        public void Atualiza(Funcionario funcionario)
        {
            contexto.Entry(funcionario).State = EntityState.Modified;
            contexto.Funcionarios.Update(funcionario);
            contexto.SaveChanges();
        }

        public Funcionario Busca(string nome, string maquina)
        {
            return contexto.Funcionarios.FirstOrDefault(u => u.Nome == nome && u.Maquina == maquina);
        }
    }
}