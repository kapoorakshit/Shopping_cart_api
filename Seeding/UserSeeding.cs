    using Core_Assingment_Api.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Core_Assingment_Api.Seeding
{
    public class UserSeeding : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User()
                {
                    Id = "1cfdbb18-b4f8-40c1-9d79-0498d2001c32",
                    UserName = "Admin",
                    firstname = "Admin",
                    lastname= "Admin",
                    Email = "Admin@gmail.com",
                    PhoneNumber = "1234567890",
                    EmailConfirmed = true,
                    NormalizedEmail = "Admin@gmail.com",
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "Admin123@")

                },
                new User()
                {
                    Id = "8c1e9f47-a2b2-43a2-8a23-53a9710e3248",
                    UserName = "User",
                    firstname = "User",
                    lastname = "User",
                    Email = "User@gmail.com",
                    PhoneNumber = "1234567890",
                    EmailConfirmed = true,
                    NormalizedEmail = "User@gmail.com",
                    PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "User123@")

                });
        }
    }
}
