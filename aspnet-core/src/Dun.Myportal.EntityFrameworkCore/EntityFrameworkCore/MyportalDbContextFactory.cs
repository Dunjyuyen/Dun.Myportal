using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dun.Myportal.Configuration;
using Dun.Myportal.Web;

namespace Dun.Myportal.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyportalDbContextFactory : IDesignTimeDbContextFactory<MyportalDbContext>
    {
        public MyportalDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyportalDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyportalDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyportalConsts.ConnectionStringName));

            return new MyportalDbContext(builder.Options);
        }
    }
}
