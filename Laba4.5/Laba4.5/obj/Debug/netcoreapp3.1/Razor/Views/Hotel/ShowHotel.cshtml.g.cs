#pragma checksum "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4eef0236772ec198d138967a8935116ef3a227c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hotel_ShowHotel), @"mvc.1.0.view", @"/Views/Hotel/ShowHotel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4eef0236772ec198d138967a8935116ef3a227c", @"/Views/Hotel/ShowHotel.cshtml")]
    public class Views_Hotel_ShowHotel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laba4._5.Storage.Entity.Hotel>>
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
#nullable restore
#line 2 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eef0236772ec198d138967a8935116ef3a227c2932", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"wIdth=device-wIdth\" />\r\n    <title>Show Hotels</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4eef0236772ec198d138967a8935116ef3a227c3997", async() => {
                WriteLiteral(@"
    <h1>Отели</h1>
    <table border=""1"" wIdth=""100%"" cellpadding=""5"">
        <tr>
            <th>Название отеля</th>
            <th>Количество этажей в отеле</th>
            <th>Количестов номеров</th>
            <th>Количестов сотрудников</th>
            <th></th>
            <th></th>
            <th></th>
            <th></th>
        </tr>
");
#nullable restore
#line 24 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
          
            foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
                   Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
                   Write(item.floors);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
                   Write(item.KolNum);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
                   Write(item.kolsot);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 868, "\"", 900, 2);
                WriteAttributeValue("", 875, "/Hotel/EditHotel/", 875, 17, true);
#nullable restore
#line 32 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
WriteAttributeValue("", 892, item.Id, 892, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Редактировать</a> </td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 953, "\"", 980, 2);
                WriteAttributeValue("", 960, "/Hotel/Kick/", 960, 12, true);
#nullable restore
#line 33 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
WriteAttributeValue("", 972, item.Id, 972, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Удалить</a></td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1026, "\"", 1065, 2);
                WriteAttributeValue("", 1033, "/Personal/ShowPersonals/", 1033, 24, true);
#nullable restore
#line 34 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
WriteAttributeValue("", 1057, item.Id, 1057, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Персонал</a></td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1112, "\"", 1150, 2);
                WriteAttributeValue("", 1119, "/CHnumber/ShowCHnumber/", 1119, 23, true);
#nullable restore
#line 35 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
WriteAttributeValue("", 1142, item.Id, 1142, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Номера</a></td>\r\n\r\n                </tr>\n");
#nullable restore
#line 38 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </table>\r\n");
#nullable restore
#line 42 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
     using (Html.BeginForm("CreateHotel","Hotel"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\n            <input type=\"submit\" value=\"Добавить новый отель\"/>\n        </div>\n");
#nullable restore
#line 47 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Hotel\ShowHotel.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laba4._5.Storage.Entity.Hotel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
