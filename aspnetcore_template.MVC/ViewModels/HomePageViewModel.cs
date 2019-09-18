using aspnetcore_template.ServiceModel.Entities;
using System.Collections.Generic;

namespace aspnetcore_template.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurrentGreeting { get; set; }
    }
}
