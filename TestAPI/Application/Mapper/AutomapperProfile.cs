using AutoMapper;
using TestAPI.BusinessLogic.DTO;
using TestAPI.Domain;

namespace TestAPI.Application.Mapper
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<CreateProductDTO, Product>();
         
        }
    }
}
