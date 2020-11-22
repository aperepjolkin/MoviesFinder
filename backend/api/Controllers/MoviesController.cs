using business.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;
        private IDataAccess _service;

        public MoviesController(ILogger<MoviesController> logger, IDataAccess service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public string Get(string movieTitle)
        {
           var movie = _service.FindMovie(movieTitle);
            // call function from business layer to get data in json format
            string jsonData = @"{  
                        'Title':'Die Hard','Year':'1988','Rated':'R','Released':'20 Jul 1988','Runtime':'132 min'
                        }";


            return jsonData;
        }
    }
}
