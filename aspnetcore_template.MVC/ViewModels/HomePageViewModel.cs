using aspnetcore_template.ServiceModel.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace aspnetcore_template.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
        [DisplayName("Actions")]
        public string Actions { get; set; }
        public string Message { get; set; }
        public CuisineType cuisineTypes { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cuisine { get; set; }
    }
}
