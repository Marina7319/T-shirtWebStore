namespace T_shirt.Models.Models
{

    using System.ComponentModel.DataAnnotations.Schema;

    using System.ComponentModel.DataAnnotations;

    public class ProductImage
    {

        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}
