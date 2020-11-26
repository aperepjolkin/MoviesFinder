using business.ViewModel;
using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.Data
{
    public interface IDataAPIAccess
    {
        /// <summary>
        /// Get movie by title
        /// </summary>
        /// <param name="title">Movie title</param>
        /// <returns>Movie</returns>
        public MoviesDTO GetMovieInfoByTitle(string title);
        /// <summary>
        /// Get searched list of movies
        /// </summary>
        /// <returns>List of movies</returns>
         public IList<Movie> GetSearchedMovies();
    }
}
