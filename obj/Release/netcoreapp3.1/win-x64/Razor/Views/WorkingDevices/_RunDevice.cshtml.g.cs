#pragma checksum "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8fc60feff8102992251ea479f08f871b32cb9fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkingDevices__RunDevice), @"mvc.1.0.view", @"/Views/WorkingDevices/_RunDevice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8fc60feff8102992251ea479f08f871b32cb9fa", @"/Views/WorkingDevices/_RunDevice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkingDevices__RunDevice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlaystationProject.Dtos.Devices.RunDeviceDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select form-select-sm form-control-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Default select example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jquery-3.6.0.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<link rel=""stylesheet"" href=""/css/style.css"">
<link rel=""stylesheet"" href=""/css/style-rtl.css"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.15.4/css/all.css"" integrity=""sha384-DyZ88mC6Up2uqS4h/KRgHuoeGwBcD4Ng9SiP4dIRy0EXTlnuz47vAwmeGwVChigm"" crossorigin=""anonymous"">


<div aria-hidden=""true"" aria-labelledby=""modal-run-device-label"" role=""dialog"" tabindex=""-1"" id=""modal-run-device"" class=""modal fade""
     data-bs-keyboard=""false"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""section_title custom_title"">تشغيل جهاز</h4>
                <button type=""button"" class=""close"" data-bs-dismiss=""modal""><span aria-hidden=""true"">×</span></button>
            </div>
");
#nullable restore
#line 16 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
             using (Html.BeginForm(null, null, FormMethod.Post, new { id = "addForm" }))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""modal-body form-horizontal"" dir=""rtl"">
                    <div class=""form-group row"">
                        <div class=""form-group mb-2 text-right"">
                            <label class=""form-label""> اسم الجهاز<span class=""text-danger"">*</span></label>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fc60feff8102992251ea479f08f871b32cb9fa6490", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fc60feff8102992251ea479f08f871b32cb9fa6782", async() => {
                    WriteLiteral("اختر الجهاز");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                                 foreach (var device in ViewData["devices"] as List<PlaystationProject.Dtos.DropDown>)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fc60feff8102992251ea479f08f871b32cb9fa8712", async() => {
#nullable restore
#line 28 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                                                          Write(device.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                                       WriteLiteral(device.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 24 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeviceId);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
#nullable restore
#line 31 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                       Write(Html.ValidationMessageFor(model => model.DeviceId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group text-right"">
                                <input type=""radio"" value=""SINGL"" name=""PeriodType"" /> فردي
                            </div>
                        </div>
                        <div class=""col-md-6 text-right"">
                            <div class=""form-group"">
                                <input type=""radio"" value=""MULTI"" name=""PeriodType"" />  زوجي
                            </div>
                        </div>
                        ");
#nullable restore
#line 45 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
                   Write(Html.ValidationMessageFor(model => model.PeriodType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button class=""btn btn-sm m-0 login-page-form-loginBtn mt-3"" id=""btnSubmit"">
                        <i class=""fa fa-power-off""></i>  تشغيل
                    </button>
                </div>
");
#nullable restore
#line 53 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8fc60feff8102992251ea479f08f871b32cb9fa14122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"/js/bootstrap.min.js\"></script>\r\n<script");
            BeginWriteAttribute("src", " src=\"", 3177, "\"", 3226, 1);
#nullable restore
#line 61 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
WriteAttributeValue("", 3183, Url.Content("~/js/jquery.validate.min.js"), 3183, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></script>\r\n<script");
            BeginWriteAttribute("src", " src=\"", 3246, "\"", 3307, 1);
#nullable restore
#line 62 "E:\Workspaces\PlaystationProject\Views\WorkingDevices\_RunDevice.cshtml"
WriteAttributeValue("", 3252, Url.Content("~/js/jquery.validate.unobtrusive.min.js"), 3252, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></script>
<script type=""text/javascript"">
    $(function () {
        $.ajax({
            type: ""Get"",
            url: ""/CheckAuthorization/GetCanViewLinks"",
            headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },
            success: function (res) {
                if (res.workingDevices == false) {
                    $("".workingDevices"").hide();
                }
            }, error: function (jqXHR, textStatus, errorThrown) {
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
    $('#btnSubmit').on(""click"",");
            WriteLiteral(@" function () {
        $.ajax({
            type: ""POST"",
            url: ""/WorkingDevices/RunDevice"",
            data: $('#addForm').serialize(),
            headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },

            success: function (res) {
                if (res.success) {
                    toastr.success('', res.message, toastr.options = {
                        ""positionClass"": ""toast-top-right"",
                        ""fadeIn"": 300,
                        ""fadeOut"": 100,
                        ""timeOut"": 3000,
                        ""extendedTimeOut"": 1000
                    });
                    setTimeout(function () { location.replace('/'); }, 1000);
                }
                else {
                    toastr.error('', res.message, toastr.options = {
                        ""positionClass"": ""toast-top-right"",
                        ""fadeIn"": 300,
                        ""fadeOut"": 100,
                        ""timeOut"": 3000,
 ");
            WriteLiteral(@"                       ""extendedTimeOut"": 1000
                    });
                }
            },
            error: function (jqXHR, textStatus, errorThrown) {
                if (jqXHR.status == 401) {
                    toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                        ""positionClass"": ""toast-top-right"",
                        ""fadeIn"": 300,
                        ""fadeOut"": 100,
                        ""timeOut"": 3000,
                        ""extendedTimeOut"": 1000
                    });
                    setTimeout(function () { location.replace('/'); }, 1000);
                }

            }
        });
        return false;
    });
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlaystationProject.Dtos.Devices.RunDeviceDto> Html { get; private set; }
    }
}
#pragma warning restore 1591