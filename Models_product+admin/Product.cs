using Shopping_cart_api.Models_product_admin;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core_Assingment_Api.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Product title is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Product title must be between 3 and 100 characters")]
        public string PTitle { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(250, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 250 characters")]
        public string PDescription { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get; set; }

    }
}
