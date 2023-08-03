using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.WorkingDevices
{
    public class GetAllWorkingDevicesDto
    {
        public Guid Id { get; set; }
        public string DeviceName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Date { get; set; }
        public bool IsWorking { get; set; }
        public string OrderId { get; set; }
    }
}
