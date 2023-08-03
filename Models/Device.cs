using System.Collections.Generic;

namespace PlaystationProject.Models
{
    public class Device : BaseEntity
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Single_Hour_Cost { get; set; }
        public int Multi_Hour_Cost { get; set; }
        public List<WorkingDevice> WorkingDevices { get; set; }
        public MasterData MasterDataCode { get; set; }
    }
}
