using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Nowe1.Models;

namespace NewApp1.Controllers
{
    public class MovieController : ApiController
    {
        [HttpGet, Route("movies")]
        public IHttpActionResult GetAllMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {
                    Id = 1,
                    Author = "director 1",
                    Title = "nowy film 1",
                    Comments = new List<string> {"super", "fajny" }
                },
                /*new Movie {
                    Id = 2,
                    Author = "director 2',
                    Tilte = 'nowy film 2',
                    Comments = new List<string> {"ok", "moze byc" }
                }*/


            };
            return Ok(movies);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NewApp1.Models;

namespace NewApp1.Controllers
{
    public class MovieController : ApiController
    {
        [HttpGet, Route("movies/{id:int}")]
        public IHttpActionResult GetById(int id)
        {
            List<Movie> movies = GetMovies();
            Movie movie = movies.Where(n => n.Id == id).SingleOrDefault();
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {
                    Id = 1,
                    Author = "director 1",
                    Title = "nowy film 1",
                    Comments = new List<string> {"super", "fajny" }
                },
                /*new Movie {
                    Id = 2,
                    Author = "director 2',
                    Tilte = 'nowy film 2',
                    Comments = new List<string> {"ok", "moze byc" }
                }*/


            };
        }


        [HttpGet, Route("movies")]
        public IHttpActionResult GetAllMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie {
                    Id = 1,
                    Author = "director 1",
                    Title = "nowy film 1",
                    Comments = new List<string> {"super", "fajny" }
                },
                /*new Movie {
                    Id = 2,
                    Author = "director 2',
                    Tilte = 'nowy film 2',
                    Comments = new List<string> {"ok", "moze byc" }
                }*/


            };
            return Ok(movies);

        }
        [HttpPost, Route("movies")]
        public IHttpActionResult AddMovie([FromBody]Movie movie)
        {
            return Ok(movie);
        }

    }
}