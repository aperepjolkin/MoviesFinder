using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace business.ViewModel
{
    public class MoviesDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Actors { get; set; }

        public string Poster { get; set; }
        
    }
}
