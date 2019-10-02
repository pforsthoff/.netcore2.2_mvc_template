using aspnetcore_template.ViewModels;
using aspnetcore_template.ServiceModel.Entities;
using System.Collections.Generic;
using Xunit;
using aspnetcore_template.Controllers;
using aspnetcore_template.ServiceModel.Business;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using AutoMapper;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Http;

namespace Tests
{
    public class HomeControllerTests
    {
        private Mock<IRestaurantManager> _restaurantManagerMock;
        private Mock<IMapper> _mapperMock;
        private HomeController _controller;
        public HomeControllerTests()
        {
            _mapperMock = new Mock<IMapper>();
            var mockRestaurantList = new List<Restaurant>
            {
                new Restaurant { Name="Mod Pizza", Cuisine = CuisineType.American, Id=22 },
                new Restaurant { Name="In and Out", Cuisine = CuisineType.French, Id = 23 }
            }.AsEnumerable();

            _restaurantManagerMock = new Mock<IRestaurantManager>();
            _restaurantManagerMock
                .Setup(unit => unit.GetAllRestaurantsAsync())
                .Returns(Task.FromResult(mockRestaurantList));
            _controller = new HomeController(_mapperMock.Object, _restaurantManagerMock.Object);
        }
        [Fact]
        public async void Index_ReturnHomePageDefaultView()
        { 
            //Arrange
                //Occurs in ctor
            //Act
            var result = (await _controller.Index() as ViewResult);
            //Assert
            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.Equal("Index", result.ViewName, ignoreCase: true);
        }
        [Fact]
        public async Task GetRestaurants_ReturnsRestaurantList()
        {
            //Arrange
            var mockRestaurantList = new List<Restaurant>
            {
                new Restaurant { Name="Mod Pizza", Cuisine = CuisineType.American, Id=22 },
                new Restaurant { Name="In and Out", Cuisine = CuisineType.French, Id = 23 }
            }.AsEnumerable();
         
            _restaurantManagerMock = new Mock<IRestaurantManager>();
            _restaurantManagerMock
                .Setup(unit => unit.GetAllRestaurantsAsync())
                .Returns(Task.FromResult(mockRestaurantList));
 
            //Act
            _mapperMock = new Mock<IMapper>();
            _controller = new HomeController(_mapperMock.Object, _restaurantManagerMock.Object);
            var result = await _controller.GetRestaurants();
            //Assert
            Assert.Equal(mockRestaurantList, result);
        }
        [Fact]
        public async Task Create_ReturnsNewlyCreatedRestaurant()
        {
            _controller = new HomeController(_mapperMock.Object, _restaurantManagerMock.Object);

            var newRestaurant = new Restaurant()
            {
                Name = "Lemongrass",
                Cuisine = CuisineType.Italian,
            };
            var newRestaurantModel = new RestaurantEditViewModel()
            {
                Name = newRestaurant.Name,
                Cuisine = newRestaurant.Cuisine
            };
            _restaurantManagerMock.Setup(repo => repo.AddAsync(newRestaurant))
                .ReturnsAsync(newRestaurant);

            // Act
            var result = await _controller.Create(newRestaurantModel);

            // Assert
            var resultAction = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Details", resultAction.ActionName);
            Assert.Equal("Lemongrass", newRestaurant.Name);
            _restaurantManagerMock.Verify();
        
        }
       
    }
}
