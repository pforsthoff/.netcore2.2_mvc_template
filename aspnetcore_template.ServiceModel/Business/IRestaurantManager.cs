using aspnetcore_template.ServiceModel.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace aspnetcore_template.ServiceModel.Business
{
    public interface IRestaurantManager
    {
        Task<Restaurant> GetRestaurant(int Id);
        IEnumerable<Restaurant> GetAllRestaurants();
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        Task<Restaurant> Add(Restaurant restaurant);
        Task<Restaurant> Update(Restaurant restaurantChanges);
        Task<Restaurant> Delete(int id);
    }
}
