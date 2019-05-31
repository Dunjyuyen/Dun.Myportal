using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dun.Myportal.Authorization;

namespace Dun.Myportal
{
    [DependsOn(
        typeof(MyportalCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyportalApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyportalAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyportalApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
