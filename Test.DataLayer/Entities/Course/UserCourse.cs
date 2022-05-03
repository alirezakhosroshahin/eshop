using System;
using System.Collections.Generic;

#nullable disable

namespace Test.DataLayer.Entities.Course
{
    public partial class UserCourse
    {
        public int UcId { get; set; }
        public int UserId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual User.User User { get; set; }
    }
}
