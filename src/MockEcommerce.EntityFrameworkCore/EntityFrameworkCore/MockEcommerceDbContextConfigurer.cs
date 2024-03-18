using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MockEcommerce.EntityFrameworkCore
{
    public static class MockEcommerceDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MockEcommerceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MockEcommerceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
