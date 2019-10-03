using aspnetcore_template.Common.Extensions;
using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ServiceModel.Messaging;
using aspnetcore_template.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Threading.Tasks;

namespace aspnetcore_template.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IRestaurantManager _restaurantManager;
        public HomeController(IMapper mapper, IRestaurantManager restaurantManager)
        {
            _mapper = mapper;
            _restaurantManager = restaurantManager;
        }
        [HttpGet()]
        public async Task<IEnumerable<Restaurant>> GetRestaurants()
        {
            return await _restaurantManager.GetAllRestaurantsAsync();
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = await _restaurantManager.GetAllRestaurantsAsync();
            return View("Index",model);
        }

        public async Task<IActionResult> Details(int Id)
        {
            var model = await _restaurantManager.GetRestaurantAsync(Id);
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
            model.Message = "Select a Cuisine";
            return View(model);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = new Restaurant();
                restaurant.Cuisine = model.Cuisine;
                restaurant.Name = model.Name;
                await _restaurantManager.AddNewRestaurantAsync(restaurant);
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
            var model = await _restaurantManager.GetRestaurantAsync(Id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int Id, RestaurantEditViewModel input)
        {
            var restaurant = await _restaurantManager.GetRestaurantAsync(Id);
            if (restaurant != null && ModelState.IsValid)
            {
                restaurant.Name = input.Name;
                restaurant.Cuisine = input.Cuisine;
                await _restaurantManager.UpdateAsync(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View(restaurant);
        }
        [HttpPost]
        public JsonResult AjaxRestaurants(string cuisineNumber)
        {
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
            var sortColumn = Request.Form["order[0][column]"].FirstOrDefault();

            //var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();

            // Sort Column Direction (asc, desc)  
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();

            // Search Value from (Search box)  
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10, 20, 50,100)  
            int pageSize = length != null ? Convert.ToInt32(length) : 0;

            int skip = start != null ? Convert.ToInt32(start) : 0;

            int recordsTotal = 0;

            IEnumerable<Restaurant> restaurants = _restaurantManager.GetRestaurantsbyCuisineType(Convert.ToInt32(cuisineNumber));

            // getting all Customer data  
            if (cuisineNumber == null)
            {
                restaurants = _restaurantManager.GetAllRestaurants();
            }

            //Search    
            if (!string.IsNullOrEmpty(searchValue))
            {
                restaurants = restaurants.Where(d => d.Name != null && d.Name.ToLower().Contains(searchValue.ToLower())).ToList();
            }
            //Sorting
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
            {
                restaurants = SortByColumnWithOrder(sortColumn, sortColumnDirection, restaurants);
            }
            //total number of rows counts   
            recordsTotal = restaurants.Count();
            //Paging   
            var mappedResults = _mapper.Map<IEnumerable<Restaurant>, ICollection<HomePageViewModel>>(restaurants);
            ICollection<HomePageViewModel> data = new List<HomePageViewModel>();
            if (recordsTotal > 0)
            {
                data = mappedResults.Skip(skip).Take(pageSize).ToList();
            }

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
        private IEnumerable<Restaurant> SortByColumnWithOrder(string sortColumn, string sortColumnDir, IEnumerable<Restaurant> data)
        {
            // Sorting   
            switch (sortColumn)
            {
                case "1":
                    data = sortColumnDir.Equals("desc", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.Name).ToList() : data.OrderBy(p => p.Name).ToList();
                    break;
                case "2":
                    data = sortColumnDir.Equals("desc", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.Cuisine.ToString()).ToList() : data.OrderBy(p => p.Cuisine.ToString()).ToList();
                    break;
                default:
                    data = sortColumnDir.Equals("desc", StringComparison.CurrentCultureIgnoreCase) ? data.OrderByDescending(p => p.Name).ToList() : data.OrderBy(p => p.Name).ToList();
                    break;
            }
            return data.AsEnumerable();
        }
    
        public JsonResult editDropdownUrl(string selectlist)
        {
            var resultMessage = ResultMessages.JsonResultMessage();
            try
            {

                var results = from CuisineType d in Enum.GetValues(typeof(CuisineType))
                select new { ID = (int)d, Name = d.ToString() };
                IEnumerable<SelectListItem> cuisineTypes = results.Select(m => new SelectListItem
                {
                    Value = m.ID.ToString(),
                    Text = m.Name
                }).Distinct().ToList();

                return Json(cuisineTypes);
            }
            catch (Exception ex)
            {
                resultMessage.Success = false;
                resultMessage.Message = "Error retrieving select list information. " + ex.Message;
            }

            return Json(resultMessage);
        }
        [HttpPost]
        public async Task<JsonResult> AddNewRestaurant(string NewRow)
        {
            var result = ResultMessages.JsonResultMessage();
            result.Message = "Error Adding New Row.";
            result.Success = false;
            try
            {
                Restaurant newRestaurant = JsonConvert.DeserializeObject<Restaurant>(NewRow);
                result = await _restaurantManager.AddNewRestaurantAsync(newRestaurant);
            }            catch (Exception e)
            {
                result.Message = "Error Adding New Row.";
                result.Success = false;
                return Json(result);
            }
            return Json(result);
        }
        public async Task<JsonResult> DeleteSelectedItems(List<int> selectedItems)
        {
            var resultMessage = new JsonResultMessage
            {
                Success = false,
                Message = "Unable to delete selected items, please try again."
            };
            if (selectedItems != null)
            {
                var failures = 0;
                var successes = 0;
                foreach (int restaurantId in selectedItems)
                {
                    var result = await _restaurantManager.DeleteAsync(restaurantId);
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
                    resultMessage.Message = "Deleted {0}, Failed to Delete {1} items".FormatWith(successes, failures);
                    return Json(resultMessage);
                }
                resultMessage.Success = true;
                resultMessage.Message = "Deleted {0} items.".FormatWith(successes);
            }            return Json(resultMessage);
        }

    }
}