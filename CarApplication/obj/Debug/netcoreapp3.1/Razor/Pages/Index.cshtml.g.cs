#pragma checksum "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de9494c2acc14e09a7b7db36eb317ae0db58e9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de9494c2acc14e09a7b7db36eb317ae0db58e9a7", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
  
    Layout = Layout;
    ViewData["Title"] = "Машины - КФУ";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"lastAdts\">\r\n    <p class=\"text-center h3\">Последние объявления</p>\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 12 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
              
                int i = 0;
                foreach (var offer in Model.OfferList)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div");
            BeginWriteAttribute("class", " class=\"", 456, "\"", 497, 2);
            WriteAttributeValue("", 464, "carousel-item", 464, 13, true);
#nullable restore
#line 16 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
WriteAttributeValue(" ", 477, i==0?"active":"", 478, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a class=\"main-page-adt-card custom-a\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 563, "\"", 622, 2);
            WriteAttributeValue("", 598, "/offer/view?id=", 598, 15, true);
#nullable restore
#line 18 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
WriteAttributeValue("", 613, offer.Id, 613, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"main-page-adt-card-header\">");
#nullable restore
#line 19 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
                                                              Write(offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"main-page-adt-info\">\r\n                                <div class=\"main-page-adt-info-elem\">");
#nullable restore
#line 21 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
                                                                Write(offer.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"main-page-adt-info-elem\">");
#nullable restore
#line 22 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
                                                                Write(offer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                <div class=\"main-page-adt-info-elem\">");
#nullable restore
#line 23 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
                                                                Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.</div>\r\n                            </div>\r\n                            <div class=\"adt-photos-content flex-wrap\">\r\n                                <img class=\"adt-photos-content-item\"");
            BeginWriteAttribute("src", "\r\n                                     src=\"", 1223, "\"", 1285, 1);
#nullable restore
#line 27 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
WriteAttributeValue("", 1267, offer.MainPicture, 1267, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\"\r\n                                     height=\"200\">\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Index.cshtml"
                    {
                        i++;
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</div>
<div id=""webSiteDescription"">
    <p class=""text-center h3"">Несколько слов об этом сайте</p>
    <div class=""text-label text-center"">На нашем сайте вы можете разместить объявление и продать свой автомобиль.</div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Index>)PageContext?.ViewData;
        public CarApplication.Pages.Index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
