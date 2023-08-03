using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.WorkingDevices
{
    public class CloseDeviceDto
    {
        public Guid Id { get; set; }
        public int Discount { get; set; }
    }
}
