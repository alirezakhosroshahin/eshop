using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Test.DataLayer.Entities.Order;

namespace Test.DataLayer.Entities.Course
{
    public class Course
    {
        public Course()
        {
            CourseEpisodes = new HashSet<CourseEpisode>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int CourseId { get; set; }
        public int? GroupId { get; set; }
        public int? SubGroup { get; set; }
        public int TeacherId { get; set; }
        public int StatusId { get; set; }
        public int LevelId { get; set; }
        public string CourseTitle { get; set; }
        public string CourseDescription { get; set; }
        public int CoursePrice { get; set; }
        public string Tags { get; set; }
        public string CourseImageName { get; set; }
        public string DemoFileName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual CourseGroup Group { get; set; }
        public virtual CourseLevel CourseLevel { get; set; }
        public virtual CourseStatus CourseStatus { get; set; }
        public virtual CourseGroup SubGroupNavigation { get; set; }
        public virtual User.User User { get; set; }
        public virtual ICollection<CourseEpisode> CourseEpisodes { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}  