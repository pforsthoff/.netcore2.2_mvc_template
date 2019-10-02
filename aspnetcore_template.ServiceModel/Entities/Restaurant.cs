

using aspnetcore_template.ServiceModel.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace aspnetcore_template.ServiceModel.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        American,
        Mexican,
        German,
        Greek,
        Vietnamese,
        Thai,
        Japaneese,
        Chinese,
        MiddleEastern,
        Korean
    }
    public class Restaurant : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
