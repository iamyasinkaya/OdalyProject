#pragma checksum "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3b7ab2a513647f441541e306807b367c6acbe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_GetRentBook), @"mvc.1.0.view", @"/Views/Student/GetRentBook.cshtml")]
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
#line 9 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
using OdalysProject.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3b7ab2a513647f441541e306807b367c6acbe3", @"/Views/Student/GetRentBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca516477e76b500cdb9943a3c10c90127cf40cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_GetRentBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RentBook>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
  
    ViewData["Title"] = "Kiralanan Kitaplar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<br />\r\n<div class=\"container-fluid\">\r\n    <br />\r\n    <ol class=\"breadcrumb mb-4\">\r\n        <li class=\"breadcrumb-item\">\r\n            ");
#nullable restore
#line 16 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
       Write(Html.ActionLink("Öğrenci", "Index", "Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </li>\r\n        <li class=\"breadcrumb-item active\">");
#nullable restore
#line 18 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-body\">\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"card mb-4\">\r\n        <div class=\"card-header\">\r\n            <i class=\"fas fa-table mr-1\"></i>\r\n            ");
#nullable restore
#line 28 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
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
#line 36 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 37 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 38 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 39 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n\r\n\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tfoot>\r\n                        <tr>\r\n\r\n                            <th>");
#nullable restore
#line 50 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 51 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.Book.ISBN));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 52 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.RentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 53 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.DeliveryDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n\r\n                        </tr>\r\n                    </tfoot>\r\n                    <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 63 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                               Write(item.Book.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 64 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                               Write(item.Book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td class=\"text-success\"><strong>");
#nullable restore
#line 65 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                                            Write(item.RentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 66 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                  
                                    var date = new DateTime();

                                    if (item.DeliveryDate == date)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-danger\"><strong>Teslim Edilmedi</strong></td>\r\n");
#nullable restore
#line 72 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td class=\"text-danger\"><strong>");
#nullable restore
#line 75 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                                                   Write(item.DeliveryDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 76 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                                    }


                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tr>\r\n");
#nullable restore
#line 82 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Student\GetRentBook.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RentBook>> Html { get; private set; }
    }
}
#pragma warning restore 1591
