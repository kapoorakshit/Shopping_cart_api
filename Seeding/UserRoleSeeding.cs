using Core_Assingment_Api.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Core_Assingment_Api.Seeding
{
    public class UserRoleSeeding : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                    UserId = "1cfdbb18-b4f8-40c1-9d79-0498d2001c32"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                    UserId = "8c1e9f47-a2b2-43a2-8a23-53a9710e3248"
                }
                );
        }
    }
}
