using Microsoft.AspNetCore.Identity;

namespace Core_Assingment_Api.Model
{
    public class User:IdentityUser
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
    }
}
