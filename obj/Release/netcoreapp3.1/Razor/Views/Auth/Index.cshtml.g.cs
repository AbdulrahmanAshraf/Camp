#pragma checksum "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e17ab8f1e2f107849fe8a5faf3a45e31bfd470c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth_Index), @"mvc.1.0.view", @"/Views/Auth/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e17ab8f1e2f107849fe8a5faf3a45e31bfd470c", @"/Views/Auth/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlaystationProject.Dtos.Account.LoginDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control login-page-form-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "username", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtUsername"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("txtpassword"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
  
    Layout = "~/Views/Shared/LoginLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""cat-area img-bg-bg workshop-section"">
    <div class=""container workshop-section-container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""overlay-img"">
                    <div class=""section-heading text-center"">
                        <img src=""../images/vicon.png"" alt=""icon section"" class=""custom-image"">
                        <h4 class=""section_title custom_title"">تسجيل الدخول</h4>
                    </div>
                </div>
                <div class=""overlay-img""></div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row mt-5"">
                <div class=""col-md-6 mx-auto"">
                    <div class=""login-page-container card border-0 mx-auto"">
                        <div class=""login-page-header mt-3 text-center"">
                            <h5>تسجيل الدخول  </h5>
                        </div>
                        <div class=""login-page-form mt-2"">
           ");
            WriteLiteral("                 <div class=\"row\">\r\n                                <div class=\"input-box col-md-9 mx-auto\">\r\n\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-md-12\">\r\n");
#nullable restore
#line 33 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
                                             using (Html.BeginForm(null, null, FormMethod.Post, new { id = "loginform" }))
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
                                           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
                                                                        ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <input type=""hidden"" name=""grtoken"" id=""hdnGrToken"" />
                                                <div class=""row"">

                                                    <div class=""col-md-12"">
                                                        <label class=""form-label"">اسم المستخدم</label>
                                                        <div class=""form-group form-group-sm"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e17ab8f1e2f107849fe8a5faf3a45e31bfd470c8204", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 42 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-12"">
                                                        <label class=""form-label"">كلمة المرور</label>
                                                        <div class=""form-group form-group-sm"">
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9e17ab8f1e2f107849fe8a5faf3a45e31bfd470c10651", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
#nullable restore
#line 48 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                    </div>
                                                    <div class=""col-md-12 mx-auto mb-2"">
                                                        <div>
                                                            <button id=""send-message-btn"" class=""btn btn-sm m-0 login-page-form-loginBtn"" type=""submit"">دخول</button>
                                                        </div>

                                                    </div>

                                                </div>
");
#nullable restore
#line 59 "E:\Workspaces\PlaystationProject\Views\Auth\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>

                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </div>
</section>
");
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#loginform').on(""submit"", function () {
            $.ajax({
                type: ""POST"",
                url: ""/Auth/Login"",
                data: $('#loginform').serialize(),
                success: function (res) {
                    if (res.success) {
                        localStorage.setItem('token', res.data.token)
                        toastr.success('', res.message, toastr.options = {
                            ""positionClass"": ""toast-top-right"",
                            ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });

                        setTimeout(function () { location.replace('/WorkingDevices'); }, 2000);
                    }
                    else {
                        toastr.error('', res.message, toastr.options = {
                            ""positionClass"": ""toast-top-right"",
             ");
                WriteLiteral(@"               ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });
                    }
                },
            });
            return false;
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlaystationProject.Dtos.Account.LoginDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
