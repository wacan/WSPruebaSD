using Data.Models;
using Negocio.Repository.Implements;

namespace Negocio.Services.Implements
{
    public class UsuarioService : GenericService<Usuario>, IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository) : base(usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }
    }
}
