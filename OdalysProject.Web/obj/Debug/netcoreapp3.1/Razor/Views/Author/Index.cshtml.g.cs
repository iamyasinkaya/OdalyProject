#pragma checksum "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82cb7077bec8b4a18be2d99e4190c0d5ef3174fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Index), @"mvc.1.0.view", @"/Views/Author/Index.cshtml")]
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
#line 1 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\_ViewImports.cshtml"
using OdalysProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
using OdalysProject.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82cb7077bec8b4a18be2d99e4190c0d5ef3174fc", @"/Views/Author/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca516477e76b500cdb9943a3c10c90127cf40cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Author>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadExcelDocument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
  
    ViewData["Title"] = "Yazar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n<div class=\"container-fluid\">\r\n    <ol class=\"breadcrumb mb-4\">\r\n        <li class=\"breadcrumb-item\">\r\n\r\n            ");
#nullable restore
#line 15 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
       Write(Html.ActionLink("Anasayfa", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 17 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82cb7077bec8b4a18be2d99e4190c0d5ef3174fc4735", async() => {
                WriteLiteral("\r\n                <input class=\"btn btn-outline-success\" type=\"submit\" value=\"Excel\'e Aktar\" />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-header\">\r\n            <i class=\"fas fa-table mr-1\"></i>\r\n            ");
#nullable restore
#line 29 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered text-center"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>");
#nullable restore
#line 36 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.AuthorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 37 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 38 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 39 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nickname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 40 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 41 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 42 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>Aksiyonlar</th>\r\n\r\n\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tfoot>\r\n                        <tr>\r\n                            <th>");
#nullable restore
#line 51 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.AuthorId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 52 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 53 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 54 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Nickname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 55 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 56 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.DateOfDeath));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 57 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>Aksiyonlar</th>\r\n\r\n\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 64 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 67 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.AuthorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 68 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.Firstname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 69 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.Lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 70 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.Nickname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 71 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 72 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.DateOfDeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 73 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n\r\n                                    ");
#nullable restore
#line 76 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(Html.ActionLink("Sil", "Delete", "Author", new { Id = item.AuthorId }, new { @class = "btn btn-outline-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    ");
#nullable restore
#line 77 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                               Write(Html.ActionLink("Güncelle", "Update", "Author", new { Id = item.AuthorId }, new { @class = "btn btn-outline-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 83 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Author\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Author>> Html { get; private set; }
    }
}
#pragma warning restore 1591
