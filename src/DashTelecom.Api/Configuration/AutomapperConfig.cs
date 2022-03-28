using AutoMapper;
using DashTelecom.Api.ViewModels;
using DashTelecom.Domain.Models;

namespace DashTelecom.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<TabTelecomConsolidado, TabTelecomConsolidadoViewModel>().ReverseMap();
            CreateMap<CustoDia, CustoDiaViewModel>().ReverseMap();
            CreateMap<CustoServidor, CustoServidorViewModel>().ReverseMap();
            CreateMap<CustoOperadora, CustoOperadoraViewModel>().ReverseMap();

            //CreateMap<Produto, ProdutoViewModel>()
            //    .ForMember(dest => dest.NomeFornecedor, opt => opt.MapFrom(src => src.Fornecedor.Nome));
        }
    }
}