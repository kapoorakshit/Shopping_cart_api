namespace Core_Assingment_Api.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        
        public int productId { get; set; }
        public string ptitle { get; set; }
        public double Price { get; set; }
        public int quantity { get; set; }
        public DateTime DateOrdered { get; set; } 
        public int totalprice { get; set; }

    }
}
