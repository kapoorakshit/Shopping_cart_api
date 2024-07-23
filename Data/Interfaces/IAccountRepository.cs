using Core_Assingment_Api.Model;
using Microsoft.AspNetCore.Identity;

namespace CoreAssingment_Api_BAL_DAL.Repository_Pattern
{
    public interface IAccountRepository
    {
        Task<bool> CheckUser(string Email);
        Task<bool> SignupUser(UserSignUp UserDto);
        Task<bool> LoginUser(Userlogin loginDto);
        Task<string> CreateToken(string Email);
        Task<IdentityResult> ConfirmEmailAsync(string uid, string token);
        Task<IdentityResult> ValidateEmailAsync(string uid, string token);
        Task<IdentityResult> ConfirmEmailWithJwtAsync(string uid, string token);

    }
}
