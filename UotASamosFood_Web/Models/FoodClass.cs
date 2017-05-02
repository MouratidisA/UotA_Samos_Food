using System.ComponentModel.DataAnnotations;

namespace UotASamosFood_Web.Models
{
    public class FoodClass
    {
        [Display(Name = "Week")]
        public string week_sel { get; set; }

        [Display(Name = "Day Time")]
        public string daytime_sel { get; set; }

    }
}