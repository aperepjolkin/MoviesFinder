using business.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Data
{
    public interface IDataAPIAccess
    {
       public MoviesDTO GetData(string title);
    }
}
