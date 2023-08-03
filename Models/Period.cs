using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Models
{
    public class Period : BaseEntity
    {
        public Guid Working_Device_Id { get; set; }
        public string Type { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime? End_Time { get; set; }
        public string Status { get; set; }
        public WorkingDevice WorkingDevice { get; set; }
        public MasterData MasterDataCode { get; set; }
    }
}
