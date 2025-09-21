using AutoMapper;
using POS.Application.Dtos.Category.Request;
using POS.Application.Dtos.Category.Response;
using POS.Domain.Entities;
using POS.Utilities.Static;

namespace POS.Application.Mappers
{
    public class CategoryMappingsProfile : Profile
    {

        public CategoryMappingsProfile()
        {
            
            CreateMap<Category, CategoryResponseDto>()
                .ForMember(x=>x.CategoryId, x=>x.MapFrom(y=>y.Id))
                .ForMember(x=>x.StateCategory, x=>x.MapFrom(y=>y.State.Equals((int)StateTypes.Active)? "Activo":"Inactivo"))
                .ReverseMap();

            CreateMap<CategoryRequestDto, Category>().ReverseMap();//quitar por si fallao no c

            

            CreateMap<CategoryRequestDto, Category>();
            CreateMap<Category, CategorySelectResponsedTO>()
                .ForMember(x => x.CategoryId, x => x.MapFrom(y => y.Id))
                .ReverseMap();
        }
    }
}
