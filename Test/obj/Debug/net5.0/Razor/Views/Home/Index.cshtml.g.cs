#pragma checksum "D:\3. porject\hashemi\Education - core5\Test\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b3e453ea4c277a49333c90be8a7482b5c3c3552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b3e453ea4c277a49333c90be8a7482b5c3c3552", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.Core.DTOs.Course.ShowCourseListItemViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CourseBox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\3. porject\hashemi\Education - core5\Test\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Search", async() => {
                WriteLiteral("\r\n    <header>\r\n        \r\n        \r\n        <h3> با کمترین هزینه خودت یاد بگیر </h3>\r\n    </header>\r\n    <div class=\"search-form\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3e453ea4c277a49333c90be8a7482b5c3c35524399", async() => {
                    WriteLiteral("\r\n            <input type=\"text\" name=\"filter\" placeholder=\"چی دوست داری یاد بگیری ؟\">\r\n            <button>\r\n                <i class=\"zmdi zmdi-search\"></i>\r\n            </button>\r\n        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            WriteLiteral("\r\n<main id=\"home-page\">\r\n<div class=\"container\">\r\n<section class=\"terms-items\">\r\n    <header>\r\n        <h2> آخرین دوره ها </h2>\r\n        <a href=\"/Course\"> مشاهده همه دوره ها </a>\r\n    </header>\r\n    <div class=\"row\">\r\n        <!-- col -->\r\n");
#nullable restore
#line 32 "D:\3. porject\hashemi\Education - core5\Test\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b3e453ea4c277a49333c90be8a7482b5c3c35526779", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 34 "D:\3. porject\hashemi\Education - core5\Test\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "D:\3. porject\hashemi\Education - core5\Test\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- /col -->\r\n    </div>\r\n</section>\r\n\r\n<hr>\r\n\r\n<section class=\"terms-items\">\r\n    <header>\r\n        <h2> دوره های محبوب </h2>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1026, "\"", 1033, 0);
            EndWriteAttribute();
            WriteLiteral("> مشاهده همه دوره ها </a>\r\n    </header>\r\n    <div class=\"row\">\r\n        <!-- col -->\r\n        <div class=\"col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col\">\r\n            <article>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1231, "\"", 1238, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/1.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1377, "\"", 1384, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> رایگان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 1712, "\"", 1719, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/2.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1858, "\"", 1865, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> رایگان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 2193, "\"", 2200, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/3.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2339, "\"", 2346, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> 150.000 تومان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 2681, "\"", 2688, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/4.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2827, "\"", 2834, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> رایگان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 3162, "\"", 3169, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/5.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3308, "\"", 3315, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> 15.000 تومان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 3649, "\"", 3656, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/6.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3795, "\"", 3802, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> رایگان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 4130, "\"", 4137, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/7.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4276, "\"", 4283, 0);
            EndWriteAttribute();
            WriteLiteral(@"> آموزش متریال دیاین در زامارین </a>
                </h2>
                <span> 20.000 تومان </span>
                <i>1:52:32</i>
            </article>
        </div>
        <!-- /col -->
        <!-- col -->
        <div class=""col-lg-3 col-md-4 col-sm-6 col-xs-12 term-col"">
            <article>
                <a");
            BeginWriteAttribute("href", " href=\"", 4617, "\"", 4624, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-layer\">\r\n                    <img src=\"/images/pic/8.jpg\">\r\n                </a>\r\n                <h2>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 4763, "\"", 4770, 0);
            EndWriteAttribute();
            WriteLiteral("> آموزش متریال دیاین در زامارین </a>\r\n                </h2>\r\n                <span> 75.000 تومان </span>\r\n                <i>1:52:32</i>\r\n            </article>\r\n        </div>\r\n        <!-- /col -->\r\n    </div>\r\n</section>\r\n</div>\r\n</main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.Core.DTOs.Course.ShowCourseListItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591