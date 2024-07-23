namespace Shopping_cart_api.Models_product_admin
{
    public class SMTPConfigModel
    {
        public string SenderAddress { get; set; }
        public string SenderDisplayName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public Boolean EnableSSL { get; set; }
        public Boolean UseDefaultCredentials { get; set; }
        public Boolean IsBodyHTML { get; set; }
    }
}
