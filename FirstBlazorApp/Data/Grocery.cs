using System.ComponentModel.DataAnnotations;

namespace FirstBlazorApp.Data

{
    public class Grocery
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name should contain less than 15 characters.")]
        public string Name { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "Valid Price Range is between 1 and 10000.")]
        public float Price { get; set; }

    }
}
