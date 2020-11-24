using data.Model;
using data.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using business.ViewModel;
using data.Service;

namespace data.Data
{
    public class DataAPIAccess : IDataAPIAccess
    {
        private readonly IDataAccess _dbAccess;
        private readonly IMapper _mapper;

      
        public DataAPIAccess(IDataAccess dbAccess, IMapper mapper) 
        {

            _dbAccess = dbAccess;
            _mapper = mapper;
        }
        // Method search for a movie in api, save it to database and return it back.
        public MoviesDTO GetData(string title)
        {
            // data from omdbapi.com
             //_service = DataAPIService.FetchDataFromPublicAPIAsync;
            var jsonresponse = DataAPIService.FetchDataFromPublicAPIAsync(title);

            // convert
            var foundMovie = JsonConvert.DeserializeObject<Movie>(jsonresponse.Result);
            
            // save data to db
            if (foundMovie != null)
                 _dbAccess.SaveMovieInfo(foundMovie);

            // retrun movie
            var savedMovie = _dbAccess.FindMovieByTitle(foundMovie.Title);

            MoviesDTO movie = new MoviesDTO()
            {
                Id = savedMovie.Id,
                Title = savedMovie.Title,
                Actors = savedMovie.Actors,
                Poster = savedMovie.Poster

            };

            return _mapper.Map<MoviesDTO>(movie);
        }

        public IList<MoviesDTO> GetLastFiveSearchedMovies()
        {
            var movieList = _dbAccess.FindMovies();

            return _mapper.Map<IList<MoviesDTO>>(movieList);
        
        }
    }
}
