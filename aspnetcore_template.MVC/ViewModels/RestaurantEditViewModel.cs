using aspnetcore_template.ServiceModel.Entities;
using System.ComponentModel.DataAnnotations;

namespace aspnetcore_template.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
