#pragma checksum "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "497aea1910c1799bb72e39fbfc87fc7b4a9da184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_UserPanel_Views_MyOrders_Index), @"mvc.1.0.view", @"/Areas/UserPanel/Views/MyOrders/Index.cshtml")]
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
#line 1 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
using Test.Core.Convertors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"497aea1910c1799bb72e39fbfc87fc7b4a9da184", @"/Areas/UserPanel/Views/MyOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/UserPanel/Views/_ViewImports.cshtml")]
    public class Areas_UserPanel_Views_MyOrders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test.DataLayer.Entities.Order.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SideBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <nav aria-label=""breadcrumb"">
        <ul class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""/"">?????? ??????</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page""> ?????????? ???????????? ???? </li>
        </ul>
    </nav>
</div>

<main>
    <div class=""container"">
        <div class=""user-account"">
            <div class=""row"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "497aea1910c1799bb72e39fbfc87fc7b4a9da1843992", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""col-md-9 col-sm-8 col-xs-12"">
                    <section class=""user-account-content"" style=""padding: 10px"">
                        <header><h1> ?????????????????? ?????? </h1></header>
                        <table class=""table table-bordered"" style=""margin-top: 10px"">
                            <thead>
                                <tr>
                                    <th>?????????? ????????????</th>
                                    <th>??????????</th>
                                    <th>??????</th>
                                    <th>????????????</th>
                                   <th>??????????????</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 36 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 40 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                       Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 43 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                       Write(item.CreateDate.ToShamsi());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 45 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                       Write(item.OrderSum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n");
#nullable restore
#line 47 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                             if (item.IsFinaly)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-success\">\r\n");
            WriteLiteral("                                                    ???????????? ??????\r\n                                                </p>\r\n");
#nullable restore
#line 53 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <p class=\"text-danger\">\r\n");
            WriteLiteral("                                                    ???????????? ????????\r\n                                                </p>  \r\n");
#nullable restore
#line 60 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 2935, "\"", 2985, 2);
            WriteAttributeValue("", 2942, "/UserPanel/MyOrders/ShowOrder/", 2942, 30, true);
#nullable restore
#line 63 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
WriteAttributeValue("", 2972, item.OrderId, 2972, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">??????????</a>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 66 "C:\Users\User\Source\Repos\eshop\Test\Areas\UserPanel\Views\MyOrders\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test.DataLayer.Entities.Order.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
