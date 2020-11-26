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
        public MoviesDTO GetMovieInfoByTitle(string title)
        {
            MoviesDTO movie = null;

            // retrun movie from database
            var savedMovie = _dbAccess.FindMovieByTitle(title);
            if (savedMovie != null)
            {
                movie = new MoviesDTO()
                {
                    Id = savedMovie.Id,
                    Title = savedMovie.Title,
                    Actors = savedMovie.Actors,
                    Poster = savedMovie.Poster

                };
            }
            else { 

                // data from omdbapi.com
                //_service = DataAPIService.FetchDataFromPublicAPIAsync;
                var jsonresponse = DataAPIService.FetchDataFromPublicAPIAsync(title);

               // convert server response to object
               var newFoundMovie = JsonConvert.DeserializeObject<Movie>(jsonresponse.Result);

                // save data to db
                if (newFoundMovie.Title != null)
                {
                    var moviesList =_dbAccess.FindMovies();
                    if(moviesList.Count == 5)
                    {
                        //Remove the  added first movie date
                       var firstSearchedMovieByDate = moviesList.OrderBy(d => d.CreatedDate).FirstOrDefault();
                        _dbAccess.RemoveMovie(firstSearchedMovieByDate);
                    }
                     _dbAccess.SaveMovieInfo(newFoundMovie);
                }

             movie = new MoviesDTO() {
                    Id = newFoundMovie.Id,
                    Title = newFoundMovie.Title,
                    Actors = newFoundMovie.Actors,
                    Poster = newFoundMovie.Poster
                };

            }
            return _mapper.Map<MoviesDTO>(movie);
        }


        public IList<Movie> GetSearchedMovies()
        {
            var moviesList = _dbAccess.FindMovies();

            return moviesList;
        }
    }
}
