using APIMovies.DAL.Models;
using APIMovies.DAL.Models.Dtos;
using AutoMapper;

namespace APIMovies.MoviesMapper
{
    public class Mappers : Profile
    {
        public Mappers()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryCreateUpdateDto>().ReverseMap();
        }
    }
}
