using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaystationProject.Dtos.Orders
{
    public class AddEditOrderDto
    {
        public Guid? Id { get; set; }
        public Guid? WorkingDeviceId { get; set; }
        public bool IsPaid { get; set; }
      //  public decimal TotalCost { get; set; }
        public string SelectedProduct { get; set; }

        public List<AddProductToOrderDto> Products { get; set; }
    }
    public class AddProductToOrderDto
    {
        public Guid? Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
        public string ProductName { get; set; }
    }
}
