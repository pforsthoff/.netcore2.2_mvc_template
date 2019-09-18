using System.Collections.Generic;
using aspnetcore_template.Data.Entities;
using aspnetcore_template.Entities;

namespace aspnetcore_template.Data.Repositories
{
    public class SQLRestaurantRepository : IRestaurantRepository
    {
        private readonly CoreDbContext context;

        public SQLRestaurantRepository(CoreDbContext context)
        {
            this.context = context;
        }
        public Restaurant Add(Restaurant restaurant)
        {
            context.Add(restaurant);
            context.SaveChanges();
            return restaurant;
        }

        public Restaurant Delete(int id)
        {
            Restaurant restaurant = context.Restaurants.Find(id);
            if (restaurant != null)
            {
                context.Restaurants.Remove(restaurant);
                context.SaveChanges();
            }
            return restaurant;
        }

        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return context.Restaurants;
        }

        public Restaurant GetRestaurant(int Id)
        {
            return context.Restaurants.Find(Id);
        }

        public Restaurant Update(Restaurant restaurantChanges)
        {
            var restaurant = context.Restaurants.Attach(restaurantChanges);
            restaurant.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return restaurantChanges;
        }
    }
}
