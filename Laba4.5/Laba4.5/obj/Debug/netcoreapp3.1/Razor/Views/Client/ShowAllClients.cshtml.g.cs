#pragma checksum "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbed4dc255ea21d4b7b831e6391daa1021ee4a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_ShowAllClients), @"mvc.1.0.view", @"/Views/Client/ShowAllClients.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccbed4dc255ea21d4b7b831e6391daa1021ee4a6", @"/Views/Client/ShowAllClients.cshtml")]
    public class Views_Client_ShowAllClients : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Laba4._5.Storage.Entity.Client>>
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
#line 2 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccbed4dc255ea21d4b7b831e6391daa1021ee4a62969", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"wIdth=device-wIdth\" />\r\n    <title>ShowCHnumber</title> />\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ccbed4dc255ea21d4b7b831e6391daa1021ee4a64038", async() => {
                WriteLiteral("\r\n    <h1>???????????????????????????? ????????????</h1>\r\n");
#nullable restore
#line 13 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
     using (Html.BeginForm("Answer", "Client"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <lablel>?????????????? ?????????????? ?????? ????????????</lablel>\r\n        <input type=\"text\" size=\"50\" name=\"InputStr\" /><br /><br />\r\n        <input type=\"submit\" value=\"????????????  ??????????????????\" />\r\n");
#nullable restore
#line 18 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <table border=""1"" wIdth=""100%"" cellpadding=""5"">
        <tr>
            <th>??????</th>
            <th>??????????????</th>
            <th>???????????????????? ??????????</th>
            <th>?? ?????????? ????????????</th>
            <th></th>
            <th></th>

        </tr>
");
#nullable restore
#line 29 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
          
            foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
                   Write(item.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
                   Write(item.lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
                   Write(item.nights);

#line default
#line hidden
#nullable disable
                WriteLiteral(".</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
                   Write(item.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1055, "\"", 1089, 2);
                WriteAttributeValue("", 1062, "/Client/EditClient/", 1062, 19, true);
#nullable restore
#line 37 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
WriteAttributeValue("", 1081, item.Id, 1081, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \"??????????????????????????\"</a></td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1144, "\"", 1172, 2);
                WriteAttributeValue("", 1151, "/Client/Kick/", 1151, 13, true);
#nullable restore
#line 38 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
WriteAttributeValue("", 1164, item.Id, 1164, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????????? </a></td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\Client\ShowAllClients.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </table>\r\n\r\n    <div>\r\n        <a href=\"/Hotel/ShowHotel\">???????????????? ?? ???????????? ????????????</a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Laba4._5.Storage.Entity.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
