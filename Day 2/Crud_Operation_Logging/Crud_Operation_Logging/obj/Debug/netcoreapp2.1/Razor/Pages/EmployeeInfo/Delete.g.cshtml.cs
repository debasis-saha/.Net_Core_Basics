#pragma checksum "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e2715de55847a2cb41a58a78a7b50548a729d12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Crud_Operation_Logging.Pages.EmployeeInfo.Pages_EmployeeInfo_Delete), @"mvc.1.0.razor-page", @"/Pages/EmployeeInfo/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/EmployeeInfo/Delete.cshtml", typeof(Crud_Operation_Logging.Pages.EmployeeInfo.Pages_EmployeeInfo_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e2715de55847a2cb41a58a78a7b50548a729d12", @"/Pages/EmployeeInfo/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3d1e3e798ac5e6e0c666ea584c6876aa09aafc7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_EmployeeInfo_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(113, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Employee</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(283, 57, false);
#line 16 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeCode));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(384, 53, false);
#line 19 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeCode));

#line default
#line hidden
            EndContext();
            BeginContext(437, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(481, 57, false);
#line 22 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(582, 53, false);
#line 25 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.EmployeeName));

#line default
#line hidden
            EndContext();
            BeginContext(635, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(679, 55, false);
#line 28 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(734, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(778, 51, false);
#line 31 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Department));

#line default
#line hidden
            EndContext();
            BeginContext(829, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(873, 56, false);
#line 34 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(929, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(973, 52, false);
#line 37 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1069, 56, false);
#line 40 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1169, 52, false);
#line 43 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.DateOfBirth));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1265, 53, false);
#line 46 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.JoinDate));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1362, 49, false);
#line 49 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.JoinDate));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1455, 51, false);
#line 52 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1550, 47, false);
#line 55 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.Salary));

#line default
#line hidden
            EndContext();
            BeginContext(1597, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1641, 56, false);
#line 58 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.AddressLine));

#line default
#line hidden
            EndContext();
            BeginContext(1697, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1741, 52, false);
#line 61 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.AddressLine));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1837, 50, false);
#line 64 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.State));

#line default
#line hidden
            EndContext();
            BeginContext(1887, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1931, 46, false);
#line 67 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.State));

#line default
#line hidden
            EndContext();
            BeginContext(1977, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2021, 49, false);
#line 70 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(2070, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2114, 45, false);
#line 73 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.City));

#line default
#line hidden
            EndContext();
            BeginContext(2159, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(2203, 52, false);
#line 76 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Employee.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2255, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(2299, 48, false);
#line 79 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Employee.ZipCode));

#line default
#line hidden
            EndContext();
            BeginContext(2347, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2385, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf3d240568164c068deb8a293aa688ae", async() => {
                BeginContext(2405, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2415, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0ec811c0fe54cb1bf420bdd5cfa6d1f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 84 "F:\Project_Work\Events_Session\Asp.Net_Core_Session\Day 2\Crud_Operation_Logging\Crud_Operation_Logging\Pages\EmployeeInfo\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Employee.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2460, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2544, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2fdc2b60f0c04e6aae70f834cf63d16f", async() => {
                    BeginContext(2566, 12, true);
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
                BeginContext(2582, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2595, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Crud_Operation_Logging.Pages.EmployeeInfo.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Crud_Operation_Logging.Pages.EmployeeInfo.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Crud_Operation_Logging.Pages.EmployeeInfo.DeleteModel>)PageContext?.ViewData;
        public Crud_Operation_Logging.Pages.EmployeeInfo.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
