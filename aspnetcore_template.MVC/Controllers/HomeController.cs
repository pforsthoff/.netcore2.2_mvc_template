using aspnetcore_template.Common.Extensions;
using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.Services;
using aspnetcore_template.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;
using AutoMapper;
using aspnetcore_template.ServiceModel.Messaging;
using Newtonsoft.Json;

namespace aspnetcore_template.Controllers
{
    public class HomeController : Controller
    {
        private IGreeter _greeter;
        private readonly IMapper _mapper;
        private readonly IRestaurantManager _restaurantManager;
        public HomeController(IMapper mapper, IGreeter greeter, IRestaurantManager restaurantManager)
        {
            _mapper = mapper;
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
        public async Task<IActionResult> Grid()
        {
            var model = new HomePageViewModel();
            model.Restaurants = await _restaurantManager.GetAllRestaurantsAsync();
            model.CurrentGreeting = _greeter.GetGreeting();
            model.Message = "Select a Cuisine";
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
        [HttpPost]
        public JsonResult AjaxRestaurants()
        {
            var cuisineNumber = Request.Form["cuisine"].FirstOrDefault(); 
            if (cuisineNumber == "")
            {
                cuisineNumber = "0";
            }
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();

            // Skip number of Rows count  
            var start = Request.Form["start"].FirstOrDefault();

            // Paging Length 10,20  
            var length = Request.Form["length"].FirstOrDefault();

            // Sort Column Name  
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

            // Sort Column Direction (asc, desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10, 20, 50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;

            int skip = start != null ? Convert.ToInt32(start) : 0;

            int recordsTotal = 0;

            // getting all Customer data  
            IEnumerable<Restaurant> restaurants = _restaurantManager.GetRestaurantsbyCuisineType(Convert.ToInt32(cuisineNumber));
            var restaurantData = (from c in restaurants
                                  where c.Cuisine == (CuisineType)Convert.ToInt32(cuisineNumber)
                                  select new
                                  {
                                      Id = c.Id,
                                      Name = c.Name,
                                      Cuisine = c.Cuisine
                                  })
                .Select(
                    x =>
                        new Restaurant()
                        {
                            Id = x.Id,
                            Name = x.Name,
                            Cuisine = x.Cuisine
                        });
            //Sorting  
            //if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            //{
            //    restaurantData = restaurantData.OrderBy(sortColumn + " " + sortColumnDirection);
            //}
            ////Search  
            //if (!string.IsNullOrEmpty(searchValue))
            //{
            //    restaurantData = restaurantData.Where(m => m.Name == searchValue);
            //}

            //total number of rows counts   
            recordsTotal = restaurantData.Count();
            //Paging   
            var mappedResults = _mapper.Map<IEnumerable<Restaurant>, ICollection<HomePageViewModel>>(restaurantData);
            var data = mappedResults.Skip(skip).Take(pageSize).ToList();
            //Returning Json Data  
            return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }
        public JsonResult UpdateSelectedRows(string selectedRestaurants)
        {
            var resultMessage = ResultMessages.JsonResultMessage();
            resultMessage.Message = "Successfully Updated Config";
            resultMessage.Success = true;
            try
            {
                ICollection<Restaurant> updateRestaurants = JsonConvert.DeserializeObject<ICollection<Restaurant>>(selectedRestaurants);
                var failures = 0;
                var successes = 0;
                var result = resultMessage;
                foreach (Restaurant restaurant in updateRestaurants)
                {
                    try
                    {
                        result = _restaurantManager.UpdateRestaurant(restaurant);
                    }
                    catch (Exception)
                    {
                        failures += 1;
                    }
                    if (!result.Success)
                    {
                        failures += 1;
                    }
                    else
                    {
                        successes += 1;
                    }
                }
                if (failures > 0)
                {
                    resultMessage.Success = false;
                    resultMessage.Message = "Updated {0}, Failed to Update {1}  row(s)".FormatWith(successes, failures);
                    return Json(resultMessage);
                }
                resultMessage.Success = true;
                resultMessage.Message = "Updated {0} row(s).".FormatWith(successes);
            }
            catch (Exception ex)
            {
                resultMessage.Success = false;
                resultMessage.Message = "Error updating row(s). " + ex.Message;
            }            return Json(resultMessage);
        }
    }
}