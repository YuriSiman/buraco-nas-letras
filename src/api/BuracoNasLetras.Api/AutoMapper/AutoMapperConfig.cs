using AutoMapper;
using BuracoNasLetras.Api.ViewModels;
using BuracoNasLetras.Business.Models;

namespace BuracoNasLetras.Api.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Papel, PapelViewModel>().ReverseMap();
        }
    }
}
