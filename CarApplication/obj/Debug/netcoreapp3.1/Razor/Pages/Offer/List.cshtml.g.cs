#pragma checksum "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a726658bcf81812a0b96c419b5292b8118e8b465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Offer_List), @"mvc.1.0.razor-page", @"/Pages/Offer/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a726658bcf81812a0b96c419b5292b8118e8b465", @"/Pages/Offer/List.cshtml")]
    public class Pages_Offer_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml"
  
    Layout = Layout;
    ViewData["Title"] = "Объявления";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row max-height-inherit\">\r\n    <div class=\"col-md-3 right-line max-height-inherit\">\r\n        <div id=\"filtersHeader\" class=\"text-center\">Фильтры</div>\r\n        <form class=\"search-filters filter-form\" method=\"get\"");
            BeginWriteAttribute("action", " action=\"", 345, "\"", 354, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <input");
            BeginWriteAttribute("value", " value=\"", 376, "\"", 396, 1);
#nullable restore
#line 14 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml"
WriteAttributeValue("", 384, Model.Brand, 384, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"brand-filter search-filters-item form-control input-options\" placeholder=\"Марка автомобиля\" name=\"brand\">\r\n            <input");
            BeginWriteAttribute("value", " value=\"", 542, "\"", 562, 1);
#nullable restore
#line 15 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml"
WriteAttributeValue("", 550, Model.Model, 550, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"model-filter search-filters-item form-control input-options\" placeholder=\"Модель автомобиля\" name=\"model\">\r\n            <input");
            BeginWriteAttribute("value", " value=\"", 709, "\"", 729, 1);
#nullable restore
#line 16 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml"
WriteAttributeValue("", 717, Model.Price, 717, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" class=""price-filter search-filters-item form-control input-options"" placeholder=""Максимальная цена"" name=""price"">
            <button class=""search-btn-filters"">
                Применить фильтры
            </button>
        </form>
    </div>
    <div class=""col-md-9 search-content max-height-inherit"">
        <form class=""search-area row filter-form"" method=""get""");
            BeginWriteAttribute("action", " action=\"", 1118, "\"", 1127, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <input");
            BeginWriteAttribute("value", " value=\"", 1149, "\"", 1170, 1);
#nullable restore
#line 24 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\List.cshtml"
WriteAttributeValue("", 1157, Model.Search, 1157, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""search-area-input form-control col-md-9 input-options"" type=""text"" placeholder=""Найти объявление по названию"" name=""search"">
            <button class=""search-btn col"">Найти</button>
        </form>
        <div class=""content-box""></div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Offer.List> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.List> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.List>)PageContext?.ViewData;
        public CarApplication.Pages.Offer.List Model => ViewData.Model;
    }
}
#pragma warning restore 1591
