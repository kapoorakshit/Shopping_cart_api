using Core_Assingment_Api.Model;
using Core_Assingment_Api.Seeding;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping_cart_api.Models_product_admin;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Shopping_cart_api.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<ProductDTO> Images { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
           
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleSeeding());
            builder.ApplyConfiguration(new UserRoleSeeding());
            builder.ApplyConfiguration(new UserSeeding());
        }
    }
}
