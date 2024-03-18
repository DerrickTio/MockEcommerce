using Abp.Authorization;
using MockEcommerce.Authorization.Roles;
using MockEcommerce.Authorization.Users;

namespace MockEcommerce.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
