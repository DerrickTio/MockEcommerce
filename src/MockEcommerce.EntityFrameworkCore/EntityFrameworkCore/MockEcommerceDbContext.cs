using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MockEcommerce.Authorization.Roles;
using MockEcommerce.Authorization.Users;
using MockEcommerce.MultiTenancy;

namespace MockEcommerce.EntityFrameworkCore
{
    public class MockEcommerceDbContext : AbpZeroDbContext<Tenant, Role, User, MockEcommerceDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MockEcommerceDbContext(DbContextOptions<MockEcommerceDbContext> options)
            : base(options)
        {
        }
    }
}
