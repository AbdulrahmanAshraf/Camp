#pragma checksum "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757e75a6d4e10f674f4b3ceda3df270dbe6f6aad", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"241a1bfba065d8c872faf2128710e5d6ee9c49af", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PlaystationProject.Dtos.Products.GetProductDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Pagination.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/NoData.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "20", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "40", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "60", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "80", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad5779", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad6976", async() => {
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "ادارة المنتجات";

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
                        <h4 class=""section_title custom_title"">ادارة المنتجات </h4>
                    </div>
                </div>
                <div class=""overlay-img""></div>
            </div>
        </div>
        <div id=""placeHolder""></div>
        <button id=""send-message-btn"" class=""btn btn-sm m-0 login-page-form-loginBtn mb-4""");
            BeginWriteAttribute("onclick", " onclick=\"", 983, "\"", 1049, 3);
            WriteAttributeValue("", 993, "location.href=\'", 993, 15, true);
#nullable restore
#line 24 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 1008, Url.Action("CreateProduct", "Products"), 1008, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1048, "\'", 1048, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <span> اضافة منتج</span>\r\n            <i class=\"fa fa-plus mr-3\"></i>\r\n\r\n        </button>\r\n");
#nullable restore
#line 29 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
         using (Html.BeginForm("Index", "Products", FormMethod.Get))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row d-flex justify-content-center workshop-table-container mb-3"">
        <div class=""col-md-1"">
            <span>عرض</span>
        </div>
        <div class=""col-sm-1"">
            <span>
                <select class=""form-select form-select-sm mySelect"" aria-label=""Default select example"" name=""pagesize"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad10418", async() => {
                WriteLiteral("20");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad11594", async() => {
                WriteLiteral("40");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad12770", async() => {
                WriteLiteral("60");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "757e75a6d4e10f674f4b3ceda3df270dbe6f6aad13946", async() => {
                WriteLiteral("80");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </select>\r\n            </span>\r\n        </div>\r\n        <div class=\"col-sm-1\">\r\n            <span>عنصر</span>\r\n        </div>\r\n        <div class=\"col-sm-4\">\r\n            <span>بحث:</span>\r\n            <input type=\"text\" name=\"search\"");
            BeginWriteAttribute("value", " value=\"", 2031, "\"", 2054, 1);
#nullable restore
#line 50 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 2039, ViewBag.search, 2039, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n        <div class=\"col-md-1\">\r\n            <button id=\"send-message-btn\" class=\"btn btn-sm m-0 login-page-form-loginBtn\" type=\"submit\">بحث</button>\r\n        </div>\r\n");
#nullable restore
#line 55 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
         if (ViewBag.search != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-2\">\r\n                <button class=\"btn btn-sm m-0 login-page-form-loginBtn\" style=\"background-color:red\" type=\"button\"");
            BeginWriteAttribute("onclick", "\r\n                        onclick=\"", 2441, "\"", 2524, 3);
            WriteAttributeValue("", 2476, "location.href=\'", 2476, 15, true);
#nullable restore
#line 59 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 2491, Url.Action("Index", "Products"), 2491, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2523, "\'", 2523, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    الغاء البحث\r\n                    <i class=\"fa fa-times\" aria-hidden=\"true\"></i>\r\n\r\n                </button>\r\n            </div>\r\n");
#nullable restore
#line 65 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 67 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
         if (Model.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row d-flex justify-content-center  workshop-table-container"">
             <div class=""col-md-9"">
                 <table class=""responsive-table"">
                     <tr class=""text-center"">
                         <th>اسم المنتج</th>
                         <th>الكمية</th>
                         <th>السعر</th>
                         <th>الفئة</th>
                         <th>اخر تعديل</th>
                         <th>التحكم</th>
                     </tr>
");
#nullable restore
#line 80 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                      foreach (var product in Model)
                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                         <tr");
            BeginWriteAttribute("id", " id=\"", 3353, "\"", 3369, 1);
#nullable restore
#line 82 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 3358, product.Id, 3358, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                             <td data-th=\"اسم المنتج\">");
#nullable restore
#line 83 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td data-th=\"الكمية\"> ");
#nullable restore
#line 84 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                              Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                             <td data-th=\"السعر\">");
#nullable restore
#line 85 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                            Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                             <td data-th=\"الفئة\">");
#nullable restore
#line 86 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                            Write(product.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                             <td data-th=\"اخر تعديل\">");
#nullable restore
#line 87 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                                Write(product.LastModifiedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                             <td data-th=\"التحكم\">\r\n                                 <button id=\"addQuantity\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3862, "\"", 3914, 5);
            WriteAttributeValue("", 3872, "addQuantity(\'", 3872, 13, true);
#nullable restore
#line 89 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 3885, product.Id, 3885, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3896, "\',\'", 3896, 3, true);
#nullable restore
#line 89 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 3899, product.Name, 3899, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3912, "\')", 3912, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"
                                         class=""btn btn-info text-center detail-ws-btn"" type=""button"" data-toggle=""modal"" data-target=""#exampleModal"" data-bs-target=""#modal-add-quantity"">
                                     <i class=""fa fa-plus""></i>


                                 </button>

                                 <button class=""btn btn-info text-center detail-ws-btn"" type=""button"" data-toggle=""modal"" data-target=""#exampleModal""");
            BeginWriteAttribute("onclick", "\r\n                                         onclick=\"", 4370, "\"", 4512, 3);
            WriteAttributeValue("", 4422, "location.href=\'", 4422, 15, true);
#nullable restore
#line 97 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 4437, Url.Action("EditProduct", "Products", new { id = product.Id.ToString() }), 4437, 74, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4511, "\'", 4511, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                     <i class=""fas fa-edit""></i>
                                 </button>
                                 <button class=""btn btn-danger text-center detail-ws-btn"" type=""button"" data-toggle=""modal"" data-target=""#exampleModal""");
            BeginWriteAttribute("onclick", "\r\n                                         onclick=\"", 4777, "\"", 4857, 3);
            WriteAttributeValue("", 4829, "ConfirmDelete(\'", 4829, 15, true);
#nullable restore
#line 101 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 4844, product.Id, 4844, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4855, "\')", 4855, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                     <i class=\"fa fa-trash\"></i>\r\n\r\n                                 </button>\r\n\r\n                             </td>\r\n                         </tr>\r\n");
#nullable restore
#line 108 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                 </table>\r\n");
#nullable restore
#line 117 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                  if (ViewBag.pageCount > 1)
                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                     <nav aria-label=\"Page navigation example\">\r\n                         <ul class=\"pagination\">\r\n");
#nullable restore
#line 121 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                              if (ViewBag.pagenumber > 1)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <li class=\"page-item\">\r\n                                     <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5817, "\"", 5924, 8);
            WriteAttributeValue("", 5824, "/Products/Index?page=", 5824, 21, true);
#nullable restore
#line 124 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 5845, ViewBag.pagenumber-1, 5845, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5868, "&&", 5869, 3, true);
            WriteAttributeValue(" ", 5871, "search=", 5872, 8, true);
#nullable restore
#line 124 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 5879, ViewBag.search, 5879, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 5894, "&&", 5895, 3, true);
            WriteAttributeValue(" ", 5897, "pagesize=", 5898, 10, true);
#nullable restore
#line 124 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 5907, ViewBag.pagesize, 5907, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                         <span aria-hidden=\"true\">&raquo;</span>\r\n                                     </a>\r\n                                 </li>\r\n");
#nullable restore
#line 128 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                              for (int i = 0; i < ViewBag.pageCount; i++)
                             {
                                 if ((i + 1) == ViewBag.pagenumber)
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <li class=\"page-item\">\r\n                                         <a style=\"background-color: #1b6ec2;color:white\" class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6527, "\"", 6617, 8);
            WriteAttributeValue("", 6534, "/Products/Index?page=", 6534, 21, true);
#nullable restore
#line 134 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6555, i+1, 6555, 6, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6561, "&&", 6562, 3, true);
            WriteAttributeValue(" ", 6564, "search=", 6565, 8, true);
#nullable restore
#line 134 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6572, ViewBag.search, 6572, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6587, "&&", 6588, 3, true);
            WriteAttributeValue(" ", 6590, "pagesize=", 6591, 10, true);
#nullable restore
#line 134 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6600, ViewBag.pagesize, 6600, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 134 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                                                                                                                                                                                   Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                     </li>\r\n");
#nullable restore
#line 136 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                 }
                                 else
                                 {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                     <li class=\"page-item\">\r\n                                         <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 6908, "\"", 7000, 8);
            WriteAttributeValue("", 6915, "/Products/Index?page=", 6915, 21, true);
#nullable restore
#line 140 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6936, i + 1, 6936, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6944, "&&", 6945, 3, true);
            WriteAttributeValue(" ", 6947, "search=", 6948, 8, true);
#nullable restore
#line 140 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6955, ViewBag.search, 6955, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 6970, "&&", 6971, 3, true);
            WriteAttributeValue(" ", 6973, "pagesize=", 6974, 10, true);
#nullable restore
#line 140 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 6983, ViewBag.pagesize, 6983, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 140 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                                                                                                                                       Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                     </li>\r\n");
#nullable restore
#line 142 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                 }
                             }

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                              if (ViewBag.pagenumber < ViewBag.pageCount)
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <li>\r\n                                     <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 7331, "\"", 7440, 8);
            WriteAttributeValue("", 7338, "/Products/Index?page=", 7338, 21, true);
#nullable restore
#line 147 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 7359, ViewBag.pagenumber + 1, 7359, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7384, "&&", 7385, 3, true);
            WriteAttributeValue(" ", 7387, "search=", 7388, 8, true);
#nullable restore
#line 147 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 7395, ViewBag.search, 7395, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 7410, "&&", 7411, 3, true);
            WriteAttributeValue(" ", 7413, "pagesize=", 7414, 10, true);
#nullable restore
#line 147 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
WriteAttributeValue("", 7423, ViewBag.pagesize, 7423, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Next\">\r\n                                         <span aria-hidden=\"true\">&laquo;</span>\r\n                                     </a>\r\n                                 </li>\r\n");
#nullable restore
#line 151 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                         </ul>\r\n                     </nav>\r\n");
#nullable restore
#line 154 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("             </div>\r\n            </div>\r\n");
#nullable restore
#line 157 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"empty-data-block mt-5\">\r\n                <div>\r\n                    <img src=\"./images/noData.svg\" alt=\"No Data Image\" />\r\n                    <p>لا يوجد بيانات</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 166 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    ");
#nullable restore
#line 168 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
Write(await Html.PartialAsync("~/Views/Products/AddNewQuentityToProduct.cshtml", new PlaystationProject.Dtos.Products.AddNewQuentityToProductDto()));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"}

</section>


<script type=""text/javascript"">
    $(function () {
        $.ajax({
            type: ""Get"",
            url: ""/CheckAuthorization/GetCanViewLinks"",
            headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },
            success: function (res) {
                if (res.showProducts == false) {
                    toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                        ""positionClass"": ""toast-top-right"",
                        ""fadeIn"": 300,
                        ""fadeOut"": 100,
                        ""timeOut"": 3000,
                        ""extendedTimeOut"": 1000
                    });
                    window.location.href = '/auth';
                }
                else   $("".mySelect"").val(");
#nullable restore
#line 190 "E:\Workspaces\PlaystationProject\Views\Products\Index.cshtml"
                                     Write(ViewBag.pagesize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@").attr('selected', 'selected');
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
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        function ConfirmDelete(productId) {
            swal({
                title: ""هل انت متأكد من الحذف؟"",
                text: """",
                icon: ""warning"",
                buttons: [""الغاء"", ""تأكيد""],
                dangerMode: true,
            }).then((willDelete) => {
                if (willDelete) {
                    $.ajax({
                        url: `/Products/DeleteProduct/${productId}`,
                        type: ""Get"",
                        headers: { ""Authorization"": 'Bearer ' + localStorage.getItem('token') },

                        success: function (res) {
                            if (res.success) {
                                let element = document.getElementById(`${productId}`);
                                element.remove();
                                toastr.success('', res.message, toastr.options = {
                                    ""positionClass"": ""toast-top-right"",
                                    ""fadeIn""");
                WriteLiteral(@": 300,
                                    ""fadeOut"": 100,
                                    ""timeOut"": 3000,
                                    ""extendedTimeOut"": 1000
                                });

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
                        error: function (jqXHR, textStatus, errorThrown) {
                            if (jqXHR.status == 401) {
                                toastr.error('', 'انت لا تملك الصلاحية', toastr.options = {
                                    ""positionC");
                WriteLiteral(@"lass"": ""toast-top-right"",
                                    ""fadeIn"": 300,
                                    ""fadeOut"": 100,
                                    ""timeOut"": 3000,
                                    ""extendedTimeOut"": 1000
                                });

                            }

                        }




                    })






                }




            });
        }
       
        function addQuantity(id,name) {

            $('#productId').val(id);
            $('#productNamee').html(""اضافة كمية جديدة للمنتج "" + name);
            $('#modal-add-quantity').modal('show')
         
         
        }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PlaystationProject.Dtos.Products.GetProductDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
