#pragma checksum "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa172026bb5e3ab8a072f9a5946137ce98a215ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "E:\Workspaces\PlaystationProject\Views\_ViewImports.cshtml"
using PlaystationProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspaces\PlaystationProject\Views\_ViewImports.cshtml"
using PlaystationProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa172026bb5e3ab8a072f9a5946137ce98a215ea", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Pagination.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/NoData.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mapper/cvi_tip_lib.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mapper/maputil.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/mapper/mapper.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/mapper/tooltip.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"ar\" dir=\"rtl\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea7200", async() => {
                WriteLiteral(@"
    <meta http-equiv=""content-type"" content=""text/html; charset=utf-8"">
    <meta name=""author"" content=""TechyDevs"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">

    <title>Camp Club</title>

    <!-- Google fonts -->
    <link rel=""preconnect"" href=""https://fonts.gstatic.com/"">
    <link href=""https://fonts.googleapis.com/css2?family=Inter:wght@100;200;300;400;500;600;700;800&amp;display=swap"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"" integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <!-- Favicon -->
    <link rel=""icon"" sizes=""16x16"" href=""images/vicon.png"">

    <!-- inject:css -->
    <link href=""/css/bootstrap.min.css");
                WriteLiteral(@""" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""/css/bootstrap-rtl.min.css"">
    <link rel=""stylesheet"" href=""/css/line-awesome.css"">
    <link rel=""stylesheet"" href=""/css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""/css/owl.theme.default.min.css"">
    <link rel=""stylesheet"" href=""/css/bootstrap-select.min.css"">
    <link rel=""stylesheet"" href=""/css/fancybox.css"">
    <link rel=""stylesheet"" href=""/css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""/css/style.css"">
    <link rel=""stylesheet"" href=""/css/style-rtl.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa172026bb5e3ab8a072f9a5946137ce98a215ea9284", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa172026bb5e3ab8a072f9a5946137ce98a215ea10547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                WriteLiteral("    <!-- end inject -->\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea11906", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea13004", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea14102", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fa172026bb5e3ab8a072f9a5946137ce98a215ea15200", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    ");
#nullable restore
#line 44 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
Write(RenderSection("header", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea17314", async() => {
                WriteLiteral(@"

    <!-- start cssload-loader -->
    <div class=""preloader"">
        <div class=""loader"">
            <svg class=""spinner"" viewBox=""0 0 50 50"">
                <circle class=""path"" cx=""25"" cy=""25"" r=""20"" fill=""none"" stroke-width=""5""></circle>
            </svg>
        </div>
    </div>
    <!-- end cssload-loader -->
    <!-- START HEADER AREA -->
    <header class=""header-menu-area bg-white"">
        <div class=""header-menu-content pr-150px pl-150px bg-white"">
            <div class=""container-fluid"">
                <div class=""main-menu-content"">

                    <div class=""row align-items-center"">
                        <div class=""col-lg-2"">
                            <div class=""logo-box"">
                                <img src=""../images/vicon.png"" alt=""icon section"" class=""custom-image"">
                                <h4 class=""section_title custom_title"">Camp Club</h4>
                                <div class=""user-btn-action d-flex"">
                                    <div class=""o");
                WriteLiteral(@"ff-canvas-menu-toggle main-menu-toggle icon-element icon-element-sm shadow-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""القائمة الرئيسية"">
                                        <i class=""la la-bars""></i>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-10"">
                            <div class=""menu-wrapper"">
                                <nav class=""main-menu align-items-center"">
                                    <ul>
                                        <li>
                                            <a");
                BeginWriteAttribute("href", " href=\"", 4007, "\"", 4055, 1);
#nullable restore
#line 80 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4014, Url.ActionLink("Index","WorkingDevices"), 4014, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">الرئيسية</a>\n                                        </li>\n                                        <li class=\"orders\">\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4222, "\"", 4261, 1);
#nullable restore
#line 83 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4229, Url.ActionLink("Index","Order"), 4229, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">الطلبات</a>\n                                        </li>\n                                        <li class=\"devices\">\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4428, "\"", 4470, 1);
#nullable restore
#line 86 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4435, Url.ActionLink("Index", "Devices"), 4435, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ادارة الأجهزة</a>\n                                        </li>\n                                        <li class=\"products\">\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4644, "\"", 4687, 1);
#nullable restore
#line 89 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4651, Url.ActionLink("Index", "Products"), 4651, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ادارة المنتجات</a>\n                                        </li>\n                                        <li class=\"expenses\">\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 4862, "\"", 4905, 1);
#nullable restore
#line 92 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 4869, Url.ActionLink("Index", "Expenses"), 4869, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">المصروفات</a>\n                                        </li>\n                                        <li class=\"incomes\">\n                                            <a");
                BeginWriteAttribute("href", " href=\"", 5074, "\"", 5116, 1);
#nullable restore
#line 95 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5081, Url.ActionLink("Index", "Incomes"), 5081, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">الايرادات</a>
                                        </li>
                                        <li>
                                            <a id=""todayIncomes"" href=""#"">الايراد اليومي</a>
                                        </li>
                                        <li class=""history"">
                                            <a");
                BeginWriteAttribute("href", " href=\"", 5469, "\"", 5511, 1);
#nullable restore
#line 101 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 5476, Url.ActionLink("Index", "History"), 5476, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">السجل</a>
                                        </li>
                                    </ul>
                                </nav>
                                <div class=""nav-right-button"">
                                    <div class=""d-none d-lg-inline-block mx-2"">
                                        <a class=""btn login-btn"" onclick=""logout()""><i class=""fas fa-sign-out-alt fa-rotate-180""></i></a>
                                    </div>

                                </div><!-- end nav-right-button -->
                            </div><!-- end menu-wrapper -->
                        </div><!-- end col-lg-10 -->

                        <div class=""col-lg-1""></div>
                    </div><!-- end row -->
                </div>
            </div><!-- end container-fluid -->
        </div><!-- end header-menu-content -->
        <div class=""off-canvas-menu custom-scrollbar-styled main-off-canvas-menu"">
            <div class=""off-canvas-menu-close main-menu-close icon-element icon-ele");
                WriteLiteral(@"ment-sm shadow-sm"" data-toggle=""tooltip"" data-placement=""left"" title=""Close menu"">
                <i class=""la la-times""></i>
            </div><!-- end off-canvas-menu-close -->
            <ul class=""generic-list-item off-canvas-menu-list pt-90px"">
                <li>
                    <a");
                BeginWriteAttribute("href", " href=\"", 6831, "\"", 6869, 1);
#nullable restore
#line 125 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6838, Url.ActionLink("Index","Home"), 6838, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">الرئيسية</a>\n                </li>\n                <li class=\"products\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6966, "\"", 7008, 1);
#nullable restore
#line 128 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 6973, Url.ActionLink("Index","Products"), 6973, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ادارة المنتجات</a>\n                </li>\n                <li class=\"devices\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 7110, "\"", 7151, 1);
#nullable restore
#line 131 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7117, Url.ActionLink("Index","Devices"), 7117, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">ادارة الأجهزة</a>\n                </li>\n                <li class=\"orders\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 7251, "\"", 7290, 1);
#nullable restore
#line 134 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7258, Url.ActionLink("Index","Order"), 7258, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">الطلبات</a>\n                </li>\n                <li class=\"expenses\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 7386, "\"", 7429, 1);
#nullable restore
#line 137 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7393, Url.ActionLink("Index", "Expenses"), 7393, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">المصروفات</a>\n                </li>\n                <li class=\"history\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 7526, "\"", 7568, 1);
#nullable restore
#line 140 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7533, Url.ActionLink("Index", "History"), 7533, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">السجل</a>\n                </li>\n                <li class=\"incomes\">\n                    <a");
                BeginWriteAttribute("href", " href=\"", 7661, "\"", 7703, 1);
#nullable restore
#line 143 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 7668, Url.ActionLink("Index", "Incomes"), 7668, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">الايرادات</a>
                </li>
            </ul>

            <div class=""login-btn-sm-container"">
                <a class=""btn login-btn-sm p-1"" onclick=""logout()"">خروج</a>
            </div>
        </div><!-- end off-canvas-menu -->
        <div class=""body-overlay""></div>
    </header><!-- end header-menu-area -->
    <!-- END HEADER AREA -->
    ");
#nullable restore
#line 154 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("_TodayIncomes"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    ");
#nullable restore
#line 156 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n    <!-- template js files -->\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea28742", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script src=""/js/bootstrap.min.js""></script>
    <script src=""/js/owl.carousel.min.js""></script>
    <script src=""/js/fancybox.js""></script>
    <script src=""/js/jquery.lazy.min.js""></script>
    <script src=""/js/jquery.magnific-popup.min.js""></script>
    <script src=""/js/jquery.counterup.min.js""></script>
    <script src=""/js/main-rtl.js""></script>
    <script type=""text/javascript"" charset=""utf8"" src=""https:////cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa172026bb5e3ab8a072f9a5946137ce98a215ea30358", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#nullable restore
#line 168 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    <script");
                BeginWriteAttribute("src", " src=\"", 8786, "\"", 8835, 1);
#nullable restore
#line 169 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8792, Url.Content("~/js/jquery.validate.min.js"), 8792, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n    <script");
                BeginWriteAttribute("src", " src=\"", 8858, "\"", 8919, 1);
#nullable restore
#line 170 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 8864, Url.Content("~/js/jquery.validate.unobtrusive.min.js"), 8864, 55, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\n");
                WriteLiteral(@"    <script type=""text/javascript"">
        $(function () {
            $.ajax({
                type: ""Get"",
                url: ""/CheckAuthorization/GetCanViewLinks"",
                headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },
                success: function (res) {
                    if (res.showProducts == false) {
                        $("".products"").hide();
                    }
                    if (res.showDevices == false) {
                        $("".devices"").hide();
                    }
                    if (res.showOrders == false) {
                        $("".orders"").hide();
                    }
                    if (res.showExpenses == false) {
                        $("".expenses"").hide();
                    }
                    if (res.showHistory == false) {
                        $("".history"").hide();
                    }
                    if (res.showIncomes == false) {
                        $("".incomes"").hide();
                    }
 ");
                WriteLiteral(@"               }, error: function (jqXHR, textStatus, errorThrown) {
                    if (jqXHR.status == 401) {
                        toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                            ""positionClass"": ""toast-top-right"",
                            ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });
                        window.location.href = '/auth';
                    }
                }
            });
        });
    </script>

    <script>

        $('#todayIncomes').click(function (e) {
            let url = 'Incomes/GetTodayIncomes'
            $.get(url).done(function (data) {
                $('#incomesId').html(data.data.incomes)
                $('#expensesId').html(data.data.expenses)
                $('#today-incomes-modal').modal('show')
            })
        });

        function logout() {
            localStorage.cl");
                WriteLiteral("ear();\n            window.location.href = \'/auth\';\n        };\n    </script>\n\n    ");
#nullable restore
#line 230 "E:\Workspaces\PlaystationProject\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
