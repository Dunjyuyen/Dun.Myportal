using Abp.Authorization;
using Dun.Myportal.Authorization.Roles;
using Dun.Myportal.Authorization.Users;

namespace Dun.Myportal.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
