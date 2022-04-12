using Microsoft.EntityFrameworkCore;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class GenericRepository<T>:  IGenericRepository<T> where T : class
    {
        
            private readonly DbContext context;
            DbSet<T> dbSet;
            public GenericRepository(DbContext context)
            {
                this.context = context;
                dbSet = context.Set<T>();
            }

        public Task<T> Add(T item)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
