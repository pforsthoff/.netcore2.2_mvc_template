using aspnetcore_template.Data.Repositories;
using aspnetcore_template.ServiceModel.Business;
using aspnetcore_template.ServiceModel.Entities;
using System.Collections.Generic;
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
        public Restaurant Add(Restaurant restaurant)
        {
            restaurant = _unitOfWork.Repository<Restaurant>().Insert(restaurant);
            _unitOfWork.Commit();
            return restaurant;
        }

        public void Delete(int id)
        {
            Restaurant restaurant = _unitOfWork.Repository<Restaurant>().GetById(id);
            if (restaurant != null)
            {
                _unitOfWork.Repository<Restaurant>().Delete(restaurant);
            }
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync()
        {
            return await _unitOfWork.Repository<Restaurant>().GetAllAsync();
        }
        public IEnumerable<Restaurant> GetAllRestaurants()
        {
            return _unitOfWork.Repository<Restaurant>().GetAll();
        }

        public async Task<Restaurant> GetRestaurant(int Id)
        {
            return await _unitOfWork.Repository<Restaurant>().GetByIdAsync(Id);
        }
        
        public async Task<Restaurant> Update(Restaurant restaurantChanges)
        {
            var restaurant = await _unitOfWork.Repository<Restaurant>().GetByIdAsync(restaurantChanges.Id);
            _unitOfWork.Repository<Restaurant>().Update(restaurant);
            await _unitOfWork.CommitAsync();
            return restaurantChanges;
        }

        Task<Restaurant> IRestaurantManager.Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
