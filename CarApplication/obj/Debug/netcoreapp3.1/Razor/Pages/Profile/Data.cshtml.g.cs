#pragma checksum "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b51b3356b72478c853db406b0cc3b93037985c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Profile_Data), @"mvc.1.0.razor-page", @"/Pages/Profile/Data.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b51b3356b72478c853db406b0cc3b93037985c98", @"/Pages/Profile/Data.cshtml")]
    public class Pages_Profile_Data : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
  
    Layout = Layout;
    ViewData["Title"] = "Персональные данные";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\r\n    ");
#nullable restore
#line 11 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
Write(Html.Partial("_Nav"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"col-md-8\">\r\n        <div class=\"right-content\">\r\n            <div class=\"right-content-header\">\r\n                Персональные данные\r\n            </div>\r\n            <ul class=\"right-content-list\">\r\n");
#nullable restore
#line 18 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                  
                    if (Model.Profile.Errors.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            <ul>\r\n");
#nullable restore
#line 23 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                                  
                                    foreach (var error in Model.Profile.Errors)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>");
#nullable restore
#line 26 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                                       Write(error.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 26 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                                                   Write(error.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                                    }
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n");
#nullable restore
#line 31 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                    }
                    if (Model.Saved > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-success\">\r\n                            Сохранено\r\n                        </div>\r\n");
#nullable restore
#line 37 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"right-content-list-item\">\r\n                    <div class=\"container-fluent\">\r\n                        <form id=\"newNameForm\" class=\"form-group\" method=\"POST\"");
            BeginWriteAttribute("action", " action=\"", 1402, "\"", 1411, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 42 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <label for=\"newPhoneInput\">Поменять имя</label>\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 1580, "\"", 1607, 1);
#nullable restore
#line 44 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
WriteAttributeValue("", 1588, Model.Profile.Name, 1588, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" class=""form-control input-options"" id=""newNameInput"" name=""name"">
                            <small id=""newNameHelp"" class=""form-text second-text""></small>
                            <button type=""button"" class=""btn personal-area-btn custom-btn"" onclick=""sendNewNameForm()"" aria-describedby=""refreshPhoneBtnHelp"">Сохранить</button>
                        </form>
                    </div>
                </li>
                <li class=""right-content-list-item"">
                    <div class=""container-fluent"">
                        <form id=""newPhoneForm"" class=""form-group"" method=""POST""");
            BeginWriteAttribute("action", " action=\"", 2228, "\"", 2237, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 53 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            <label for=\"newPhoneInput\">Поменять номер телефона</label>\r\n                            <input");
            BeginWriteAttribute("value", " value=\"", 2417, "\"", 2445, 1);
#nullable restore
#line 55 "C:\Users\iljas\YandexDisk\Work\Edu\C#\medicine_app\CarApplication\Pages\Profile\Data.cshtml"
WriteAttributeValue("", 2425, Model.Profile.Phone, 2425, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""text"" class=""form-control input-options"" id=""newPhoneInput"" aria-describedby=""newPhoneHelp"" name=""phone"">
                            <small id=""newPhoneHelp"" class=""form-text second-text""></small>
                            <button type=""button"" class=""btn personal-area-btn custom-btn"" onclick=""sendNewPhoneForm()"" aria-describedby=""refreshPhoneBtnHelp"">Сохранить</button>
                            <small id=""refreshPhoneBtnHelp"" class=""form-text second-text""></small>
                        </form>
                    </div>
                </li>
            </ul>
        </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarApplication.Pages.Profile.Data> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Profile.Data> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CarApplication.Pages.Profile.Data>)PageContext?.ViewData;
        public CarApplication.Pages.Profile.Data Model => ViewData.Model;
    }
}
#pragma warning restore 1591
