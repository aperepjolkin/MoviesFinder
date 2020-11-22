using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.Data
{
    public interface IDataAccess
    {
        public string FindMovie(string title);
    }
}
