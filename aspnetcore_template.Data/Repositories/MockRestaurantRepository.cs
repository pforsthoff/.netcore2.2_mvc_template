using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetcore_template.ServiceModel.Entities;
using aspnetcore_template.ServiceModel.Entities.Base;

namespace aspnetcore_template.Data.Repositories
{
    public class MockRestaurantRepository 
    {
        private List<Restaurant> _restaurantList;
        public MockRestaurantRepository()
        {
            _restaurantList = new List<Restaurant>()
                {
                    new Restaurant {Id = 1, Name = "Musashi"},
                    new Restaurant {Id = 2, Name = "Bambinos"},
                    new Restaurant {Id = 3, Name = "Monica's"},
                    new Restaurant {Id = 4, Name = "AI"},
                    new Restaurant {Id = 5, Name = "Paninos"},
                };
        }
        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _restaurantList.Max(r => r.Id) + 1;
            _restaurantList.Add(restaurant);
            return restaurant;
        }

        public int Count()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> CountAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task Create(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public Restaurant Delete(int id)
        {
            Restaurant restaurant = _restaurantList.FirstOrDefault(r => r.Id == id);
            if (restaurant != null)
            {
                _restaurantList.Remove(restaurant);
            }
            return restaurant;
        }
    }
}
