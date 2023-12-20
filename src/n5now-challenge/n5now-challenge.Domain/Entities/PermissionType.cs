using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n5now_challenge.Domain.Entities
{
    public class PermissionType
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();
    }
}
