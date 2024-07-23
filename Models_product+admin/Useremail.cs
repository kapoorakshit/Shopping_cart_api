namespace Shopping_cart_api.Models_product_admin
{
    public class Useremail
    {
        public List<string> ToEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public List<KeyValuePair<string, string>> PlaceHolder { get; set; }
        public string UserId { get; set; } // Add this property
        public string Token { get; set; } // Add this property
    }
}
