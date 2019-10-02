using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ServiceModel.Messaging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetcore_template.ServiceModel.Business
{
    public interface IRestaurantManager
    {
        Task<Restaurant> GetRestaurantAsync(int Id);
        IEnumerable<Restaurant> GetAllRestaurants();
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        Task<JsonResultMessage> AddNewRestaurantAsync(Restaurant restaurant);
        Task<Restaurant> UpdateAsync(Restaurant restaurantChanges);
        Task<JsonResultMessage> DeleteAsync(int id);
        IEnumerable<Restaurant> GetRestaurantsbyCuisineType(int cuisineNumber);
        JsonResultMessage UpdateRestaurant(Restaurant restaurant);
    }
}
