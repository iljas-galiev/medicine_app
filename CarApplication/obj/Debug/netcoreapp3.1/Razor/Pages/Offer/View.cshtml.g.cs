#pragma checksum "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9895af28c57cedf6f2bba68939e4843b49d8ae81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Offer_View), @"mvc.1.0.razor-page", @"/Pages/Offer/View.cshtml")]
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
#line 2 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
using CarApplication.Model.Offer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9895af28c57cedf6f2bba68939e4843b49d8ae81", @"/Pages/Offer/View.cshtml")]
    public class Pages_Offer_View : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
  
    Layout = Layout;
    ViewData["Title"] = @Model.Offer.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row line-bottom\">\r\n    <div class=\"col text-center adt-name text-uppercase h1\">\r\n        ");
#nullable restore
#line 12 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
   Write(Model.Offer.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row adt-info\">\r\n    <a class=\"adt-info-lbl col text-center\" href=\"#\">\r\n        ");
#nullable restore
#line 17 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
   Write(Model.Offer.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    <a class=\"adt-info-lbl col text-center\" href=\"#\">\r\n        ");
#nullable restore
#line 19 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
   Write(Model.Offer.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    <a class=\"adt-info-lbl col text-center\" href=\"#\">\r\n        ");
#nullable restore
#line 21 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
   Write(Model.Offer.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" руб.\r\n    </a>\r\n</div>\r\n<div class=\"row line-bottom\">\r\n    <div class=\"adt-photos\">\r\n        <div class=\"adt-photos-content flex-wrap\">\r\n");
#nullable restore
#line 27 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
             if (@Model.Offer.MainPicture != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"adt-photos-content-item\"");
            BeginWriteAttribute("src", " src=\"", 873, "\"", 903, 1);
#nullable restore
#line 29 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 879, Model.Offer.MainPicture, 879, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"200\">\r\n");
#nullable restore
#line 30 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
              
                if (Model.OfferImages != null)
                {
                    foreach (var image in Model.OfferImages)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"adt-photos-content-item\"");
            BeginWriteAttribute("src", " src=\"", 1175, "\"", 1193, 1);
#nullable restore
#line 36 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 1181, image.Image, 1181, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"200\">\r\n");
#nullable restore
#line 37 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"adt-description\">\r\n        ");
#nullable restore
#line 44 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
   Write(Model.Offer.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div id=\"ownerRow\" class=\"row\">\r\n    <a class=\"col-md-3 adt-owner-avatar custom-a\"");
            BeginWriteAttribute("href", " href=\"", 1480, "\"", 1510, 2);
            WriteAttributeValue("", 1487, "/user?id=", 1487, 9, true);
#nullable restore
#line 48 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 1496, Model.User.Id, 1496, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <img class=\"adt-owner-avatar\"");
            BeginWriteAttribute("src", " src=\"", 1551, "\"", 1574, 1);
#nullable restore
#line 49 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 1557, Model.User.Image, 1557, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\">\r\n        <div id=\"ownerLogin\" class=\"owner-login custom-a\">\r\n            ");
#nullable restore
#line 51 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
       Write(Model.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </a>\r\n    <div class=\"col-md-9 adt-owner-info\">\r\n        <div class=\"adt-owner-info-private\">\r\n            <a id=\"ownerPhone\" class=\"owner-info-elem custom-a custom-btn\"");
            BeginWriteAttribute("href", " href=\"", 1882, "\"", 1910, 2);
            WriteAttributeValue("", 1889, "tel:", 1889, 4, true);
#nullable restore
#line 56 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 1893, Model.User.Phone, 1893, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Позвонить\r\n            </a>\r\n            <a id=\"ownerEmail\" class=\"owner-info-elem custom-a custom-btn\"");
            BeginWriteAttribute("href", " href=\"", 2033, "\"", 2064, 2);
            WriteAttributeValue("", 2040, "mailto:", 2040, 7, true);
#nullable restore
#line 59 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 2047, Model.User.Email, 2047, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                Email\r\n            </a>\r\n            <a id=\"messageOwner\"");
            BeginWriteAttribute("href", " href=\"", 2141, "\"", 2175, 2);
            WriteAttributeValue("", 2148, "/chat?offer=", 2148, 12, true);
#nullable restore
#line 62 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 2160, Model.Offer.Id, 2160, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"owner-info-elem custom-a custom-btn\">\r\n                Чат\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"adt-footer-btns\">\r\n");
#nullable restore
#line 69 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
     if (Model.Offer.UserId == Convert.ToInt32(HttpContext.Session.GetString("user")))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button class=\"col adt-header-btn delete-adt-btn\" data-id=\"");
#nullable restore
#line 71 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
                                                              Write(Model.Offer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n            Удалить\r\n        </button>\r\n");
#nullable restore
#line 74 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
         if (Model.Offer.Status >= OfferEntity.New)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"col adt-header-btn block-adt-btn\" data-id=\"");
#nullable restore
#line 76 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
                                                                 Write(Model.Offer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-status=\"0\">\r\n                Отключить\r\n            </button>\r\n");
#nullable restore
#line 79 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
         if (Model.Offer.Status == OfferEntity.Block)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"col adt-header-btn block-adt-btn\" data-id=\"");
#nullable restore
#line 83 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
                                                                 Write(Model.Offer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-status=\"1\">\r\n                Включить\r\n            </button>\r\n");
#nullable restore
#line 86 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"col custom-a adt-header-btn change-adt-btn\"");
            BeginWriteAttribute("href", " href=\"", 3074, "\"", 3111, 2);
            WriteAttributeValue("", 3081, "/offer/edit?id=", 3081, 15, true);
#nullable restore
#line 87 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
WriteAttributeValue("", 3096, Model.Offer.Id, 3096, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            Изменить\r\n        </a>\r\n        <div style=\"width: 100%\">\r\n");
#nullable restore
#line 91 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
             if (Model.Offer.Status == OfferEntity.New)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-primary\">На модерации</span>\r\n");
#nullable restore
#line 94 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 95 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
             if (Model.Offer.Status == OfferEntity.Active)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-success\">Активно</span>\r\n");
#nullable restore
#line 98 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
             if (Model.Offer.Status == OfferEntity.Block)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-warning\">Отключено</span>\r\n");
#nullable restore
#line 102 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
             if (Model.Offer.Status == OfferEntity.BlockAdmin)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"text-danger\">Заблокировано администрацией</span>\r\n");
#nullable restore
#line 106 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 108 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\View.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Offer.View> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.View> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.View>)PageContext?.ViewData;
        public CarApplication.Pages.Offer.View Model => ViewData.Model;
    }
}
#pragma warning restore 1591
