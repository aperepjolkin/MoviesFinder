using data.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace data.Controllers
{
    public class SomeController : Controller
    {
        private readonly MoviesDbContext _context;

        //the framework handles this
        public SomeController(MoviesDbContext db)
        {
            _context = db;
        }
    }
}
