#pragma checksum "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e54ee92a3f451f6dc1afedea1df6875e0d8e23ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Leads_ClientView), @"mvc.1.0.view", @"/Views/Leads/ClientView.cshtml")]
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
#line 1 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\_ViewImports.cshtml"
using GoldSandsApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\_ViewImports.cshtml"
using GoldSandsApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e54ee92a3f451f6dc1afedea1df6875e0d8e23ab", @"/Views/Leads/ClientView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f134e68c1207d1989e355dc61a0b7e8d54f462a", @"/Views/_ViewImports.cshtml")]
    public class Views_Leads_ClientView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoldSandsApp.Models.Entities.Leads>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ClientEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ClientPanel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
  
    ViewData["Title"] = "ClientView";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"bg-info text-capitalize text-center text-white\">Details View As Client</h1>\r\n\r\n<div>\r\n    <h4 class=\"bg\">Details of ");
#nullable restore
#line 10 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
                         Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 16 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 19 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 24 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 27 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 35 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 38 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.ClientPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 43 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 46 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n    </div>\r\n\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 55 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.OccupationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 58 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.Occupation.OccupationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n        <div class=\"col-6\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 64 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 67 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
           Write(Html.DisplayFor(model => model.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
            WriteLiteral("\r\n    <div class=\"row mt-3\">\r\n        <div class=\"col\">\r\n            <div style=\"margin-left:300px; margin-top:30px;\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54ee92a3f451f6dc1afedea1df6875e0d8e23ab10472", async() => {
                WriteLiteral("Edit Client Info");
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
#nullable restore
#line 98 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Leads\ClientView.cshtml"
                                             WriteLiteral(Model.LeadsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e54ee92a3f451f6dc1afedea1df6875e0d8e23ab12766", async() => {
                WriteLiteral("Back to Client Panel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoldSandsApp.Models.Entities.Leads> Html { get; private set; }
    }
}
#pragma warning restore 1591
