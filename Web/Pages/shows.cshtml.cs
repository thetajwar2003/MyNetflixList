using System.Linq;
using Packt.Shared;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
namespace Web.Pages
{
    public class ShowsModel : PageModel
    {
        private Netflix db;
        public ShowsModel(Netflix injectedContext)
        {
            db = injectedContext;
        }
        public IEnumerable<string> Title { get; set; }
        public IEnumerable<string> Tags { get; set; }

        public void OnGet()
        {
            ViewData["Title"] = "Netflix Viewer";
            Title = db.Shows.Select(s => s.title);
            Tags = db.Shows.Select(s => s.listed_in);
        }
    }
}