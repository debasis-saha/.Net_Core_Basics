#pragma checksum "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ef4c00b507dcd2e12719e740a6db8b2c7fbeb11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Crud_Operation_Logging.Pages.EmployeeInfo.Pages_EmployeeInfo_Details), @"mvc.1.0.razor-page", @"/Pages/EmployeeInfo/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeeInfo/Details.cshtml", typeof(Crud_Operation_Logging.Pages.EmployeeInfo.Pages_EmployeeInfo_Details), null)]
namespace Crud_Operation_Logging.Pages.EmployeeInfo
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\_ViewImports.cshtml"
using Crud_Operation_Logging;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ef4c00b507dcd2e12719e740a6db8b2c7fbeb11", @"/Pages/EmployeeInfo/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d1e3e798ac5e6e0c666ea584c6876aa09aafc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeeInfo_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(115, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(238, 57, false);
#line 15 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeCode));

#line default
#line hidden
            EndContext();
            BeginContext(295, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(339, 53, false);
#line 18 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeCode));

#line default
#line hidden
            EndContext();
            BeginContext(392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(436, 57, false);
#line 21 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(493, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(537, 53, false);
#line 24 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(590, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(634, 55, false);
#line 27 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(689, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(733, 51, false);
#line 30 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(784, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(828, 56, false);
#line 33 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(884, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(928, 52, false);
#line 36 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(980, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1024, 56, false);
#line 39 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1124, 52, false);
#line 42 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1176, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1220, 53, false);
#line 45 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.JoinDate));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1317, 49, false);
#line 48 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.JoinDate));

#line default
#line hidden
            EndContext();
            BeginContext(1366, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1410, 51, false);
#line 51 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1461, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1505, 47, false);
#line 54 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1596, 56, false);
#line 57 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.AddressLine));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1696, 52, false);
#line 60 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.AddressLine));

#line default
#line hidden
            EndContext();
            BeginContext(1748, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1792, 50, false);
#line 63 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.State));

#line default
#line hidden
            EndContext();
            BeginContext(1842, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1886, 46, false);
#line 66 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.State));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1976, 49, false);
#line 69 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2069, 45, false);
#line 72 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(2114, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2158, 52, false);
#line 75 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2254, 48, false);
#line 78 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
       Write(Html.DisplayFor(model => model.Employee.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2349, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0470c6b483b48bf8fec2a5f03dc4097", async() => {
                BeginContext(2404, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Details.cshtml"
                           WriteLiteral(Model.Employee.Id);

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
            BeginContext(2412, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2420, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e55aef9c55433bb509c035e08cb812", async() => {
                BeginContext(2442, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2458, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crud_Operation_Logging.Pages.EmployeeInfo.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Crud_Operation_Logging.Pages.EmployeeInfo.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Crud_Operation_Logging.Pages.EmployeeInfo.DetailsModel>)PageContext?.ViewData;
        public Crud_Operation_Logging.Pages.EmployeeInfo.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591