using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Test.DataLayer.Entities.Course
{
    public class CourseLevel
    {
        public CourseLevel()
        {
            Courses = new HashSet<Course>();
        }

        public int LevelId { get; set; }
        public string LevelTitle { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}