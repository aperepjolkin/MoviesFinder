using data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.DAL
{
    public interface IDataAccess
    {
        Movie FindMovieByTitle(string title);

        IList<Movie> FindMovies();

        void SaveMovieInfo(Movie move);
    }
}
