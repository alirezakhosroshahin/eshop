using System;
using System.Collections.Generic;
using Test.DataLayer.Entities.Order;

#nullable disable

namespace Test.DataLayer.Entities.User
{
    public partial class UserDiscountCode
    {
        public int UdId { get; set; }
        public int UserId { get; set; }
        public int DiscountId { get; set; }

        public virtual Discount Discount { get; set; }
        public virtual User User { get; set; }
    }
}
