
using Core_Assingment_Api.Model;
using CoreAssingment_Api_BAL_DAL.Repository_Pattern;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Shopping_cart_api.Email;
using Shopping_cart_api.Models_product_admin;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;


namespace Core_Test_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEmailService _email;

        public AccountController(IAccountRepository accountRepository, IEmailService email)
        {
            _accountRepository = accountRepository;
            _email = email;

        }
        //[HttpPost]
        //public async Task<ActionResult<User>> Register(UserSignUp model)
        //{
        //    bool checkUser = await _accountRepository.CheckUser(model.Email);
        //    if (checkUser)
        //    {
        //        var CreateUser = await _accountRepository.SignupUser(model);
        //        if (CreateUser)
        //        {
        //            return Ok(model);
        //        }
        //        return BadRequest();
        //    }
        //    else
        //    {
        //        return Ok("User Already Exist");
        //    }
        //}
        [HttpPost("Login")]
        public async Task<ActionResult<User>> Login(Userlogin model)
        {
            bool checkUser = await _accountRepository.LoginUser(model);
            if (checkUser)
            {
                string token = await _accountRepository.CreateToken(model.Email);
                return Ok(token);
            }
            return Ok("User not exist");
        }
        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserSignUp register)
        {
            try
            {
                var Userid = Guid.NewGuid().ToString();
                register.UserId = Userid;
                var result = await _accountRepository.SignupUser(register);
                var token = CreateTokens(register.Email);


                Useremail options = new Useremail
                {
                    ToEmail = new List<string>() { "kapoorakshit136@gmail.com" },  //register.Email
                    PlaceHolder = new List<KeyValuePair<string, string>>()
                    {
                        new KeyValuePair<string , string>("{{UserName}}", register.UserName),
                        new KeyValuePair<string , string>("{{Url}}", "http"),
                        new KeyValuePair<string , string>("{{Title}}", "Click here"),
                    }

                };
                options.Token = token;
                options.UserId = Userid;


                await _email.SendTestEmail(options);
                return Ok(result);
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize(Roles = "Admin,User")]
        //[HttpGet("ConfirmEmail")]
        //public async Task<IActionResult> ConfirmEmail(string uid, string token)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(token))
        //        {
        //            token = token.Replace(' ', '+'); ;
        //            var result = await _accountRepository.ConfirmEmailAsync(uid, token);
        //            if (result.Succeeded)
        //            {
        //                return Ok("Email Varified Successfully");
        //            }
        //            return BadRequest("Something went wrong???");
        //        }
        //        return BadRequest("Something is wrong with your token!!!");
        //    }
        //    catch (ApplicationException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [Authorize(Roles = "User")]
        [HttpPut("ValidateEmail")]
        public async Task<IActionResult> ValidateEmail(string uid, string token)
        {
            try
            {
                if (string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(token))
                {
                    token = token.Replace(' ', '+'); ;
                    var result = await _accountRepository.ConfirmEmailAsync(uid, token);
                    if (result.Succeeded)
                    {

                        return Ok("Email Verified Successfully");
                    }
                    return BadRequest("Something went wrong???");
                }
                return BadRequest("Something is wrong with your token!!!");
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [AllowAnonymous]
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string uid, string token)
        {
            try
            {
                if (!string.IsNullOrEmpty(uid) && !string.IsNullOrEmpty(token))
                {
                    token = token.Replace('-', '+').Replace('_', '/');
                    byte[] tokenBytes = Convert.FromBase64String(token);
                    string decodedToken = Encoding.UTF8.GetString(tokenBytes);
                    var result = await _accountRepository.ConfirmEmailWithJwtAsync(uid, decodedToken);
                    if (result.Succeeded)
                    {
                        return Ok("Email Verified Successfully");
                    }
                    return BadRequest("Something went wrong???");
                }
                return BadRequest("Invalid token or user ID");
            }
            catch (ApplicationException ex)
            {
                return BadRequest(ex.Message);
            }
        }
        private string CreateTokens(string email)
        {
            using (var rngCryptoServiceProvider = new RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rngCryptoServiceProvider.GetBytes(tokenData);

                byte[] emailBytes = Encoding.UTF8.GetBytes(email);
                byte[] combinedData = new byte[tokenData.Length + emailBytes.Length];
                Buffer.BlockCopy(tokenData, 0, combinedData, 0, tokenData.Length);
                Buffer.BlockCopy(emailBytes, 0, combinedData, tokenData.Length, emailBytes.Length);

                // Use URL-safe Base64 encoding
                return Convert.ToBase64String(combinedData)
                    .Replace('+', '-')
                    .Replace('/', '_');
            }
        }

    }
}