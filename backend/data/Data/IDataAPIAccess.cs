using business.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.Data
{
    public interface IDataAPIAccess
    {
       public MoviesDTO GetMovieInfoByTitle(string title);

      public IList<MoviesDTO> GetSearchedMovies();
    }
}
