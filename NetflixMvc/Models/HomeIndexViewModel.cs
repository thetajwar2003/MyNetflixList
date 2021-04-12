using System.Collections.Generic;
using Packt.Shared;

namespace NetflixMvc.Models
{
    public class HomeIndexViewModel
    {
        public int VisitorCount;
        public IList<Shows> Shows { get; set; }
    }
}