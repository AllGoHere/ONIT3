#pragma checksum "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fa029355d5f74b9a12d1140bf4fd2df520909a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_ShowAllPersonals), @"mvc.1.0.view", @"/Views/Personal/ShowAllPersonals.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fa029355d5f74b9a12d1140bf4fd2df520909a8", @"/Views/Personal/ShowAllPersonals.cshtml")]
    public class Views_Personal_ShowAllPersonals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laba4._5.Managers.Perenos>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa029355d5f74b9a12d1140bf4fd2df520909a83010", async() => {
                WriteLiteral("\r\n    <\r\n    <meta name=\"viewport\" content=\"wIdth=device-wIdth\" />\r\n    <title>ShowCHnumber</title> />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fa029355d5f74b9a12d1140bf4fd2df520909a84088", async() => {
                WriteLiteral("\r\n    <h1>Персонал</h1>\r\n    <table border=\"1\" wIdth=\"100%\" cellpadding=\"5\">\r\n        <tr>\r\n            <th>Имя</th>\r\n            <th>Фамилия</th>\r\n            <th>Должность</th>\r\n            <th></th>\r\n            <th></th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
          
            foreach (var item in Laba4._5.Managers.Perenos.personals)
            {
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 29 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
                       Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
                       Write(item.lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
                       Write(item.dolzhnost);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 772, "\"", 810, 2);
                WriteAttributeValue("", 779, "/Personal/EditPersonal/", 779, 23, true);
#nullable restore
#line 32 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
WriteAttributeValue("", 802, item.Id, 802, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \"Редактировать\"</a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 869, "\"", 899, 2);
                WriteAttributeValue("", 876, "/Personal/kick/", 876, 15, true);
#nullable restore
#line 33 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
WriteAttributeValue("", 891, item.Id, 891, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\"Удалить\" </a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
                
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
#nullable restore
#line 39 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
     using (Html.BeginForm("CreatePersonal", "Personal"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <input type=\"submit\" value=\"Добавить персонал\" />\r\n\r\n        </div>\r\n");
#nullable restore
#line 45 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Personal\ShowAllPersonals.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        <a href=\"/Personal/ShowAllPersonals\">Показать весь персонал</a>\r\n    </div>\r\n    <div>\r\n        <a href=\"/Hotel/ShowHotel\">Вернутся к списку Отелей</a>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laba4._5.Managers.Perenos> Html { get; private set; }
    }
}
#pragma warning restore 1591
