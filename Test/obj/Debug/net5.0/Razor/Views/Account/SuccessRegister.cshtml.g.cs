#pragma checksum "D:\3. porject\hashemi\Education - core5\Test\Views\Account\SuccessRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e6fe7f485001c1f0e7250992f832699ef03afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_SuccessRegister), @"mvc.1.0.view", @"/Views/Account/SuccessRegister.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e6fe7f485001c1f0e7250992f832699ef03afe", @"/Views/Account/SuccessRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_SuccessRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3. porject\hashemi\Education - core5\Test\Views\Account\SuccessRegister.cshtml"
  
    ViewData["Title"] = "پایان ثبت نام";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav aria-label=""breadcrumb"">
    <ul class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""/"">تاپ لرن</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">پایان ثبت نام</li>
    </ul>
</nav>

<div class=""container"">
    <div class=""alert alert-success"">
        <h2>");
#nullable restore
#line 16 "D:\3. porject\hashemi\Education - core5\Test\Views\Account\SuccessRegister.cshtml"
       Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" عزیز !</h2>\r\n        <p>ثبت نام شما انجام شد ، ایمیلی حاوی لینک فعالسازی به ایمیمل \"");
#nullable restore
#line 17 "D:\3. porject\hashemi\Education - core5\Test\Views\Account\SuccessRegister.cshtml"
                                                                  Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" ارسال شد .</p>\r\n        <p>جهت ادامه ثبت نام وارد ایمیل خود شوید و روی لینک کلیک کنید .</p>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n    setTimeout(function () {\r\n       window.location.href = \"https://localhost:5001\"; //will redirect to your blog page (an ex: blog.html)\r\n    }, 4000);\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
