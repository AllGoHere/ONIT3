#pragma checksum "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65734e57d7b5f86b264c76fe25938f370b26785b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CHnumber_ShowCHnumber), @"mvc.1.0.view", @"/Views/CHnumber/ShowCHnumber.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65734e57d7b5f86b264c76fe25938f370b26785b", @"/Views/CHnumber/ShowCHnumber.cshtml")]
    public class Views_CHnumber_ShowCHnumber : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Laba4._5.Managers.Perenos>
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
#line 3 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65734e57d7b5f86b264c76fe25938f370b26785b2986", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65734e57d7b5f86b264c76fe25938f370b26785b4064", async() => {
                WriteLiteral(@"
    <h1>???????????????????????????? ??????????????</h1>
    <table border=""1"" wIdth=""100%"" cellpadding=""5"">
        <tr>
            <th>???????????????????? ????????????</th>
            <th>???????????????????? ???????????????? ????????</th>
            <th></th>
            <th></th>
            <th></th>

        </tr>
");
#nullable restore
#line 24 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
          
            foreach (var item in Laba4._5.Managers.Perenos.chnumbers)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
                 if (item.HotelId == Laba4._5.Managers.Perenos.Guid)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
                       Write(item.rooms);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
                       Write(item.sleep);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 827, "\"", 865, 2);
                WriteAttributeValue("", 834, "/CHnumber/EditCHnumber/", 834, 23, true);
#nullable restore
#line 32 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
WriteAttributeValue("", 857, item.Id, 857, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> \"??????????????????????????\"</a></td>\r\n\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 926, "\"", 956, 2);
                WriteAttributeValue("", 933, "/CHnumber/Kick/", 933, 15, true);
#nullable restore
#line 34 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
WriteAttributeValue("", 948, item.Id, 948, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">?????????????? </a></td>\r\n                        <td><a");
                BeginWriteAttribute("href", " href=\"", 1007, "\"", 1042, 2);
                WriteAttributeValue("", 1014, "/Number/ShowNumbers/", 1014, 20, true);
#nullable restore
#line 35 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
WriteAttributeValue("", 1034, item.Id, 1034, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> ????????????</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
                 
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </table>\r\n");
#nullable restore
#line 41 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
     using (Html.BeginForm("CreateCHnumber", "CHnumber"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            <input type=\"submit\" value=\"???????????????? ????????????????????????????\" />\r\n\r\n        </div>\r\n");
#nullable restore
#line 47 "C:\Users\prosy\source\repos\Laba4.5\Laba4.5\Views\CHnumber\ShowCHnumber.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div>\r\n        <a href=\"/CHnumber/ShowAllCHnumbers\">???????????????? ?????? ????????????????????????????</a>\r\n    </div>\r\n    <div>\r\n        <a href=\"/Hotel/ShowHotel\">???????????????? ?? ???????????? ????????????</a>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Laba4._5.Managers.Perenos> Html { get; private set; }
    }
}
#pragma warning restore 1591
