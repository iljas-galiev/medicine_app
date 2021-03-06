#pragma checksum "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9c32a84b9cbc9a8211e514024ae27c395c3fd3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Offer_Create), @"mvc.1.0.razor-page", @"/Pages/Offer/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9c32a84b9cbc9a8211e514024ae27c395c3fd3c", @"/Pages/Offer/Create.cshtml")]
    public class Pages_Offer_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
  
    Layout = Layout;
    ViewData["Title"] = "Создать объявление";

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"create-adt-header text-uppercase\">Создать объявление</p>\r\n<form class=\"create-adt-form\" method=\"post\" enctype=\"multipart/form-data\">\r\n    ");
#nullable restore
#line 10 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
      
        if (Model.Offer.Errors.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <ul>\r\n");
#nullable restore
#line 16 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
                      
                        foreach (var error in Model.Offer.Errors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 19 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
                           Write(error.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 19 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
                                       Write(error.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 20 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 735, "\"", 755, 1);
#nullable restore
#line 27 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 743, Model.Title, 743, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"create-adt-input-name create-adt-form-item form-control input-options\" name=\"title\" placeholder=\"Название объявления\">\r\n\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 908, "\"", 928, 1);
#nullable restore
#line 29 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 916, Model.Brand, 916, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"create-adt-mark create-adt-form-item form-control input-options\" name=\"brand\" placeholder=\"Марка автомобиля\">\r\n\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1072, "\"", 1092, 1);
#nullable restore
#line 31 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 1080, Model.Model, 1080, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"create-adt-model create-adt-form-item form-control input-options\" name=\"model\" placeholder=\"Модель автомобиля\">\r\n\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1238, "\"", 1258, 1);
#nullable restore
#line 33 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 1246, Model.Price, 1246, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" class=""create-adt-mark create-adt-form-item form-control input-options"" name=""price"" placeholder=""Цена"">

    <input multiple id=""adtCreatePhotoInput"" type=""file"" class=""create-adt-input-photos"" name=""uploads"">
    <label for=""adtCreatePhotoInput"" class=""create-adt-label-photos input-options"">Добавить фотографии</label>

    <label class=""adt-create-label"" for=""adtCreateDescription"">Описание</label>
    <textarea id=""adtCreateDescription"" class=""create-adt-description create-adt-form-item form-control input-options"" name=""description"">
        ");
#nullable restore
#line 40 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
   Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </textarea>\r\n\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 1878, "\"", 1898, 1);
#nullable restore
#line 43 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 1886, Model.Phone, 1886, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"create-adt-phone create-adt-form-item form-control input-options\" name=\"phone\" placeholder=\"Телефон\">\r\n\r\n    <input");
            BeginWriteAttribute("value", " value=\"", 2034, "\"", 2054, 1);
#nullable restore
#line 45 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Offer\Create.cshtml"
WriteAttributeValue("", 2042, Model.Email, 2042, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"text\" class=\"create-adt-email create-adt-form-item form-control input-options \" name=\"email\" placeholder=\"E-mail\">\r\n\r\n    <button class=\"create-adt-btn custom-btn\">Подать объявление</button>\r\n</form>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Offer.Create> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.Create> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Offer.Create>)PageContext?.ViewData;
        public CarApplication.Pages.Offer.Create Model => ViewData.Model;
    }
}
#pragma warning restore 1591
