#pragma checksum "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Account\CheckYourInbox.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "40fd45ef1c87443886d95791583622e394e8af4ff0066ea13f92659f3b53ebbc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckYourInbox), @"mvc.1.0.view", @"/Views/Account/CheckYourInbox.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"40fd45ef1c87443886d95791583622e394e8af4ff0066ea13f92659f3b53ebbc", @"/Views/Account/CheckYourInbox.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"7a8f2f375f550a8eabcd76783d8c63787c07a3994b7d31884cd3f7f0105295fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_CheckYourInbox : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "F:\.NetCourse\Assignments c#\MVC\Company\Project.PL\Project.PL\Views\Account\CheckYourInbox.cshtml"
  
    ViewData["Title"] = "CheckYourInbox";
    Layout = "~/Views/Shared/_AuthLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Check Your Inbox</h1>

<div class=""main-agileinfo"">
    <div class=""agileits-top"">
        <div class=""body"">
            <div>
                Password Reset Has Sent To YOur Email.Check Your Inbox :)
            </div>
        </div>
    </div>
</div>
");
            DefineSection("ValidationScriptSection", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "40fd45ef1c87443886d95791583622e394e8af4ff0066ea13f92659f3b53ebbc4936", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
