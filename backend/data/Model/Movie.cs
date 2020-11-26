using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace data.Model
{
    public class Movie : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }

        public string Actors { get; set; }

        public string Poster { get; set; }

   
    }
}
