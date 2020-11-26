using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.DAL
{
    public class DataAccess : IDataAccess
    {

        private  MoviesDbContext _context;

        public DataAccess(MoviesDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Movie search by title 
        /// </summary>
        /// <param name="title">Movie title as a search term</param>
        /// <returns>Movie</returns>
        public Movie FindMovieByTitle(string title)
        {
                return _context.Movies.FirstOrDefault(movie => movie.Title.Equals(title));
        }
        /// <summary>
        /// Showing search results
        /// </summary>
        /// <returns>List<Movie>() - list of movies</returns>
        public IList<Movie> FindMovies()
        {

           return _context.Movies.ToList();

        }
        /// <summary>
        /// Save movie
        /// </summary>
        /// <param name="move">Move to be saved</param>
        public void SaveMovieInfo(Movie move)
        {
               _context.Movies.Add(move);
               _context.SaveChanges();
        }

        /// <summary>
        /// Remove movie
        /// </summary>
        /// <param name="move">Move to be removed</param>
        public void RemoveMovie(Movie move)
        {
            _context.Remove(move);
            _context.SaveChanges();
        }
    }
}
