#pragma checksum "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d65069"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\_ViewImports.cshtml"
using Project.PL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\_ViewImports.cshtml"
using Project.PL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\_ViewImports.cshtml"
using Project.DAL.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\_ViewImports.cshtml"
using Project.BL.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\_ViewImports.cshtml"
using Project.PL.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d65069", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7a8f2f375f550a8eabcd76783d8c63787c07a3994b7d31884cd3f7f0105295fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Employee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row col-8 offset-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("hight", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Employees</h1>\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d650697406", async() => {
                WriteLiteral("Create New Employee");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<br />\r\n<div class=\"row justify-content-center align-content-center\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d650698968", async() => {
                WriteLiteral(@"
        <div class=""col-8"">
             <input type=""text"" class=""form-control"" name=""SearchValue"" placeholder=""Search By Name""/>
        </div>
        <div class=""col-4"">
            <input type=""submit"" value=""Search"" class=""btn-success"" />

        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n<br />\r\n\r\n");
#nullable restore
#line 27 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-striped table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>");
#nullable restore
#line 32 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 37 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 38 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 39 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 40 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                \r\n                <th>");
#nullable restore
#line 42 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
               Write(Html.DisplayNameFor(d=>d.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>Details</th>\r\n                <th>Update</th>\r\n                <th>Delete</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 49 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
             foreach (var employee in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 52 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(employee.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 53 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(employee.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 54 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E=>employee.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d6506915224", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1823, "~/files/Images/", 1823, 15, true);
#nullable restore
#line 56 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
AddHtmlAttributeValue("", 1838, employee.ImageName, 1838, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
#nullable restore
#line 58 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E=>employee.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(employee.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(Html.DisplayFor(E=>employee.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(employee.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                   Write(employee.HireDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 64 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                         if(employee.IsActive == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle \" style=\"color:green\"></i>\r\n");
#nullable restore
#line 67 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"fa-solid fa-circle \" style=\"color:red\"></i>\r\n");
#nullable restore
#line 71 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6751996d5261b2a43ba030acb5b10db6b2b52e51188abbfb4e4549c113d6506919545", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#nullable restore
#line 75 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = employee.Id.ToString();

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
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 77 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 80 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h3>There Is No Employees</h3>\r\n    </div>\r\n");
#nullable restore
#line 86 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Employee\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
