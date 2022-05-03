using System;
using System.Collections.Generic;
using Test.DataLayer.Entities.User;

#nullable disable

namespace Test.DataLayer.Entities.Order
{
    public partial class Discount
    {
        public Discount()
        {
            UserDiscountCodes = new HashSet<UserDiscountCode>();
        }

        public int DiscountId { get; set; }
        public string DiscountCode { get; set; }
        public int DiscountPercent { get; set; }
        public int? UsableCount { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<UserDiscountCode> UserDiscountCodes { get; set; }
    }
}
