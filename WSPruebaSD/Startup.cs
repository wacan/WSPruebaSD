using Owin;
using Data;

namespace WSPruebaSDAPI
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)
        {
            try
            {
                //configuración del Dbcontext para utilizarlo por unica instancia por request
                app.CreatePerOwinContext(Context.Create);
            }
            catch (System.Exception e)
            {

                throw e;
            }
        
        } 

    }
}
