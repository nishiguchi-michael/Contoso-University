#pragma checksum "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65e311959db3a6ec0db11913e2426502f125844"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Details), @"mvc.1.0.view", @"/Views/Students/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Students/Details.cshtml", typeof(AspNetCore.Views_Students_Details))]
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
#line 1 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\_ViewImports.cshtml"
using University_App;

#line default
#line hidden
#line 2 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\_ViewImports.cshtml"
using University_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65e311959db3a6ec0db11913e2426502f125844", @"/Views/Students/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"312cdbcd0a3a9bc9ccecdc126d8f0052844a97db", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<University_App.Models.Student>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(37, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 120, true);
            WriteLiteral("\n<h1>Details</h1>\n\n<div>\n    <h4>Student</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(199, 44, false);
#line 14 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(243, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(302, 40, false);
#line 17 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(342, 57, true);
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
            EndContext();
            BeginContext(400, 48, false);
#line 20 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(448, 58, true);
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
            EndContext();
            BeginContext(507, 44, false);
#line 23 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(551, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(592, 47, false);
#line 26 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Enrollments));

#line default
#line hidden
            EndContext();
            BeginContext(639, 182, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            <table class=\"table\">\n                <tr>\n                    <th>Course Title</th>\n                    <th>Grade</th>\n                </tr>\n");
            EndContext();
#line 34 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
                 foreach (var item in Model.Enrollments)
                {

#line default
#line hidden
            BeginContext(896, 82, true);
            WriteLiteral("                    <tr>\n                        <td>\n                            ");
            EndContext();
            BeginContext(979, 47, false);
#line 38 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Course.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 88, true);
            WriteLiteral("\n                        </td>\n                        <td>\n                            ");
            EndContext();
            BeginContext(1115, 40, false);
#line 41 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(1155, 57, true);
            WriteLiteral("\n                        </td>\n                    </tr>\n");
            EndContext();
#line 44 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
                        
                }

#line default
#line hidden
            BeginContext(1255, 62, true);
            WriteLiteral("            </table>\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1317, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65e311959db3a6ec0db11913e2426502f1258448309", async() => {
                BeginContext(1363, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Michael\Downloads\CIT-365-master\University App\University App\Views\Students\Details.cshtml"
                           WriteLiteral(Model.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1371, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1378, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65e311959db3a6ec0db11913e2426502f12584410650", async() => {
                BeginContext(1400, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1416, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<University_App.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
