using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test.Core.DTOs.Course;
using Test.DataLayer.Entities.Course;
using Test.DataLayer.Entities.Order;

namespace Test.Core.Services.Interface
{
    public interface ICourseService
    {
        List<CourseGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatues();

        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        List<ShowCourseForAdminViewModel> GetCoursesForAdmin();
        Course GetCourseById(int courseId);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        
        bool CheckExistFile(string fileName);

        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        List<CourseEpisode> GetListEpisodeCorse(int courseId);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);

        List<ShowCourseListItemViewModel> GetAllCourse(int pageId = 1, string filter = "", string getType = "all",
            string orderByType = "date", int startPrice = 0, int endPrice = 0, List<int> selectedGroups = null,int take=0);
        Course GetCourseForShow(int courseId);
        
        
    }
}