using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dun.Myportal.EntityFrameworkCore
{
    public static class MyportalDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyportalDbContext> builder, string connectionString)
        {
            //builder.UseSqlServer(connectionString);
            builder.UseMySql(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyportalDbContext> builder, DbConnection connection)
        {
            //builder.UseSqlServer(connection);
            builder.UseMySql(connection);
        }
    }
}
