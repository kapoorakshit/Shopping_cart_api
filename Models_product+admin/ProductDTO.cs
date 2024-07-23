using Core_Assingment_Api.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_cart_api.Models_product_admin
{
    public class ProductDTO
    {
        public int Id { get; set; }

     
        public int ProductId { get; set; }
        //[ForeignKey("ProductId")]
        //public virtual Product Product { get; set; } = new Product();

        public string URL { get; set; }

     
    }
}
