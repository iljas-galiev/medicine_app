#pragma checksum "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4862fb09630f304c61ed175247d5b2e8315a1919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared__Layout), @"mvc.1.0.view", @"/Pages/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4862fb09630f304c61ed175247d5b2e8315a1919", @"/Pages/Shared/_Layout.cshtml")]
    public class Pages_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4862fb09630f304c61ed175247d5b2e8315a19192746", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css""
          integrity=""sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""/css/main.css"">
    <link rel=""shortcut icon"" href=""https://gu-st.ru/content/situation_icons/car_sell.svg"">
    <title>Машины</title>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4862fb09630f304c61ed175247d5b2e8315a19194232", async() => {
                WriteLiteral(@"
<div class=""container-fluent bg-header fixed-top"">
    <div id=""header"" class=""container"">
        <nav class=""navbar navbar-expand-lg navbar-dark bg-header"">
            <a class=""navbar-brand header-link-elem"" href=""#"">Главная</a>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent""
                    aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>

            <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                <ul class=""navbar-nav mr-auto"">
                    <li>
                        <a class=""navbar-brand header-link-elem"" href=""#"">Объявления</a>
                    </li>
                    <li>
                        <a class=""navbar-brand header-link-elem"" href=""#"">Создать объявление</a>
                    </li>
                    <li>
                   ");
                WriteLiteral("     <a class=\"navbar-brand header-link-elem\" href=\"#\">Чат</a>\r\n                    </li>\r\n                </ul>\r\n");
#nullable restore
#line 35 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml"
                  
                    if (!Context.Session.Keys.Contains("user"))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""dropdown"">
                            <button class=""btn dropdown-toggle header-btn-elem"" type=""button"" id=""dropdownEnterButton""
                                    data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Войти
                            </button>

                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownEnterButton"">
                                <form action=""/auth/login"" method=""post"" class=""form"">
                                    ");
#nullable restore
#line 46 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml"
                               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <div class=""form-group"">
                                        <label for=""authLogin"">Введите ваши логин и пароль</label>
                                        <input type=""text"" name=""email"" class=""form-control"" id=""authLogin"" aria-describedby=""authLoginHelp"" placeholder=""Логин"">
                                        <small id=""authLoginHelp"" class=""form-text text-muted""></small>
                                    </div>
                                    <div class=""form-group"">
                                        <label for=""authPassword"">Пароль</label>
                                        <input type=""password"" name=""password"" class=""form-control"" id=""authPassword"" placeholder=""Пароль"">
                                    </div>
                                    <div class=""form-check"">
                                        <input type=""checkbox"" name=""remember"" class=""form-check-input"" id=""authRememberMe"">
                               ");
                WriteLiteral(@"         <label class=""form-check-label"" for=""authRememberMe"">Запомнить меня</label>
                                    </div>
                                    <button type=""submit"" class=""btn header-dropdown-btn"">Войти</button>
                                </form>

                            </div>
                        </div>
");
#nullable restore
#line 65 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""dropdown"">
                            <button class=""btn dropdown-toggle header-btn-elem"" type=""button"" id=""dropdownEnterButton""
                                    data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                Логин
                            </button>
                            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""dropdownEnterButton"">
                                <a class=""custom-a dropdown-item"" href=""#"">Личный кабинет</a>
                                <a class=""custom-a dropdown-item"" href=""#"">Мои объявления</a>
                                <a class=""custom-a dropdown-item"" href=""#"">Избранное</a>
                                <a class=""custom-a dropdown-item"" href=""#"">Админка</a>
                            </div>
                        </div>
");
#nullable restore
#line 80 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n        </nav>\r\n    </div>\r\n</div>\r\n<div class=\"container custom-container-shadow\">\r\n    ");
#nullable restore
#line 87 "C:\Users\Admin\YandexDisk\Work\Edu\C#\medicine_app\MedicineApplication\Pages\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script src=""/js/jquery.js""></script>
<script src=""/js/bootstrap.js""></script>
<script src=""https://rawgit.com/radu-matei/websocket-manager/master/src/WebSocketManager.Client.TS/dist/WebSocketManager.js""></script>
<script src=""/js/site.js""></script>
<script src=""/js/main.js""></script>
</html>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
