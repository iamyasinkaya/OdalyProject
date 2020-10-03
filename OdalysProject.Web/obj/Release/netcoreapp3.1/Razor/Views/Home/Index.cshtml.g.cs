#pragma checksum "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "705a259ccc032a498ca109d5b5000cbe5ae54055"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\_ViewImports.cshtml"
using OdalysProject.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"705a259ccc032a498ca109d5b5000cbe5ae54055", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca516477e76b500cdb9943a3c10c90127cf40cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OdalysProject.Web.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"

<br />

    <main>
        <div class=""container-fluid"">
            <ol class=""breadcrumb mb-4"">
                <li class=""breadcrumb-item active"">Anasayfa</li>
            </ol>
            <div class=""row"">
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-primary text-white mb-4"">
                        <div class=""card-body"">Kitaplar</div>
                        <div class=""card-footer d-flex align-items-center justify-content-between"">
                            ");
#nullable restore
#line 20 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Detayları Gör", "Index", "Book",null,new {@class= "small text-white stretched-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            <div class=""small text-white""><svg class=""svg-inline--fa fa-angle-right fa-w-8"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""angle-right"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 256 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M224.3 273l-136 136c-9.4 9.4-24.6 9.4-33.9 0l-22.6-22.6c-9.4-9.4-9.4-24.6 0-33.9l96.4-96.4-96.4-96.4c-9.4-9.4-9.4-24.6 0-33.9L54.3 103c9.4-9.4 24.6-9.4 33.9 0l136 136c9.5 9.4 9.5 24.6.1 34z""></path></svg><!-- <i class=""fas fa-angle-right""></i> --></div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-warning text-white mb-4"">
                        <div class=""card-body"">Yazarlar</div>
                        <div class=""card-footer d-flex align-items-center justify-content-between"">
                            ");
#nullable restore
#line 30 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Detayları Gör", "Index", "Author", null, new { @class = "small text-white stretched-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            <div class=""small text-white""><svg class=""svg-inline--fa fa-angle-right fa-w-8"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""angle-right"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 256 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M224.3 273l-136 136c-9.4 9.4-24.6 9.4-33.9 0l-22.6-22.6c-9.4-9.4-9.4-24.6 0-33.9l96.4-96.4-96.4-96.4c-9.4-9.4-9.4-24.6 0-33.9L54.3 103c9.4-9.4 24.6-9.4 33.9 0l136 136c9.5 9.4 9.5 24.6.1 34z""></path></svg><!-- <i class=""fas fa-angle-right""></i> --></div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-success text-white mb-4"">
                        <div class=""card-body"">Öğrenciler</div>
                        <div class=""card-footer d-flex align-items-center justify-content-between"">
                            ");
#nullable restore
#line 40 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Detayları Gör", "Index", "Student", null, new { @class = "small text-white stretched-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""small text-white""><svg class=""svg-inline--fa fa-angle-right fa-w-8"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""angle-right"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 256 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M224.3 273l-136 136c-9.4 9.4-24.6 9.4-33.9 0l-22.6-22.6c-9.4-9.4-9.4-24.6 0-33.9l96.4-96.4-96.4-96.4c-9.4-9.4-9.4-24.6 0-33.9L54.3 103c9.4-9.4 24.6-9.4 33.9 0l136 136c9.5 9.4 9.5 24.6.1 34z""></path></svg><!-- <i class=""fas fa-angle-right""></i> --></div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-md-6"">
                    <div class=""card bg-danger text-white mb-4"">
                        <div class=""card-body"">Kiralık Kitaplar</div>
                        <div class=""card-footer d-flex align-items-center justify-content-between"">
                            ");
#nullable restore
#line 49 "C:\Users\iamys\source\repos\OdalysProject\OdalysProject.Web\Views\Home\Index.cshtml"
                       Write(Html.ActionLink("Detayları Gör", "Index", "RentBook", null, new { @class = "small text-white stretched-link" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            <div class=""small text-white""><svg class=""svg-inline--fa fa-angle-right fa-w-8"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""angle-right"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 256 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M224.3 273l-136 136c-9.4 9.4-24.6 9.4-33.9 0l-22.6-22.6c-9.4-9.4-9.4-24.6 0-33.9l96.4-96.4-96.4-96.4c-9.4-9.4-9.4-24.6 0-33.9L54.3 103c9.4-9.4 24.6-9.4 33.9 0l136 136c9.5 9.4 9.5 24.6.1 34z""></path></svg><!-- <i class=""fas fa-angle-right""></i> --></div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-xl-6"">
                    <div class=""card mb-4"">
                        <div class=""card-header"">
                            <svg class=""svg-inline--fa fa-chart-area fa-w-16 mr-1"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""chart-area"" role=""img"" xmlns=""http://www.w3.or");
            WriteLiteral(@"g/2000/svg"" viewBox=""0 0 512 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M500 384c6.6 0 12 5.4 12 12v40c0 6.6-5.4 12-12 12H12c-6.6 0-12-5.4-12-12V76c0-6.6 5.4-12 12-12h40c6.6 0 12 5.4 12 12v308h436zM372.7 159.5L288 216l-85.3-113.7c-5.1-6.8-15.5-6.3-19.9 1L96 248v104h384l-89.9-187.8c-3.2-6.5-11.4-8.7-17.4-4.7z""></path></svg><!-- <i class=""fas fa-chart-area mr-1""></i> -->
                            Kitap Kiralama Grafiği
                        </div>
                        <div class=""card-body""><div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 5544, "\"", 5552, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 5611, "\"", 5619, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div><canvas id=""myAreaChart"" width=""701"" height=""280"" style=""display: block; width: 701px; height: 280px;"" class=""chartjs-render-monitor""></canvas></div>
                    </div>
                </div>
                <div class=""col-xl-6"">
                    <div class=""card mb-4"">
                        <div class=""card-header"">
                            <svg class=""svg-inline--fa fa-chart-bar fa-w-16 mr-1"" aria-hidden=""true"" focusable=""false"" data-prefix=""fas"" data-icon=""chart-bar"" role=""img"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 512 512"" data-fa-i2svg=""""><path fill=""currentColor"" d=""M332.8 320h38.4c6.4 0 12.8-6.4 12.8-12.8V172.8c0-6.4-6.4-12.8-12.8-12.8h-38.4c-6.4 0-12.8 6.4-12.8 12.8v134.4c0 6.4 6.4 12.8 12.8 12.8zm96 0h38.4c6.4 0 12.8-6.4 12.8-12.8V76.8c0-6.4-6.4-12.8-12.8-12.8h-38.4c-6.4 0-12.8 6.4-12.8 12.8v230.4c0 6.4 6.4 12.8 12.8 12.8zm-288 0h38.4c6.4 0 12.8-6.4 12.8-12.8v-70.4c0-6.4-6.4-12.8-12.8-12.8h-38.4c-6.4 0-12.8 6.4-12.8 12.8v70.4c0 6.4 6.4 12.8 12.8 12.");
            WriteLiteral(@"8zm96 0h38.4c6.4 0 12.8-6.4 12.8-12.8V108.8c0-6.4-6.4-12.8-12.8-12.8h-38.4c-6.4 0-12.8 6.4-12.8 12.8v198.4c0 6.4 6.4 12.8 12.8 12.8zM496 384H64V80c0-8.84-7.16-16-16-16H16C7.16 64 0 71.16 0 80v336c0 17.67 14.33 32 32 32h464c8.84 0 16-7.16 16-16v-32c0-8.84-7.16-16-16-16z""></path></svg><!-- <i class=""fas fa-chart-bar mr-1""></i> -->
                            Öğrenci Kayıt Grafiği
                        </div>
                        <div class=""card-body""><div class=""chartjs-size-monitor""><div class=""chartjs-size-monitor-expand""><div");
            BeginWriteAttribute("class", " class=\"", 7185, "\"", 7193, 0);
            EndWriteAttribute();
            WriteLiteral("></div></div><div class=\"chartjs-size-monitor-shrink\"><div");
            BeginWriteAttribute("class", " class=\"", 7252, "\"", 7260, 0);
            EndWriteAttribute();
            WriteLiteral(@"></div></div></div><canvas id=""myBarChart"" width=""701"" height=""280"" class=""chartjs-render-monitor"" style=""display: block; width: 701px; height: 280px;""></canvas></div>
                    </div>
                </div>
            </div>
            
        </div>
    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OdalysProject.Web.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
