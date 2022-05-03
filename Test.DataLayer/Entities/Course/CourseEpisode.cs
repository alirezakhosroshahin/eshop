using System;
using System.ComponentModel.DataAnnotations;

namespace Test.DataLayer.Entities.Course
{
    public class CourseEpisode
    {
        public int EpisodeId { get; set; }
        public int CourseId { get; set; }
        public string EpisodeTitle { get; set; }
        public TimeSpan EpisodeTime { get; set; }
        public string EpisodeFileName { get; set; }
        public bool IsFree { get; set; }

        public virtual Course Course { get; set; }
    }
}