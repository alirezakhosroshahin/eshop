#pragma checksum "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "572e229b056d87ad6785cdd9443a08f6e9e3bc98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CourseBox), @"mvc.1.0.view", @"/Views/Shared/_CourseBox.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"572e229b056d87ad6785cdd9443a08f6e9e3bc98", @"/Views/Shared/_CourseBox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CourseBox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.Core.DTOs.Course.ShowCourseListItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- col -->\r\n<div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n    <article>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 160, "\"", 194, 2);
            WriteAttributeValue("", 167, "/ShowCourse/", 167, 12, true);
#nullable restore
#line 6 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
WriteAttributeValue("", 179, Model.CourseId, 179, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\"><img style=\"height: 150px\"");
            BeginWriteAttribute("src", " src=\"", 240, "\"", 276, 2);
            WriteAttributeValue("", 246, "/course/thumb/", 246, 14, true);
#nullable restore
#line 6 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
WriteAttributeValue("", 260, Model.ImageName, 260, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n        <h2><a");
            BeginWriteAttribute("href", " href=\"", 298, "\"", 332, 2);
            WriteAttributeValue("", 305, "/ShowCourse/", 305, 12, true);
#nullable restore
#line 7 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
WriteAttributeValue("", 317, Model.CourseId, 317, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 7 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
                                              Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n        <span> ");
#nullable restore
#line 8 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
           Write((Model.Price==0)?"رایگان":Model.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n        <i>");
#nullable restore
#line 9 "D:\Projects\Eshop\Test\Views\Shared\_CourseBox.cshtml"
      Write(Model.TotalTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n    </article>\r\n</div>\r\n<!-- /col -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Core.DTOs.Course.ShowCourseListItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
