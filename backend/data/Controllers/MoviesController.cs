using AutoMapper;
using data.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json;
using data.Model;
using business.ViewModel;

namespace data.Controllers
{
    [Route("movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;
        private readonly IDataAPIAccess _service;


        public MoviesController(ILogger<MoviesController> logger, IDataAPIAccess service)
       
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public string Post([FromBody] MoviesDTO movieTitle)
        {
            var movieDataResponse = _service.GetMovieInfoByTitle(movieTitle.Title);
          
            return JsonConvert.SerializeObject(movieDataResponse);
        }

        [HttpGet]
        public string Get()
        {
            var movieDataResponse = _service.GetSearchedMovies();
            // call function from business layer to get data in json format
            //string jsonData = @"{  
            //            'Title':'Die Hard','Year':'1988','Rated':'R','Released':'20 Jul 1988','Runtime':'132 min'
            //            }";

            return JsonConvert.SerializeObject(movieDataResponse);
        }
    }
}
