using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace aspnetcore_template.MVC.ViewModels
{
    public class RestaurantViewModel
    {
        public int Id { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Cuisine")]
        public string Cuisine { get; set; }

        public IEnumerable<SelectListItem> ModelListItems { get; set; }

    }
}
