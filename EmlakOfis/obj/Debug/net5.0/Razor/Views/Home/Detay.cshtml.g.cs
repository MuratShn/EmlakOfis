#pragma checksum "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3908399c212297b6ce98f50bb2c3b0f246bb01b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detay), @"mvc.1.0.view", @"/Views/Home/Detay.cshtml")]
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
#line 1 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\_ViewImports.cshtml"
using EmlakOfis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\_ViewImports.cshtml"
using EmlakOfis.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3908399c212297b6ce98f50bb2c3b0f246bb01b", @"/Views/Home/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22db1b99f125d12477a00d2ec653c517c8e092aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EvDetayModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!-- Portfolio Item Heading -->\r\n<h2 class=\"my-4\">\r\n    <small>");
#nullable restore
#line 5 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
      Write(Model[0].Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small>\r\n</h2>\r\n\r\n<!-- Portfolio Item Row -->\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-8\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3908399c212297b6ce98f50bb2c3b0f246bb01b4521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"col-md-4\">\r\n        <h3 class=\"my-3\">İlan Özeliikleri</h3>\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item \">\r\n                <strong>İlan Tarih</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 20 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Tarih.ToString("d MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Emlak Tipi</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 24 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].EvDurum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>m² (Net)</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 28 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Metrekare);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Oda Sayısı</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 32 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].OdaSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 32 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                                     Write(Model[0].SalonSayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Bina Yaşı</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 36 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Yas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Kat Sayısı</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 40 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Katsayi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Şehir</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 44 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Sehir);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n\r\n\r\n        </ul>\r\n\r\n        <h3 class=\"my-3\">İlan Sahibi</h3>\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item \">\r\n                <strong>Adı</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 54 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Soyad</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 58 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Soyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n            <li class=\"list-group-item \">\r\n                <strong>Telefon</strong>&nbsp;&nbsp;&nbsp;\r\n                <span>");
#nullable restore
#line 62 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                 Write(Model[0].Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </li>\r\n        </ul>\r\n\r\n    </div>\r\n\r\n</div>\r\n<!-- /.row -->\r\n<!-- Related Projects Row -->\r\n<br />\r\n<hr />\r\n<h3 class=\"my-4 text-center\">Açıklama</h3>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <p class=\"text-center display-4\">");
#nullable restore
#line 77 "C:\Users\murat\source\repos\EmlakOfis\EmlakOfis\Views\Home\Detay.cshtml"
                                Write(Model[0].Acıklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n</div>\r\n<!-- /.row -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EvDetayModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
