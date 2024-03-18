using System.Collections.Generic;
using MockEcommerce.Roles.Dto;

namespace MockEcommerce.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}