using System.Collections.Generic;
using MockEcommerce.Roles.Dto;

namespace MockEcommerce.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
