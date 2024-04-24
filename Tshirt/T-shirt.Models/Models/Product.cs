namespace T_shirt.Models.Models
{

    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

    using System.ComponentModel.DataAnnotations;

    using System.ComponentModel.DataAnnotations.Schema;


    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public string TshirtName { get; set; }

        public string Description { get; set; }

        [Required]

        public string Size { get; set; }

        [Required]

        public string Color { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 98)]

        public double ListPrice { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]

        public virtual Category Category { get; set; }

        [ValidateNever]

        public string ImageUrl { get; set; }

    }
}


