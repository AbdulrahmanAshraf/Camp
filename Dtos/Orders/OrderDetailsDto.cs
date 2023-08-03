using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Orders
{
    public class OrderDetailsDto
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Count { get; set; }
        public string Total { get; set; }
    }
}
