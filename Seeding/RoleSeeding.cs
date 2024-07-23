using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core_Assingment_Api.Seeding
{
    public class RoleSeeding : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
            new IdentityRole
            {
                Id = "bab5ce50-84b3-456c-98f1-d7ff6d40e46e",
                Name = "User",
                NormalizedName = "USER"
            },
            new IdentityRole
            {
                Id = "be4a0261-3e09-46cf-896a-74275d5ef8cd",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
        }
    }
}
