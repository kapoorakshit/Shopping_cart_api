using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using Shopping_cart_api.Models_product_admin;

namespace Shopping_cart_api.Email
{
    public class EmailService : IEmailService
    {
        private const string templatPath = @"Data/EmailTemplate/{0}.html";
        private readonly SMTPConfigModel _smtpConfig;

        public EmailService(IOptions<SMTPConfigModel> smtpConfig)
        {
            _smtpConfig = smtpConfig.Value;
        }
        public async Task SendTestEmail(Useremail userEmailOptions)
        {
            userEmailOptions.Subject = UpdatePlaceHolder("This is to verify your email from store web app", userEmailOptions.PlaceHolder);

            // Update placeholders with actual values
            userEmailOptions.Body = UpdatePlaceHolder(getEmailBody("TestEmail"), userEmailOptions.PlaceHolder);
            userEmailOptions.Body = userEmailOptions.Body
                .Replace("{{UserId}}", userEmailOptions.UserId)
                .Replace("{{Token}}", userEmailOptions.Token);

            await SendEmail(userEmailOptions);
        }



        public async Task SendEmail(Useremail userEmailOption)
        {
            MailMessage mail = new MailMessage
            {
                Subject = userEmailOption.Subject,
                Body = userEmailOption.Body,
                From = new MailAddress(_smtpConfig.SenderAddress, _smtpConfig.SenderDisplayName),
                IsBodyHtml = _smtpConfig.IsBodyHTML
            };

            foreach (var toEmail in userEmailOption.ToEmail)
            {
                mail.To.Add(toEmail);
            }
            NetworkCredential networkCredential = new NetworkCredential(_smtpConfig.UserName, _smtpConfig.Password);

            SmtpClient smtpClient = new SmtpClient
            {
                Host = _smtpConfig.Host,
                Port = _smtpConfig.Port,
                EnableSsl = _smtpConfig.EnableSSL,
                UseDefaultCredentials = _smtpConfig.UseDefaultCredentials,
                Credentials = networkCredential,
            };
            mail.BodyEncoding = System.Text.Encoding.Default;

            await smtpClient.SendMailAsync(mail);
        }

        private string getEmailBody(string templateName)
        {
            var body = File.ReadAllText(string.Format(templatPath, templateName));
            return body;
        }

        private string UpdatePlaceHolder(string text, List<KeyValuePair<string, string>> keyValues)
        {
            if (!string.IsNullOrEmpty(text) && keyValues != null)
            {    

                foreach (var placeholder in keyValues)
                {
                    text = text.Replace(placeholder.Key, placeholder.Value);
                }
            }
            return text;
        }
    }
}
