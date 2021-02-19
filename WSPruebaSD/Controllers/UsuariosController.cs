using AutoMapper;
using Data;
using Negocio.Repository.Implements;
using Negocio.Services.Implements;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using WSPruebaSDAPI;
using Entidades.DTO;

namespace WSPruebaSD.Controllers
{
    public class UsuariosController : ApiController
    {
        private IMapper mapper;
        private readonly UsuarioService usuarioService = new UsuarioService(new UsuarioRepository(Context.Create()));

        public UsuariosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var usuarios = await usuarioService.GetAll();
            var usuariosDTO = usuarios.Select(u => mapper.Map<UsuarioDTO>(u));
            return Ok(usuariosDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var usuario = await usuarioService.GetById(id);
            if (usuario == null)
                return NotFound();

            var usuarioDTO = mapper.Map<UsuarioDTO>(usuario);

            return Ok(usuarioDTO);
        
        }
    }
}