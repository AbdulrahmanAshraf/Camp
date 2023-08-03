using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string User_Type_Code { get; set; }
        public string Full_Name { get; set; }
        public DateTime Creation_Time { get; set; }
        public Guid? Created_By { get; set; }
        public DateTime? Last_Modify_Time { get; set; }
        public Guid? Last_Modify_By { get; set; }
        public DateTime? Last_Access_Time { get; set; }
        public bool Is_Active { get; set; }
        public string Gender_Master_Code { get; set; }
        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
        public virtual ICollection<Historie> Histories { get; set; } 

    }
}
