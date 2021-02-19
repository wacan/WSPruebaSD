using AutoMapper;
using Data.Models;

namespace Entidades.DTO
{
    public class MapperConfig
    {
        public static MapperConfiguration Mapperconfiguration()
        {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<Usuario, UsuarioDTO>();
                cfg.CreateMap<UsuarioDTO, Usuario>();
            });
        }
    }
}
