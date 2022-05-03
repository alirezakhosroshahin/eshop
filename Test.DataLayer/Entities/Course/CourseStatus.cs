using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.DataLayer.Entities.Course
{
    public class CourseStatus
    {
        public CourseStatus()
        {
            Courses = new HashSet<Course>();
        }

        public int StatusId { get; set; }
        public string StatusTitle { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}