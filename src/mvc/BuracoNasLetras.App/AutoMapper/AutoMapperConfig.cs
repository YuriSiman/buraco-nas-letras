using AutoMapper;
using BuracoNasLetras.App.ViewModels;
using BuracoNasLetras.Business.Models;

namespace BuracoNasLetras.App.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Papel, PapelViewModel>().ReverseMap();
        }
    }
}
