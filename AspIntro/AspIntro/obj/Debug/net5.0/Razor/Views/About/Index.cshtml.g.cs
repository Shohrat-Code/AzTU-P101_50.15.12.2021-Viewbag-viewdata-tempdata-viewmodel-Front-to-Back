#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5515e6a0c8c519bd4bfaa450ee10de4307918b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\_ViewImports.cshtml"
using AspIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\_ViewImports.cshtml"
using AspIntro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5515e6a0c8c519bd4bfaa450ee10de4307918b8e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9698a9fbe3b385e71fe1b3d043d91dc608340bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>About Index</h1>\r\n<p>Lorem ipsum qazax ipsum</p>\r\n<p>Name - ");
#nullable restore
#line 8 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
     Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Surname - ");
#nullable restore
#line 9 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
        Write(ViewData["Surname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Age - ");
#nullable restore
#line 10 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
    Write(TempData.Peek("Age"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<ul>\r\n");
#nullable restore
#line 13 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
     for (int i = 1; i <= 10; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 15 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\50.15.12.2021-Viewbag, viewdata, tempdata, viewmodel\Codes\AspIntro\AspIntro\Views\About\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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