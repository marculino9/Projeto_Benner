using Microsoft.EntityFrameworkCore;
using Projeto02.Contexto;
using Projeto02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto02.DAO
{
    public class UsuarioDAO
    {
        Context contexto = new Context();
        public void Adiciona(Usuario usuario)
        {
            contexto.Add(usuario);
            contexto.SaveChanges();
        }

        public void Remover(Usuario usuario)
        {
            contexto.Usuarios.Remove(usuario);
            contexto.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return contexto.Usuarios.Include(t => t.Funcionario).ToList();
        }

        public Usuario BuscaPorId(int id)
        {
            return contexto.Usuarios.Find(id);
        }

        public void Atualiza(Usuario usuarios)
        {
            contexto.Entry(usuarios).State = EntityState.Modified;
            contexto.Usuarios.Update(usuarios);
            contexto.SaveChanges();
        }
        public Usuario Busca(string login, string senha)
        {
            return contexto.Usuarios.FirstOrDefault(u => u.Login == login && u.Senha == senha);
        }
    }
}