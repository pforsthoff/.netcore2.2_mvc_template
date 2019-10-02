using aspnetcore_template.Data.Repositories;
using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ServiceModel.Messaging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace aspnetcore_template.Business.Managers
{
    public class RestaurantManager:IRestaurantManager
    {
        private readonly IUnitOfWork _unitOfWork;
        public RestaurantManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
       
        public async Task<JsonResultMessage> AddNewRestaurantAsync(Restaurant restaurant)
        {
            var result = new JsonResultMessage()
            { 
                Success = true,
                Message = "Successfully added new restaurant."
            };
            
            try
            {
                restaurant = await _unitOfWork.Repository<Restaurant>().InsertAsync(restaurant);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error adding config. " + ex.Message;
            }
            return result;
        }

        public async Task<JsonResultMessage> DeleteAsync(int id)
        {
            var result = new JsonResultMessage()
            {
                Success = true,
                Message = "Successfully added new restaurant."
            };
                try
                {
                Restaurant restaurant = _unitOfWork.Repository<Restaurant>().GetById(id);
                await _unitOfWork.Repository<Restaurant>().DeleteAsync(restaurant);
                    _unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = "Error deleting item(s). " + ex.Message;
                }
                return result;
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync()
        {
            return await _unitOfWork.Repository<Restaurant>().GetAllAsync();
        }
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _unitOfWork.Repository<Restaurant>().GetAll();
        }

        public async Task<Restaurant> GetRestaurantAsync(int Id)
        {
            return await _unitOfWork.Repository<Restaurant>().GetByIdAsync(Id);
        }
        
        public async Task<Restaurant> UpdateAsync(Restaurant restaurantChanges)
        {
            var restaurant = await _unitOfWork.Repository<Restaurant>().GetByIdAsync(restaurantChanges.Id);
            _unitOfWork.Repository<Restaurant>().Update(restaurant);
            await _unitOfWork.CommitAsync();
            return restaurantChanges;
        }
       
        public IEnumerable<Restaurant> GetRestaurantsbyCuisineType(int cuisineNumber)
        {
            return _unitOfWork.Repository<Restaurant>().GetByCuisineType(cuisineNumber);
            
        }

        public JsonResultMessage UpdateRestaurant(Restaurant restaurant)
        {
            var result = ResultMessages.JsonResultMessage();
            try
            {
                _unitOfWork.Repository<Restaurant>().Update(restaurant);
                _unitOfWork.Commit();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error updating config. " + ex.Message;
            }
            return result;
        }
    }
}
