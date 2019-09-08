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
            modal.CurrentMessage = _greeter.GetGreeting();
            
            return View(modal);
        }

        public IActionResult Details(int id)
        {
            var model = _resturantData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ResturantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newResturant = new Resturant();
                newResturant.Cuisine = model.Cuisine;
                newResturant.name = model.Name;

                newResturant = _resturantData.Add(newResturant);

                return RedirectToAction("Details", new { id = newResturant.id });
            }
            return View();
        }
    }
}
