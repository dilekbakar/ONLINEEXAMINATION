#pragma checksum "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d13cba8f024c5e4dfc296feb5ef318d05b6a9746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_ViewResult), @"mvc.1.0.view", @"/Views/Student/ViewResult.cshtml")]
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
#line 1 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\_ViewImports.cshtml"
using OnlineSinav.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\_ViewImports.cshtml"
using OnlineSinav.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\_ViewImports.cshtml"
using OnlineSinav.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d13cba8f024c5e4dfc296feb5ef318d05b6a9746", @"/Views/Student/ViewResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e718c3abe5ae20ae3897b9078e6ddf736722b2a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_ViewResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineSinav.ViewModels.ResultViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
  
    ViewData["Title"] = "ViewResult";
    Layout = "~/Views/Shared/_StudentLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Exam Results</h1>

<div>
    <br />
    <div>
        <table id=""resultGrid""
               class=""table table-striped table-bordered dt-responsive nowrap""
               width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>Exam Name</th>
                    <th>Total Questions</th>
                    <th>Correct</th>
                    <th>Wrong</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                       Write(item.ExamName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                       Write(item.TotalQuestion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                       Write(item.CorrectAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                       Write(item.WrongAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\GITHUB\ONLINEEXAMINATION\OnlineSinav\OnlineSinav.Web\Views\Student\ViewResult.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d13cba8f024c5e4dfc296feb5ef318d05b6a97466467", async() => {
                WriteLiteral("Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineSinav.ViewModels.ResultViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
