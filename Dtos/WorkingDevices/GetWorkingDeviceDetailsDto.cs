using PlaystationProject.Dtos.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.WorkingDevices
{
    public class GetWorkingDeviceDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double PlayStationTotalCost { get; set; }
        public decimal OrderTotalCost { get; set; }
        public string Discount { get; set; } = "0";
        public List<WorkingDevicePeeriodsDto> Periods { get; set; }
        public List<OrderDetailsDto> OrderDetails { get; set; }

    }
}
