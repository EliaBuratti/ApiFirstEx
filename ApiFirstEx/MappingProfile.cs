using ApiFirstEx.Model;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace ApiFirstEx
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        { 
            CreateMap<Utente, UtenteDto>();
        }

    }
}
