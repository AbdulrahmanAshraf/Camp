using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Orders
{
    public class GetOrderDto
    {
        public Guid Id { get; set; }
        public string OrderId { get; set; }
        public bool IsPaid { get; set; }
        public decimal TotalCost { get; set; }
        public string DeviceName { get; set; }
        public string Date { get; set; }
        public List<GetOrderDetailDto> Products { get; set; }

    }
  public class GetOrderDetailDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }

}
