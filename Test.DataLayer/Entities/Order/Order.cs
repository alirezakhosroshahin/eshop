using System;
using System.Collections.Generic;

namespace Test.DataLayer.Entities.Order
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int OrderSum { get; set; }
        public bool IsFinaly { get; set; }
        public DateTime CreateDate { get; set; }

        public virtual User.User User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
