using Microsoft.AspNetCore.Mvc;
using MyApp.Entities;
using MyApp.Services;
using MyApp.ViewModels;

namespace MyApp.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturantData;
        private IGreeter _greeter;

        public HomeController(IResturantData resturantData, IGreeter greeter)
        {
            _resturantData = resturantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var modal = new HomePageViewModel();
            modal.Resturants = _resturantData.GetAll();
            
            return View(modal);
        }
    }
}
