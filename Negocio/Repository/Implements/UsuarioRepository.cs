using Data;
using Data.Models;


namespace Negocio.Repository.Implements
{
    public class UsuarioRepository : GenericRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Context context) : base(context) { }
    }
}
