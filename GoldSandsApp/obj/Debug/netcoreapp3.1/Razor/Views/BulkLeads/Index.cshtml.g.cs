#pragma checksum "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a317aa382f635cfd34b5e21f53e858d6f84aaea0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BulkLeads_Index), @"mvc.1.0.view", @"/Views/BulkLeads/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a317aa382f635cfd34b5e21f53e858d6f84aaea0", @"/Views/BulkLeads/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f134e68c1207d1989e355dc61a0b7e8d54f462a", @"/Views/_ViewImports.cshtml")]
    public class Views_BulkLeads_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GoldSandsApp.Models.Entities.BulkLeads>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <h2>Leads List</h2>\r\n\r\n        <table class=\"table table-bordered table-sm table-striped mt-2\">\r\n            <thead class=\"table-warning\">\r\n                <tr>\r\n                    <th>");
#nullable restore
#line 14 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 15 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.UploadDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th>");
#nullable restore
#line 16 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                   Write(Html.DisplayNameFor(x => x.FileUpload));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 21 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                       Write(Html.DisplayFor(x => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                       Write(Html.DisplayFor(x => item.UploadDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a317aa382f635cfd34b5e21f53e858d6f84aaea05750", async() => {
#nullable restore
#line 27 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                                                            Write(item.FileUpload);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 969, "~/Uploads/", 969, 10, true);
#nullable restore
#line 27 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
AddHtmlAttributeValue("", 979, item.FileUpload, 979, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 32 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\BulkLeads\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GoldSandsApp.Models.Entities.BulkLeads>> Html { get; private set; }
    }
}
#pragma warning restore 1591
