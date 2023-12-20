using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Domain.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public string? Comments { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? Authorized { get; set; }
        public int PermissionTypeId { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; } = null!;
        public virtual PermissionType PermissionType { get; set; } = null!;
    }
}
