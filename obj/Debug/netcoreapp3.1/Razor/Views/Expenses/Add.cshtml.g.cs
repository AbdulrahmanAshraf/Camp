#pragma checksum "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a206e88110eed5d57a99bd9b2a38d013142f8020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Expenses_Add), @"mvc.1.0.view", @"/Views/Expenses/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a206e88110eed5d57a99bd9b2a38d013142f8020", @"/Views/Expenses/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_Expenses_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlaystationProject.Dtos.Expenses.AddExpenseDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select form-select-sm form-control-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Default select example"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("ادخل وصف المصروف"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("min", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("ادخل التكلفة"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""cat-area img-bg-bg workshop-section"">
    <div class=""container workshop-section-container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""overlay-img"">
                    <div class=""section-heading text-center"">
                        <img src=""../images/vicon.png"" alt=""icon section"" class=""custom-image"">
                        <h4 class=""section_title custom_title"">اضافة مصروف</h4>
                    </div>
                </div>
                <div class=""overlay-img""></div>
            </div>
        </div>

        <div class=""container"" dir=""rtl"">
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-10 m-auto"">
                        <div class=""row"">
                            <div class=""col-12 mt-5 row"" id=""div-register"">
                                <div class=""col-12 steps-page-content"">
");
#nullable restore
#line 24 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                     using (Html.BeginForm(null, null, FormMethod.Post, new { id = "addForm" }))
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                                ;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <input type=""hidden"" name=""grtoken"" id=""hdnGrToken"" />
                                        <div id=""register-form-wizard"">
                                            <section data-steps=""1"">
                                                <div class=""card-body p-0"">
                                                    <div class=""form-group mb-2"">
                                                        <label class=""form-label"">نوع المصروف<span class=""text-danger"">*</span></label>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a206e88110eed5d57a99bd9b2a38d013142f80208772", async() => {
                WriteLiteral("\r\n                                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a206e88110eed5d57a99bd9b2a38d013142f80209092", async() => {
                    WriteLiteral("ادخل نوع المصروف");
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
#line 35 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                             foreach (var type in ViewBag.types)
                                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a206e88110eed5d57a99bd9b2a38d013142f802011048", async() => {
#nullable restore
#line 37 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                                                      Write(type.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                                   WriteLiteral(type.Code);

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
#line 38 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 33 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Type);

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
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 40 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                   Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group mb-2"">
                                                        <label class=""form-label form-label"">وصف المصروف<span class=""text-danger"">*</span></label>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a206e88110eed5d57a99bd9b2a38d013142f802015337", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 44 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

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
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 45 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""form-group mb-2"">
                                                        <label class=""form-label"">التكلفة<span class=""text-danger"">*</span></label>
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a206e88110eed5d57a99bd9b2a38d013142f802017843", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
#nullable restore
#line 49 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Cost);

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
            WriteLiteral("\r\n                                                        ");
#nullable restore
#line 50 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                                   Write(Html.ValidationMessageFor(model => model.Cost, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                    </div>
                                                    <div class=""col-md-12 mx-auto mb-2"">
                                                        <div>
                                                            <button id=""send-message-btn"" class=""btn btn-sm m-0 login-page-form-loginBtn mt-3"" type=""submit"">
                                                                <span>اضافة</span>
                                                                <i class=""fa fa-plus mr-3""></i>
                                                            </button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </section>
                                        </div>
");
#nullable restore
#line 63 "E:\Workspaces\PlaystationProject\Views\Expenses\Add.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<script type=""text/javascript"">
    $(function () {
        $.ajax({
            type: ""Get"",
            url: ""/CheckAuthorization/GetCanViewLinks"",
            headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },
            success: function (res) {
                if (res.showDevices == false) {
                    toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                        ""positionClass"": ""toast-top-right"",
                        ""fadeIn"": 300,
                        ""fadeOut"": 100,
                        ""timeOut"": 3000,
                        ""extendedTimeOut"": 1000
                    });
                    window.location.href = '/auth';
                }

            }, error: function (jqXHR, textStatus, errorThro");
            WriteLiteral(@"wn) {
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
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $('#addForm').on(""submit"", function () {
            $.ajax({
                type: ""POST"",
                url: ""/Expenses/Add"",
                data: $('#addForm').serialize(),
                 headers: {""Authorization"": 'Bearer '+localStorage.getItem('token')},
                success: function (res) {
                    if (res.success) {
                        toastr.success('', res.message, toastr.options = {
                            ""positionClass"": ""toast-top-right"",
                            ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });
                        setTimeout(function () { location.replace('/Expenses'); }, 1000);
                    }
                    else {
                        toastr.error('', res.message, toastr.options = {
                            ""positionClass"": ""toast-top-right"",
       ");
                WriteLiteral(@"                     ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });
                    }
                },  error: function(jqXHR, textStatus, errorThrown){
        if(jqXHR.status==401){
         toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                            ""positionClass"": ""toast-top-right"",
                            ""fadeIn"": 300,
                            ""fadeOut"": 100,
                            ""timeOut"": 3000,
                            ""extendedTimeOut"": 1000
                        });
            setTimeout(function () { location.replace('/Expenses'); }, 1000);
        }

  }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlaystationProject.Dtos.Expenses.AddExpenseDto> Html { get; private set; }
    }
}
#pragma warning restore 1591