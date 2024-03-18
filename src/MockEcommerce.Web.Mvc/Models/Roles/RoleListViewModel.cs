using System.Collections.Generic;
using MockEcommerce.Roles.Dto;

namespace MockEcommerce.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
