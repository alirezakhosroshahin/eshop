using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.DataLayer.Entities.Course
{
    public class CourseGroup
    {
        public CourseGroup()
        {
            CourseGroups = new HashSet<Course>();
            CourseSubGroupNavigations = new HashSet<Course>();
            InverseParent = new HashSet<CourseGroup>();
        }

        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public bool IsDelete { get; set; }
        public int? ParentId { get; set; }

        public virtual CourseGroup Parent { get; set; }
        public virtual ICollection<Course> CourseGroups { get; set; }
        public virtual ICollection<Course> CourseSubGroupNavigations { get; set; }
        public virtual ICollection<CourseGroup> InverseParent { get; set; }

    }
}