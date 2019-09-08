using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MyApp.Entities
{

    public enum CuisineType
    {
        none,
        Italian,
        French,
        Japanese,
        American

    }
    public class Resturant
    {
        public int id { get; set; }

        [Required, MaxLength(80)]
        [Display(Name = "Resturant Name")]
        public string name{ get; set; }
        public CuisineType Cuisine{ get; set; }

    }
}
