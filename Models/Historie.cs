using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class Historie : BaseEntity
    {
        public string Description { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
