#pragma checksum "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "473cf2cccec4d82be4691af7f98bc70de909b0ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Offer_Ajax), @"mvc.1.0.razor-page", @"/Pages/Offer/Ajax.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"473cf2cccec4d82be4691af7f98bc70de909b0ac", @"/Pages/Offer/Ajax.cshtml")]
    public class Pages_Offer_Ajax : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<ul class=\"horizontal-padding-none border-none adt-ul\">\r\n");
#nullable restore
#line 10 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
      
        foreach (var offer in Model.Offers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"adt-li\">\r\n                <a class=\"custom-a adt-li-contents\"");
            BeginWriteAttribute("href", " href=\"", 285, "\"", 316, 2);
            WriteAttributeValue("", 292, "/offer/view?id=", 292, 15, true);
#nullable restore
#line 14 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
WriteAttributeValue("", 307, offer.Id, 307, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"adt-li-name\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
                   Write(offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"adt-li-info\">\r\n                        <div class=\"adt-li-info-item\">\r\n                            ");
#nullable restore
#line 20 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
                       Write(offer.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"adt-li-info-item\">\r\n                            ");
#nullable restore
#line 23 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
                       Write(offer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"adt-li-info-item\">\r\n                            ");
#nullable restore
#line 26 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
                       Write(offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.\r\n                        </div>\r\n                    </div>\r\n                </a>\r\n            </li>\r\n");
#nullable restore
#line 31 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Ajax.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Offer.Ajax> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.Ajax> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.Ajax>)PageContext?.ViewData;
        public CarApplication.Pages.Offer.Ajax Model => ViewData.Model;
    }
}
#pragma warning restore 1591