using System;
using System.Collections.Generic;

namespace PlaystationProject.Models
{
    public class WorkingDevice : BaseEntity
    {
        public Guid Device_Id { get; set; }
        public bool Is_Paid { get; set; }
        public decimal Total_Cost { get; set; }
        public Device Device { get; set; }
        public Order Order { get; set; }
        public List<Period> Periods { get; set; }
        public int? Discount { get; set; }

       // public MasterData MasterDataCode { get; set; }
    }
}
