#pragma checksum "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fbc37f541c05a5bc2a1b8072f94a501acd5e903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Admin.Users.Pages_Admin_Users_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/Users/Index.cshtml")]
namespace Test.Pages.Admin.Users
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
#line 1 "C:\Users\User\Source\Repos\eshop\Test\Pages\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fbc37f541c05a5bc2a1b8072f94a501acd5e903", @"/Pages/Admin/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7dfff6a59c037a6860b43fe5ca02a79b4f9db8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Users_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">???????? ??????????????</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                ???????? ?????????????? ????????
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""row"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fbc37f541c05a5bc2a1b8072f94a501acd5e9034682", async() => {
                WriteLiteral(@"
                                <div class=""col-sm-5 col-md-5"">
                                    <input type=""text"" name=""filterUserName"" class=""form-control"" placeholder=""?????? ????????????""/>
                                </div>
                                <div class=""col-sm-5 col-md-5"">
                                    <input type=""text"" name=""filterEmail"" class=""form-control"" placeholder=""??????????""/>
                                </div>
                                <div class=""col-sm-2 col-md-2"">
                                    <button type=""submit"" class=""btn btn-info"">????????</button>
                                    <a class=""btn btn-default btn-sm"" href=""/Admin/Users"">????????</a>
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
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"col-md-12\" style=\"margin: 10px 0;\">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fbc37f541c05a5bc2a1b8072f94a501acd5e9036868", async() => {
                WriteLiteral("???????????? ?????????? ????????");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                            <tr>
                                <th>?????? ????????????</th>
                                <th>??????????</th>
                                <th>??????????</th>
                                <th>?????????? ?????? ??????</th>
                                <th>??????????????</th>
                            </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 54 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                             foreach (var item in Model.UserForAdminViewModel.Users)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 57 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                   Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 58 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 59 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                   Write(item.IsActive);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 60 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                   Write(item.RegisterDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2864, "\"", 2905, 2);
            WriteAttributeValue("", 2871, "/Admin/Users/EditUser/", 2871, 22, true);
#nullable restore
#line 62 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 2893, item.UserId, 2893, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                            ????????????\r\n                                        </a>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3080, "\"", 3123, 2);
            WriteAttributeValue("", 3087, "/Admin/Users/DeleteUser/", 3087, 24, true);
#nullable restore
#line 65 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 3111, item.UserId, 3111, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger btn-sm\">\r\n                                            ??????\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 70 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate"">
                                    <ul class=""pagination"">
");
#nullable restore
#line 77 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                         for (int i = 1; i <= Model.UserForAdminViewModel.PageCount; i++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li");
            BeginWriteAttribute("class", " class=\"", 3912, "\"", 4001, 2);
            WriteAttributeValue("", 3920, "paginate_button", 3920, 15, true);
#nullable restore
#line 79 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue(" ", 3935, (i == Model.UserForAdminViewModel.CurrentPage) ? "active" : "", 3936, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-controls=\"dataTables-example\" tabindex=\"0\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4103, "\"", 4132, 2);
            WriteAttributeValue("", 4110, "/Admin/Users?PageId=", 4110, 20, true);
#nullable restore
#line 80 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
WriteAttributeValue("", 4130, i, 4130, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 82 "C:\Users\User\Source\Repos\eshop\Test\Pages\Admin\Users\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.Admin.Users.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.Admin.Users.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.Admin.Users.IndexModel>)PageContext?.ViewData;
        public Test.Pages.Admin.Users.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
