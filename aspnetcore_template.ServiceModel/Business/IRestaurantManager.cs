using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ServiceModel.Messaging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace aspnetcore_template.ServiceModel.Business
{
    public interface IRestaurantManager
    {
        Task<Restaurant> GetRestaurant(int Id);
        IEnumerable<Restaurant> GetAllRestaurants();
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        Restaurant Add(Restaurant restaurant);
        Task<Restaurant> Update(Restaurant restaurantChanges);
        Task<Restaurant> Delete(int id);
        IEnumerable<Restaurant> GetRestaurantsbyCuisineType(int cuisineNumber);
        JsonResultMessage UpdateRestaurant(Restaurant restaurant);
    }
}
