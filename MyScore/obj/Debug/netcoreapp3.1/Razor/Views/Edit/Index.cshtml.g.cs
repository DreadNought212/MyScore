#pragma checksum "C:\Users\comra\source\repos\MyScore\MyScore\Views\Edit\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20aa0f455edad112329d0138c1cbf771aef79420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Edit_Index), @"mvc.1.0.view", @"/Views/Edit/Index.cshtml")]
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
#line 1 "C:\Users\comra\source\repos\MyScore\MyScore\Views\_ViewImports.cshtml"
using MyScore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\comra\source\repos\MyScore\MyScore\Views\_ViewImports.cshtml"
using MyScore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20aa0f455edad112329d0138c1cbf771aef79420", @"/Views/Edit/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47dd940f711f4678672382df8e01eed5de6d1f76", @"/Views/_ViewImports.cshtml")]
    public class Views_Edit_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\comra\source\repos\MyScore\MyScore\Views\Edit\Index.cshtml"
  
    Layout = "~/Views/Layouts/Layout_1.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Edit</h1>\r\n<a href=\"https://localhost:44306/Edit/MatchSelect\">Edit match</a>\r\n<a href=\"https://localhost:44306/Edit/LeagueSelect\">Edit league</a>\r\n<a href=\"https://localhost:44306/Edit/ClubSelect\">Edit club</a>");
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
