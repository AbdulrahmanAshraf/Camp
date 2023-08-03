using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class MasterData : BaseKey
    {
        public MasterData()
        {
            Devices = new HashSet<Device>();
            //WorkingDevices = new HashSet<WorkingDevice>();
            Periods = new HashSet<Period>();
            Products = new HashSet<Product>();
            Expenses = new HashSet<Expense>();
        }
        public string Category_Name { get; set; }
      
        public string Code { get; set; }
        public Guid Category_Parent_Id { get; set; }
        public ICollection<Device> Devices { get; set; }
        //public ICollection<WorkingDevice> WorkingDevices { get; set; }
        public ICollection<Period> Periods { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual MasterData MasterData_Parent { get; set; }
        public virtual IEnumerable<MasterData> MasterDataChildern { get; set; }
        public virtual IEnumerable<Expense> Expenses { get; set; }
    }
}
