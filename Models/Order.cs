using System;
using System.Collections.Generic;

namespace PlaystationProject.Models
{
    public class Order : BaseEntity
    {
        public int Order_Id { get; set; }
        public Guid? Working_Device_Id { get; set; }
        public bool Is_Paid { get; set; }
        public decimal Total_Cost { get; set; }
        public virtual WorkingDevice WorkingDevice { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
