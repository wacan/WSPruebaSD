using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Negocio.Repository;

namespace Negocio.Services.Implements
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> genericRepository1;

        public GenericService(IGenericRepository<TEntity> genericRepository1)
        {
            this.genericRepository1 = genericRepository1;
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            try
            {
                return await genericRepository1.GetAll();
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
                return await genericRepository1.GetById(id);
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }
    }
}
