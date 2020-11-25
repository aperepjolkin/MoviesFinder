using AutoMapper;
using business.ViewModel;
using data.Model;
using System.Collections.Generic;

namespace data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MoviesDTO, Movie>();
            CreateMap<IList<MoviesDTO>, IList<Movie>>();
        }
    }
}
