using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Core.Services.Interface;

namespace Test.ViewComponents
{
    public class ShowGroupComponents:ViewComponent
    {
        private ICourseService _courseService;

        public ShowGroupComponents(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult) View("ShowGroup",_courseService.GetAllGroup()));
        }
    }
}