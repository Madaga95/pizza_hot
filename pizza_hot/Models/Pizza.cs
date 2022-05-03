using System.ComponentModel.DataAnnotations;

namespace pizza_hot.Models
{
    public class Pizza
    {
        public int PizzaID { get; set; }
        [Display(Name ="Nom")]
        public string nom { get; set; }
        [Display(Name ="Prix (€)")]
        public float prix { get; set; }

        [Display(Name ="Végétarienne")]
        public bool vegetarienne { get; set; }

        [Display(Name ="Ingrédients")]
        public string ingredients { get; set; }

    }
}
