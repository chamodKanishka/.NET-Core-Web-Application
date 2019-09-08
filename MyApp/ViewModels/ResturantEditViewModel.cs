using MyApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp.ViewModels
{
    public class ResturantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
