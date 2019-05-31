using Abp.MultiTenancy;
using Dun.Myportal.Authorization.Users;

namespace Dun.Myportal.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
