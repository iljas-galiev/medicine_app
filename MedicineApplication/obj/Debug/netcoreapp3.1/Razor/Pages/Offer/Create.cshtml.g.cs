#pragma checksum "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b2659cf0f8159e221b423719db027930630a8d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b2659cf0f8159e221b423719db027930630a8d", @"/Pages/Offer/Create.cshtml")]
    public class Pages_Offer_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
  
    Layout = Layout;

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"create-adt-header text-uppercase\">Создать объявление</p>\r\n<form class=\"create-adt-form\" method=\"POST\"");
            BeginWriteAttribute("action", " action=\"", 196, "\"", 205, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    ");
#nullable restore
#line 9 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
      
        if (Model.Offer.Errors.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-danger\">\r\n                <ul>\r\n");
#nullable restore
#line 15 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
                      
                        foreach (var error in Model.Offer.Errors)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
#nullable restore
#line 18 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
                           Write(error.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
                                       Write(error.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 19 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Offer\Create.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <input type=""text"" class=""create-adt-input-name create-adt-form-item form-control input-options"" name=""name"" placeholder=""Название объявления"">
    <input type=""text"" class=""create-adt-mark create-adt-form-item form-control input-options"" name=""brand"" placeholder=""Марка автомобиля"">
    <input type=""text"" class=""create-adt-model create-adt-form-item form-control input-options"" name=""model"" placeholder=""Модель автомобиля"">
    <input type=""text"" class=""create-adt-mark create-adt-form-item form-control input-options"" name=""price"" placeholder=""Цена"">
    <input id=""adtCreatePhotoInput"" type=""file"" class=""create-adt-input-photos"" name=""photos"" data-multiple-caption=""{count} files selected"" multiple accept="".jpg, .jpeg, .png"">
    <label for=""adtCreatePhotoInput"" class=""create-adt-label-photos input-options"">Добавить фотографии</label>
    <label class=""adt-create-label"" for=""adtCreateDescription"">Опишите объявление</label>
    <textarea id=""adtCreateDescription"" class=""create-adt-description create-adt");
            WriteLiteral(@"-form-item form-control input-options"" name=""description""></textarea>
    <input type=""text"" class=""create-adt-phone create-adt-form-item form-control input-options"" name=""phone"" placeholder=""Телефон пользователя, вставляется автоматически, можно поменять"">
    <input type=""text"" class=""create-adt-email create-adt-form-item form-control input-options "" name=""email"" placeholder=""Почта пользователя, работает также как телефон"">
    <button class=""create-adt-btn custom-btn"">Подать объявление</button>
</form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MedicineApplication.Pages.Offer.Create> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MedicineApplication.Pages.Offer.Create> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MedicineApplication.Pages.Offer.Create>)PageContext?.ViewData;
        public MedicineApplication.Pages.Offer.Create Model => ViewData.Model;
    }
}
#pragma warning restore 1591
