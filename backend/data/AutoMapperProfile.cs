using AutoMapper;
using business.ViewModel;
using data.Model;

namespace data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MoviesDTO, Movie>();
        }
    }
}
