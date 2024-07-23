using Shopping_cart_api.Models_product_admin;

namespace Shopping_cart_api.Email
{
    public interface IEmailService
    {
        Task SendTestEmail(Useremail userEmailOptions);
        Task SendEmail(Useremail userEmailOption);
        //string getEmailBody(string templateName);
        //string UpdatePlaceHolder(string text, List<KeyValuePair<string, string>> keyValues);
    }
}
