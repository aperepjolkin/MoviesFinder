using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.DAL
{
    public class DataAccess : IDataAccess
    {

        private readonly MoviesDbContext _context;

        public DataAccess(MoviesDbContext context)
        {
            _context = context;
        }
        public Movie FindMovieByTitle(string title)
        {
           return _context.Movies.FirstOrDefault(movie => movie.Title.Contains(title));
        }

        public IList<Movie> FindMovies(string title)
        {

           return _context.Movies.Where(movie => movie.Title.Contains(title)).ToList();

        }
        public void SaveMovieInfo(Movie move)
        {
               _context.Movies.Add(move);
               _context.SaveChanges();
        }

        //public void Dispose()
        //{
        //    _context.Dispose();
        //}
    }
}
