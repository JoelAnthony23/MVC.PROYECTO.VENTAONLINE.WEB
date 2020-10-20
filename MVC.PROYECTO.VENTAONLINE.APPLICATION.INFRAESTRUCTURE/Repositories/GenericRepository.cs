using Dapper;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Database;
using MVC.PROYECTO.VENTAONLINE.APPLICATION.INTERFACES.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.PROYECTO.VENTAONLINE.APPLICATION.INFRAESTRUCTURE.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
               where TEntity : class
    {
        public TKey Add<TKey>(TEntity entity)
        {
            TKey retorno;
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                retorno = db.Insert<TKey, TEntity>(entity);
            }
            return retorno;
        }

        public TEntity Get(int id)
        {
            TEntity retorno = null;
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                retorno = db.Get<TEntity>(id);
            }
            return retorno;
        }

        public void Remove(TEntity entity)
        {
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                db.Delete<TEntity>(entity);
            }
        }
        public void Update(TEntity entity)
        {
            using (var db = DatabaseUtil.CreateDBConnection())
            {
                db.Update<TEntity>(entity);
            }
        }
    }
}
