using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetflixMvc.Models;
using Packt.Shared;

namespace NetflixMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Netflix db;
        public HomeController(ILogger<HomeController> logger, Netflix injectedContext)
        {
            _logger = logger;
            db = injectedContext;
        }
        public IActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                VisitorCount = db.Shows.Count(),
                Shows = db.Shows.ToList(),
            };
            return View(model); // pass model to view
        }

        public IActionResult ShowDetail(string show_title)
        {
            // if (title == "")
            // {
            //     return NotFound("You must pass a product ID in the route, for example, / Home / ProductDetail / 21");
            // }
            var model = db.Shows
            .SingleOrDefault(s => s.title == show_title);
            if (model == null)
            {
                return NotFound($"title {show_title} not found.");
            }
            return View(model); // pass model to view and then return result
        }

        public IActionResult ModelBinding(Rating rating)
        {
            return View(rating);
        }

        public IActionResult SearchShow(string title)
        {
            IEnumerable<Shows> model = db.Shows.Where(p => p.title.Contains(title));
            if (model.Count() == 0)
            {
                return NotFound($"No results found for \"{title}\"");
            }
            ViewData["Title"] = title;
            return View(model); // pass model to view
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
