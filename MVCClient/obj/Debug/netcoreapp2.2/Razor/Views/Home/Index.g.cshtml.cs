#pragma checksum "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f80c8eb68da8b072a6d3d199b194dcf57f1cba28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "G:\repo\Yubay.MicroService\MVCClient\Views\_ViewImports.cshtml"
using MVCClient;

#line default
#line hidden
#line 2 "G:\repo\Yubay.MicroService\MVCClient\Views\_ViewImports.cshtml"
using MVCClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f80c8eb68da8b072a6d3d199b194dcf57f1cba28", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6d0ae0c9d7e6e45ee166fce82a68c9aa028843", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 199, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<dl>\r\n");
            EndContext();
#line 11 "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml"
     foreach (var claim in User.Claims)
	{

#line default
#line hidden
            BeginContext(286, 6, true);
            WriteLiteral("\t\t<dt>");
            EndContext();
            BeginContext(293, 10, false);
#line 13 "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml"
       Write(claim.Type);

#line default
#line hidden
            EndContext();
            BeginContext(303, 13, true);
            WriteLiteral("</dt>\r\n\t\t<dt>");
            EndContext();
            BeginContext(317, 11, false);
#line 14 "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml"
       Write(claim.Value);

#line default
#line hidden
            EndContext();
            BeginContext(328, 7, true);
            WriteLiteral("</dt>\r\n");
            EndContext();
#line 15 "G:\repo\Yubay.MicroService\MVCClient\Views\Home\Index.cshtml"
	}

#line default
#line hidden
            BeginContext(339, 7, true);
            WriteLiteral("</dl>\r\n");
            EndContext();
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
