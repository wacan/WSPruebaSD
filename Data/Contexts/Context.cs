using Data.Models;
using System.Data.Entity;

namespace Data
{
    public class Context : DbContext
    {
        private static Context context = null;

        public Context() : base("pruebaSD_Context")
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }

        public static Context Create()
        {
            try
            {
                //if (context == null)
                    //context = 
                return new Context();
            }
            catch (System.Exception e)
            {

                throw e;
            }
            
        }
    }
}

