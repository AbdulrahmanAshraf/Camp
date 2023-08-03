using System;

namespace PlaystationProject.Models
{
    public class OrderDetail : BaseEntity
    {
        public Guid Product_Id { get; set; }
        public Guid Order_Id { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
