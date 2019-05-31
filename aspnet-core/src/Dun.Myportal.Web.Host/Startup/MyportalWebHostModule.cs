using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dun.Myportal.Configuration;

namespace Dun.Myportal.Web.Host.Startup
{
    [DependsOn(
       typeof(MyportalWebCoreModule))]
    public class MyportalWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyportalWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyportalWebHostModule).GetAssembly());
        }
    }
}
