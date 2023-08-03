using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class Expense : BaseEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public MasterData TypeMasterData { get; set; }
    }
}
