using Abp.Authorization;
using Lpw.Cms.Authorization.Roles;
using Lpw.Cms.Authorization.Users;

namespace Lpw.Cms.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
