using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Name_Ar { get; set; }
        public bool Is_Active { get; set; }
        public Guid Created_By { get; set; }
        public DateTime Create_Date { get; set; }
        public Guid? Last_Modify_By { get; set; }
        public DateTime? Last_Modify_Date { get; set; }
        public bool Is_Deleted { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
    }
}
