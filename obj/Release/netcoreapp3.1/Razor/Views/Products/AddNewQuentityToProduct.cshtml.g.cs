#pragma checksum "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "291b1622efe525ab9f3fb78106401795627af99b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_AddNewQuentityToProduct), @"mvc.1.0.view", @"/Views/Products/AddNewQuentityToProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"291b1622efe525ab9f3fb78106401795627af99b", @"/Views/Products/AddNewQuentityToProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_AddNewQuentityToProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlaystationProject.Dtos.Products.AddNewQuentityToProductDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("productId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control form-control-solid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("ادخل الكمية"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<link rel=""stylesheet"" href=""/css/style.css"">
<link rel=""stylesheet"" href=""/css/style-rtl.css"">

<div aria-hidden=""true"" aria-labelledby=""modal-add-quantity-label"" role=""dialog"" tabindex=""-1"" id=""modal-add-quantity"" class=""modal fade"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 id=""productNamee"" class=""section_title custom_title"">  </h4>
                <button type=""button"" class=""close"" data-bs-dismiss=""modal""><span aria-hidden=""true"">×</span></button>
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
#line 25 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                         using (Html.BeginForm(null, null, FormMethod.Post, new { id = "addQuantityForm" }))
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                                                    ;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                       Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                                                         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <!------------------------------------->\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291b1622efe525ab9f3fb78106401795627af99b7389", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 30 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                                            <div id=""register-form-wizard"">


                                                <section data-steps=""1"">
                                                    <div class=""card-body p-0"">

                                                        <div class=""form-group mb-2"">
                                                            <label class=""form-label"">الكمية<span class=""text-danger"">*</span></label>
                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "291b1622efe525ab9f3fb78106401795627af99b9636", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 39 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Quantity);

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
            WriteLiteral("\r\n                                                            ");
#nullable restore
#line 40 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                                       Write(Html.ValidationMessageFor(model => model.Quantity, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                                        </div>


                                                        <div class=""col-md-12 mx-auto mb-2"">
                                                            <div>
                                                                <button  id=""addnewQuantity"" class=""btn btn-sm m-0 login-page-form-loginBtn mt-3"" type=""button"">

                                                                    <span> اضافة الكمية</span>
                                                                    <i class=""fas fa-plus mr-3""></i>
                                                                </button>
                                                            </div>

                                                        </div>
                                                    </div>
                                                </section>

                                            </div>
                                            <!");
            WriteLiteral("------------------------------------->\r\n");
#nullable restore
#line 60 "E:\Workspaces\PlaystationProject\Views\Products\AddNewQuentityToProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>

                            </div>

                        </div>
                    </div>
                </div>

            </div>


        </div>
    </div>
</div>
          
                    <script>
                        $('#addnewQuantity').on(""click"", function () {
                            $.ajax({
                                type: ""POST"",
                                url: ""/Products/AddNewQuentityToProduct"",
                                data: $('#addQuantityForm').serialize(),
                                headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },

                                success: function (res) {
                                    if (res.success) {
                                        toastr.success('', res.message, toastr.options = {
                                            ""positionClass"": ""toast-top-right"",
          ");
            WriteLiteral(@"                                  ""fadeIn"": 300,
                                            ""fadeOut"": 100,
                                            ""timeOut"": 3000,
                                            ""extendedTimeOut"": 1000
                                        });
                                        setTimeout(function () { location.reload(); }, 2000);
                                    }
                                    else {
                                        toastr.error('', res.message, toastr.options = {
                                            ""positionClass"": ""toast-top-right"",
                                            ""fadeIn"": 300,
                                            ""fadeOut"": 100,
                                            ""timeOut"": 3000,
                                            ""extendedTimeOut"": 1000
                                        });
                                    }
                                },
                ");
            WriteLiteral(@"                error: function (jqXHR, textStatus, errorThrown) {
                                    if (jqXHR.status == 401) {
                                        toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                                            ""positionClass"": ""toast-top-right"",
                                            ""fadeIn"": 300,
                                            ""fadeOut"": 100,
                                            ""timeOut"": 3000,
                                            ""extendedTimeOut"": 1000
                                        });
                                        setTimeout(function () { location.reload() }, 2000);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlaystationProject.Dtos.Products.AddNewQuentityToProductDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
