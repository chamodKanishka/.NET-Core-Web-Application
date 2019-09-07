using MyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.ViewModels
{
    public class HomePageViewModel
    {
        public int CurrentMessage { get; set; }
        public IEnumerable<Resturant> Resturants { get; set; }
    }
}
