using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.DAL
{
    public interface IDataAccess
    {
        /// <summary>
        /// Movie search by title 
        /// </summary>
        /// <param name="title">Movie title as a search term</param>
        /// <returns>Movie</returns>
        Movie FindMovieByTitle(string title);

        IList<Movie> FindMovies();

        void SaveMovieInfo(Movie move);
    }
}
