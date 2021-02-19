using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using Data;

namespace Negocio.Repository.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly Context context;
        public GenericRepository(Context context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await context.Set<TEntity>().ToListAsync();
            }
            catch (Exception e)
            {

                throw e;
            }
             
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}
