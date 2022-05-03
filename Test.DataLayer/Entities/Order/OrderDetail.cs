
namespace Test.DataLayer.Entities.Order
{
    public partial class OrderDetail
    {
        public int DetailId { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public virtual Course.Course Course { get; set; }
        public virtual Order Order { get; set; }
    }
}
