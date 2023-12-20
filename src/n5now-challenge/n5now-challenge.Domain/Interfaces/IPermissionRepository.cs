using n5now_challenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Domain.Interfaces
{
    public interface IPermissionRepository
    {
        Task<List<Permission>> GetPermissions();
        Task RequestPermision(Permission permission);
        Task ModifyPermision(Permission permission);
    }
}
