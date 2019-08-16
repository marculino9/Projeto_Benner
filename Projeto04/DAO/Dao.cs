//using Projeto02.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using Projeto02.Contexto;
//using System.Web;

//namespace Projeto02.DAO
//{
//    public abstract class Dao<T> : IDao<T>
//    where T : class
//    {
//        protected static Context contexto = new Context();

//        public void Adicionar(T entidade)
//        {
//            contexto.Set<T>().Add(entidade);
//            contexto.SaveChanges();
//        }

//        public void Atualizar(T entidade)
//        {
//            contexto.Set<T>().Update(entidade);
//            contexto.SaveChanges();
//        }

//        public T BuscarPorId(T entidade)
//        {
//            return contexto.Set<T>().AsEnumerable().Where(x => x.Id.Equals(entidade.Id)).FirstOrDefault();
//        }

//        public IList<T> Listar(T entidade)
//        {
//            return contexto.Set<T>().AsEnumerable().ToList();
//        }

//        public void Remover(T entidade)
//        {
//            contexto.Set<T>().Remove(entidade);
//            contexto.SaveChanges();
//        }
//    }
//}