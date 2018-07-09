using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name= "Ready Player One"},
                new Movie {Id = 2, Name= "Deadpool 2"}
            };
        }

//    / GET: Movies
/*
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "DRAMA !"};

            return View(movie);
        }
        

        [Route("movies/released/{year}/{month:regex(\\d{4}): range(1, 12)}")]
        public ActionResult  ByReleaseDate (int year, int month)
        {
            if (month > 12)
                return HttpNotFound();
            else
                return Content(year + "/" + month);
            //return View();
        }
*/
    }
}