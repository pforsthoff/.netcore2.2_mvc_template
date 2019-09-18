using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.Services;
using aspnetcore_template.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace aspnetcore_template.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private readonly IRestaurantManager _restaurantManager;
        public HomeController(IGreeter greeter, IRestaurantManager restaurantManager)
        {
            _restaurantManager = restaurantManager;
            _greeter = greeter;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = await _restaurantManager.GetAllRestaurantsAsync();
            model.CurrentGreeting = _greeter.GetGreeting();
            return View(model);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var model = await _restaurantManager.GetRestaurant(Id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant();
                restaurant.Cuisine = model.Cuisine;
                restaurant.Name = model.Name;
                _restaurantManager.Add(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int Id)
        {
            var model = await _restaurantManager.GetRestaurant(Id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, RestaurantEditViewModel input)
        {
            var restaurant = await _restaurantManager.GetRestaurant(Id);
            if (restaurant != null && ModelState.IsValid)
            {
                restaurant.Name = input.Name;
                restaurant.Cuisine = input.Cuisine;
                await _restaurantManager.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }
    }
}
