#pragma checksum "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7421c4fd00774e508559050fa4464c8b00468d27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Admin.Roles.Pages_Admin_Roles_EditRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/EditRole.cshtml")]
namespace Test.Pages.Admin.Roles
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
#line 1 "D:\3. porject\hashemi\Education - core5\Test\Pages\_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
using Test.DataLayer.Entities.Permissions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7421c4fd00774e508559050fa4464c8b00468d27", @"/Pages/Admin/Roles/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f7dfff6a59c037a6860b43fe5ca02a79b4f9db8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_EditRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
  
    ViewData["Title"] = "ویرایش نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">ویرایش نقش</h1>\r\n    </div>\r\n\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7421c4fd00774e508559050fa4464c8b00468d275201", async() => {
                WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            <div class=\"panel panel-primary\">\r\n\r\n");
                WriteLiteral("\r\n                <div class=\"panel-body\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7421c4fd00774e508559050fa4464c8b00468d275659", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 27 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7421c4fd00774e508559050fa4464c8b00468d277384", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 28 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.IsDelete);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                    <div class=\"form-group\">\r\n                        <label>عنوان نقش</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7421c4fd00774e508559050fa4464c8b00468d279225", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <input type=""submit"" value=""ذخیره اطلاعات"" class=""btn btn-success""/>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    دسترسی های نقش
                </div>

                <!-- /.panel-heading -->
                <div class=""panel-body"">
");
#nullable restore
#line 47 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                      
                        List<int> SelectedPermissions = ViewData["SelectedPermissions"] as List<int>;
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ul>\r\n");
#nullable restore
#line 51 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentId == null))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\" ");
#nullable restore
#line 54 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                             Write((SelectedPermissions.Any(p => p == permission.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 54 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                    Write(permission.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"/> ");
#nullable restore
#line 54 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                Write(permission.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 56 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                 if (permissions.Any(p => p.ParentId == permission.ParentId))
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <ul>\r\n");
#nullable restore
#line 59 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentId == permission.PermissionId))
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" ");
#nullable restore
#line 62 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                   Write((SelectedPermissions.Any(p => p == sub.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 62 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                             Write(sub.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"/> ");
#nullable restore
#line 62 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                  Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 63 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                 if (permissions.Any(p => p.ParentId == sub.ParentId))
                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    <ul>\r\n\r\n");
#nullable restore
#line 67 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentId == sub.PermissionId))
                                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" ");
#nullable restore
#line 70 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                   Write((SelectedPermissions.Any(p => p == sub2.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 70 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                              Write(sub2.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"/> ");
#nullable restore
#line 70 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                                                                                                                                                                                    Write(sub2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                            </li>\r\n");
#nullable restore
#line 72 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    </ul>\r\n");
#nullable restore
#line 74 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            </li>\r\n");
#nullable restore
#line 76 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </ul>\r\n");
#nullable restore
#line 78 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </li>\r\n");
#nullable restore
#line 80 "D:\3. porject\hashemi\Education - core5\Test\Pages\Admin\Roles\EditRole.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.Admin.Roles.EditRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.Admin.Roles.EditRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.Admin.Roles.EditRoleModel>)PageContext?.ViewData;
        public Test.Pages.Admin.Roles.EditRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
