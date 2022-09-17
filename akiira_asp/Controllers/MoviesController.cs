using akiira_asp.Models;
using Microsoft.AspNetCore.Mvc;

namespace akiira_asp.Controllers
{
    public class MoviesController : Controller
    {
        //Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() {
                Name = "Akiira" 
            };
            var customer = new List<Customers>() 
            {
                new Customers { Name = "customer1" },
                new Customers { Name = "customer2" }
            };

            var viewModel = new ViewModels.RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customer
            };

            return View(viewModel);
        }

        public IActionResult Edit(int Id)
        {
            return Content("Id=" + Id);  
        }

        public IActionResult Index(int? pageIndex, string SortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(SortBy))
                SortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, SortBy));
        }

        [Route("movies/release/{{year}}/{{month:regex(\\d{4}):range(1,12)}}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(month + "/" + year);
        }
    }
}
