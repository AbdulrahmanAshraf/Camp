using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Devices
{
    public class GetDeviceModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int SingleHourCost { get; set; }
        public int MultiHourCost { get; set; }
    }
}
