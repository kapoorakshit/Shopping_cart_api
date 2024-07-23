using Core_Assingment_Api.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CoreAssingment_Api_BAL_DAL.Repository_Pattern
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly IConfiguration _configuration;

        public AccountRepository(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _configuration = configuration;
        }

        public async Task<bool> CheckUser(string Email)
        {
            var userCheck = await _userManager.FindByEmailAsync(Email);
            if (userCheck == null)
            {
                return true;
            }
            return false;
        }
        public async Task<IdentityResult> ConfirmEmailWithJwtAsync(string uid, string token)
        {
            try
            {
                var user = await _userManager.FindByIdAsync(uid);

                if (user == null)
                {
                    // Log or throw an exception indicating that the user with the specified ID was not found.
                    return IdentityResult.Failed();
                }

                user.EmailConfirmed = true;
                user.LockoutEnabled = false;
           
                var updateResult = await _userManager.UpdateAsync(user);

                if (!updateResult.Succeeded)
                {
                
                    return IdentityResult.Failed();
                }

                return IdentityResult.Success;
            }
            catch (Exception ex)
            {
                // Log or rethrow the exception
                Console.WriteLine("Exception: " + ex.Message);
                throw;
            }
        }




        public async Task<bool> SignupUser(UserSignUp UserDto)
        {

            var user = new User
            {
                UserName = UserDto.UserName,
                firstname = UserDto.UserName,
                Id = UserDto.UserId,
                lastname = UserDto.UserName,
                NormalizedUserName = UserDto.Email,
                Email = UserDto.Email,
                EmailConfirmed = false,
                LockoutEnabled=false,
                PhoneNumberConfirmed = true,
            };
            var result = await _userManager.CreateAsync(user, UserDto.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
                return true;
            }
            return false;
        }
        public async Task<bool> LoginUser(Userlogin UserLogin)
        {
            var user = await _userManager.FindByEmailAsync(UserLogin.Email);
            //if (user != null && !user.EmailConfirmed)
            //{
            //    return false;
            //}
            if (await _userManager.CheckPasswordAsync(user, UserLogin.Password) == true)
            {
                return true;

            }

            return false;
        }

        public async Task<string> CreateToken(string Email)
        {

            var user = await _userManager.FindByEmailAsync(Email);
            var role = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, role[0]),
                new Claim(ClaimTypes.UserData,user.Id)//passing user id of current loggen in user in our token 

            };
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken
                (
                _configuration.GetSection("AppSettings:Issuer").Value,
                _configuration.GetSection("AppSettings:Audience").Value,
                claims: claims,
                expires: DateTime.Now.AddMinutes(90),
                signingCredentials: cred
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
        public async Task<IdentityResult> ConfirmEmailAsync(string uid, string token)
        {
            return await _userManager.ConfirmEmailAsync(await _userManager.FindByIdAsync(uid), token);
        }


        public async Task<IdentityResult> ValidateEmailAsync(string uid, string token)
        {
            User user = await _userManager.FindByIdAsync(uid);
            user.EmailConfirmed = true;
            return await _userManager.ConfirmEmailAsync(await _userManager.FindByIdAsync(uid), token);
        }


    }
}

