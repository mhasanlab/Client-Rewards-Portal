#pragma checksum "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f134e68c1207d1989e355dc61a0b7e8d54f462a", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GoldSandsApp.Models.Entities.Leads>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Assets/images/icon/user.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Wellcome: "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignOut", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "View", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Leads", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_ClientLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PAGE CONTAINER-->
<div class=""page-container"">

    <!-- HEADER DESKTOP-->
    <header class=""header-desktop"">
        <div class=""section__content section__content--p30"">
            <div class=""container-fluid"">
                <div class=""header-wrap"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc9027", async() => {
                WriteLiteral(@"
                        <input class=""au-input au-input--xl"" type=""text"" name=""search"" placeholder=""Search for datas &amp; reports..."" />
                        <button class=""au-btn--submit"" type=""submit"">
                            <i class=""zmdi zmdi-search""></i>
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"header-button\">\r\n\r\n");
#nullable restore
#line 23 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"account-wrap\">\r\n                                <div class=\"account-item clearfix js-item-menu\">\r\n                                    <div class=\"image\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc11565", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"content\">\r\n                                        <a class=\"js-acc-btn\" href=\"#\">");
#nullable restore
#line 31 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                                                  Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                    </div>
                                    <div class=""account-dropdown js-dropdown"">
                                        <div class=""info clearfix"">
                                            <div class=""image"">
                                                <a href=""#"">
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc13553", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </a>
                                            </div>
                                            <div class=""content"">
                                                <h5 class=""text"">
                                                    <a href=""#"">");
#nullable restore
#line 42 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                                           Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                </h5>\r\n                                                <span class=\"email\">");
#nullable restore
#line 44 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                                               Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </div>\r\n                                        </div>\r\n\r\n                                        <div class=\"account-dropdown__footer\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc15954", async() => {
                WriteLiteral("\r\n                                                <i class=\"zmdi zmdi-power\"></i>Logout\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 56 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </header>
    <!-- HEADER DESKTOP-->
    <!-- MAIN CONTENT-->
    <div class=""main-content"">
        <div class=""section__content section__content--p30"">
            <div class=""container-fluid"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""overview-wrap"">
                            <h2 class=""title-1"">Client Dashboard Overview</h2>

                        </div>
                    </div>
                </div>
                <div class=""row m-t-25"">
                    <div class=""col-sm-6 col-lg-3"">
                        <div class=""overview-item overview-item--c1"">
                            <div class=""overview__inner"">
                                <div class=""overview-box clearfix"">
                                    <div class=""icon"">
");
            WriteLiteral("                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 84 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>Total Client</span>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-lg-3"">
                        <div class=""overview-item overview-item--c2"">
                            <div class=""overview__inner"">
                                <div class=""overview-box clearfix"">
                                    <div class=""icon"">
");
            WriteLiteral("                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 102 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(ViewBag.ProspectCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>Total Prospect</span>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-lg-3"">
                        <div class=""overview-item overview-item--c3"">
                            <div class=""overview__inner"">
                                <div class=""overview-box clearfix"">
                                    <div class=""icon"">
");
            WriteLiteral("                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 120 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(ViewBag.NursingCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>Totla Nursing</span>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                    <div class=""col-sm-6 col-lg-3"">
                        <div class=""overview-item overview-item--c4"">
                            <div class=""overview__inner"">
                                <div class=""overview-box clearfix"">
                                    <div class=""icon"">
");
            WriteLiteral("                                    </div>\r\n                                    <div class=\"text\">\r\n                                        <h2>");
#nullable restore
#line 138 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(ViewBag.SoldCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                        <span>Total Sold</span>\r\n                                    </div>\r\n                                </div>\r\n");
            WriteLiteral(@"                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-lg-12"">
                        <h2 class=""title-1 m-b-25"">Client List</h2>
                        <div class=""table-responsive table-data table--no-card m-b-40"">
                            <table class=""table table-borderless table-striped table-earning"">
                                <thead>
                                    <tr>
                                        <th>");
#nullable restore
#line 157 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 158 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 159 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.ClientPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 160 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 161 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.OccupationId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>");
#nullable restore
#line 162 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayNameFor(x => x.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                        <th>Action</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 167 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 170 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.ClientName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 171 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.ClientAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 172 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.ClientPhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 173 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.ClientEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 174 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.Occupation.OccupationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 175 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                       Write(Html.DisplayFor(x => item.Designation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc28110", async() => {
                WriteLiteral("<i class=\"fa fa-eye\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 177 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                                                                          WriteLiteral(item.LeadsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc30688", async() => {
                WriteLiteral("\r\n                                                <i class=\"fa\r\n fa-pencil-square-o\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 178 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                                                                          WriteLiteral(item.LeadsId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 185 "F:\GoldSands Projects\Gold Sand Final Backup\GoldSandsApp\GoldSandsApp\Views\Client\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>

                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""copyright"">
                            &copy; 2022 - GoldSandsApp - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad96c336f0fe9c5a64bfd61a9c3340234bb4abdc34049", async() => {
                WriteLiteral("Privacy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- END MAIN CONTENT-->\r\n    <!-- END PAGE CONTAINER-->\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GoldSandsApp.Models.Entities.Leads>> Html { get; private set; }
    }
}
#pragma warning restore 1591