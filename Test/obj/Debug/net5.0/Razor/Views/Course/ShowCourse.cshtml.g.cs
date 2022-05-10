#pragma checksum "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07102162982a57584700b529868127f86e16429e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_ShowCourse), @"mvc.1.0.view", @"/Views/Course/ShowCourse.cshtml")]
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
#nullable restore
#line 1 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
using Test.Core.Convertors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
using Test.Core.Services.Interface;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07102162982a57584700b529868127f86e16429e", @"/Views/Course/ShowCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_ShowCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.DataLayer.Entities.Course.Course>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
  
    ViewData["Title"] = Model.CourseTitle;

    bool IsUserInCourse = false;

    if (User.Identity.IsAuthenticated)
    {
        IsUserInCourse = _OrderService.IsUserInCourse(User.Identity.Name, Model.CourseId);
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#""> تاپ لرن </a>
            </li>
            <li class=""breadcrumb-item active"">
                <a href=""#""> دوره ها </a>
            </li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ");
#nullable restore
#line 26 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                                                               Write(Model.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n        </ul>\r\n    </nav>\r\n</div>\r\n\r\n<div class=\"container\">\r\n<section class=\"term-content\">\r\n<header>\r\n    <h1> ");
#nullable restore
#line 34 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
    Write(Model.CourseTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n</header>\r\n<div class=\"row\">\r\n\r\n<div class=\"col-md-8 col-sm-12 col-xs-12 pull-left\">\r\n    <section class=\"term-description\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1068, "\"", 1110, 2);
            WriteAttributeValue("", 1074, "/course/image/", 1074, 14, true);
#nullable restore
#line 40 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
WriteAttributeValue("", 1088, Model.CourseImageName, 1088, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n        ");
#nullable restore
#line 42 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
   Write(Html.Raw(Model.CourseDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
         if (!IsUserInCourse)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-info\">\r\n                <p>بعد از ثبت نام در این دوره و تایید فاکتور لینک های دانلود برای شما فعال خواهد شد</p>\r\n            </div>\r\n");
#nullable restore
#line 48 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <h2> سرفصل های این دوره : </h2>\r\n        <ul>\r\n");
#nullable restore
#line 52 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
             foreach (var item in Model.CourseEpisodes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n");
#nullable restore
#line 55 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                     if (item.IsFree || IsUserInCourse)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1673, "\"", 1709, 2);
            WriteAttributeValue("", 1680, "/DownloadFile/", 1680, 14, true);
#nullable restore
#line 58 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
WriteAttributeValue("", 1694, item.EpisodeId, 1694, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                ");
#nullable restore
#line 59 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                           Write(item.EpisodeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </h3>\r\n");
#nullable restore
#line 62 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h3>\r\n                            ");
#nullable restore
#line 66 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                       Write(item.EpisodeTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </h3>\r\n");
#nullable restore
#line 68 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                     if (item.IsFree)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i> رایگان </i>\r\n");
#nullable restore
#line 72 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <i> نقدی </i>\r\n");
#nullable restore
#line 76 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 77 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                     Write(item.EpisodeTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </li> \r\n");
#nullable restore
#line 79 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </section>\r\n\r\n    <section class=\"user-comments\">\r\n        <header>\r\n            <h3> نظرات کاربران </h3>\r\n        </header>\r\n        <div class=\"inner\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07102162982a57584700b529868127f86e16429e9806", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-4 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""نام و نام خانوادگی"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""ایمیل"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" placeholder=""شماره تماس"">
                        </div>
                    </div>
                    <div class=""col-md-8 col-sm-12 col-xs-12"">
                        <div class=""form-group"">
                            <textarea class=""form-control"" placeholder=""متن نظر""></textarea>
                        </div>
                        <div class=""row"">
                            <div class=""col-md-8 col-sm-7 col-xs-7"">
        ");
                WriteLiteral(@"                        <div class=""form-group"">
                                    <input type=""text"" class=""form-control"" placeholder=""کد امنیتی"">
                                </div>
                            </div>
                            <div class=""col-md-4 col-sm-5 col-xs-5"">
                                <img src=""/images/captcha.jpg"">
                            </div>
                        </div>
                    </div>
                    <div class=""col-xs-12"">
                        <button type=""submit"" class=""btn btn-success""> ثبت دیدگاه </button>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            <div class=""comment-list"">
                <!-- row -->
                <div class=""comment-row"">
                    <img src=""/images/pic/avatar.jpg"">
                    <div class=""left-col"">
                        <h3> میترا رحیمی </h3>
                        <span>12/03/1397</span>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                </div>
                <!-- /row -->
                <!-- row -->
                <div class=""comment-row"">
                    <img src=""/images/pic/avatar.jpg"">
                    <div class=""left-col"">
                        <h3> میترا رحیمی </h3>
                        <span>12/03/1397</span>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنع");
            WriteLiteral(@"ت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                </div>
                <!-- /row -->
                <!-- row -->
                <div class=""comment-row"">
                    <img src=""/images/pic/avatar.jpg"">
                    <div class=""left-col"">
                        <h3> میترا رحیمی </h3>
                        <span>12/03/1397</span>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                </div>
                <!-- /row -->
                <!-- row -->
                <div class=""comment-row"">
                    <img src=""/images/pic/avatar.jpg"">
                    <div class=""left-col"">
                        <h3>");
            WriteLiteral(@" میترا رحیمی </h3>
                        <span>12/03/1397</span>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                </div>
                <!-- /row -->
                <!-- row -->
                <div class=""comment-row"">
                    <img src=""/images/pic/avatar.jpg"">
                    <div class=""left-col"">
                        <h3> میترا رحیمی </h3>
                        <span>12/03/1397</span>
                        <p>
                            لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ و با استفاده از طراحان گرافیک است. چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است
                        </p>
                    </div>
                </div>
                <!-- /row -->

                <nav ");
            WriteLiteral(@"aria-label=""Page navigation"">
                    <ul class=""pagination justify-content-center"">
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"" aria-label=""Previous"">
                                <span aria-hidden=""true"">
                                    <i class=""zmdi zmdi-chevron-right""></i>
                                </span>
                            </a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">1</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">2</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"">3</a>
                        </li>
                        <li class=""page-item"">
                            <a class=""page-link"" href=""#"" aria-label=""Nex");
            WriteLiteral(@"t"">
                                <span aria-hidden=""true"">
                                    <i class=""zmdi zmdi-chevron-left""></i>
                                </span>
                            </a>
                        </li>
                    </ul>
                </nav>

            </div>
        </div>
    </section>
</div>

<aside class=""col-md-4 col-sm-12 col-xs-12 pull-right"">
    <div class=""statistics"">
        <ul>
            <li>
                <span> مدت دوره </span>

");
#nullable restore
#line 223 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                  
                    TimeSpan time = new TimeSpan(Model.CourseEpisodes.Sum(e => e.EpisodeTime.Ticks));
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <i> ");
#nullable restore
#line 226 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
               Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n            </li>\r\n            <li>\r\n                <span> تعداد ویدیوها </span>\r\n                <i> ");
#nullable restore
#line 230 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
               Write(Model.CourseEpisodes.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n            </li>\r\n            <li>\r\n                <span> تعداد دانشجوها </span>\r\n                <i> 0 نفر </i>\r\n            </li>\r\n        </ul>\r\n");
#nullable restore
#line 237 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
         if (Model.CoursePrice != 0 && !IsUserInCourse)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 9408, "\"", 9448, 2);
            WriteAttributeValue("", 9415, "/Course/BuyCourse/", 9415, 18, true);
#nullable restore
#line 239 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
WriteAttributeValue("", 9433, Model.CourseId, 9433, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> شرکت در دوره : ");
#nullable restore
#line 239 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                                                                   Write(Model.CoursePrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان </a>\r\n");
#nullable restore
#line 240 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <article class=\"teacher-info\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 9588, "\"", 9628, 2);
            WriteAttributeValue("", 9594, "/UserAvatar/", 9594, 12, true);
#nullable restore
#line 245 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
WriteAttributeValue("", 9606, Model.User.UserAvatar, 9606, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h2> مدرس : ");
#nullable restore
#line 246 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
               Write(Model.User.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n    </article>\r\n\r\n    <article class=\"term-info\">\r\n        <h2> اطلاعات این دوره </h2>\r\n        <ul>\r\n            <li>سطح دوره: ");
#nullable restore
#line 252 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                     Write(Model.CourseStatus.StatusTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>وضعیت دوره: ");
#nullable restore
#line 253 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                       Write(Model.CourseLevel.LevelTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 254 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
             if (Model.CoursePrice != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>قیمت : ");
#nullable restore
#line 256 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                      Write(Model.CoursePrice.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" تومان</li>\r\n");
#nullable restore
#line 257 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li> رایگان </li>\r\n");
#nullable restore
#line 261 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>تاریخ ثبت این دوره : ");
#nullable restore
#line 262 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                                Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li>آخرین بروزرسانی دوره : ");
#nullable restore
#line 263 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                                  Write(Model.UpdateDate?.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </article>\r\n\r\n    <div class=\"share-layer\">\r\n        <span> به اشتراک گذاری </span>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 10400, "\"", 10407, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"zmdi zmdi-facebook\"></i>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 10483, "\"", 10490, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"zmdi zmdi-google-old\"></i>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 10568, "\"", 10575, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"zmdi zmdi-twitter\"></i>\r\n        </a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 10650, "\"", 10657, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"zmdi zmdi-linkedin\"></i>\r\n        </a>\r\n    </div>\r\n\r\n");
#nullable restore
#line 283 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
     if (Model.Tags != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"tags-layer\">\r\n");
#nullable restore
#line 286 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
             foreach (string tag in Model.Tags.Split("_", StringSplitOptions.RemoveEmptyEntries))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 10940, "\"", 10966, 2);
            WriteAttributeValue("", 10947, "/Course?filter=", 10947, 15, true);
#nullable restore
#line 288 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
WriteAttributeValue("", 10962, tag, 10962, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 288 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
                                          Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 289 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 291 "C:\Users\User\Source\Repos\eshop\Test\Views\Course\ShowCourse.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</aside>\r\n</div>\r\n</section>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOrderService _OrderService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.DataLayer.Entities.Course.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
