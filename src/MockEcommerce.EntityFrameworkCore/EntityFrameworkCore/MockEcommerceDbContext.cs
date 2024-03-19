using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MockEcommerce.Authorization.Roles;
using MockEcommerce.Authorization.Users;
using MockEcommerce.MultiTenancy;
using MockEcommerce.Entities;

namespace MockEcommerce.EntityFrameworkCore
{
    public class MockEcommerceDbContext : AbpZeroDbContext<Tenant, Role, User, MockEcommerceDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        public MockEcommerceDbContext(DbContextOptions<MockEcommerceDbContext> options)
            : base(options)
        {
        }
    }
}
