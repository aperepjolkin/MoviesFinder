using AutoMapper;
using business.ViewModel;
using data.Model;

namespace business
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MoviesDTO, Movie>();
        }
    }
}
