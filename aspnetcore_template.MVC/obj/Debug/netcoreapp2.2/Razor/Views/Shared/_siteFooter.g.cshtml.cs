#pragma checksum "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "390a9ccda08f0a8e20fcc451f37200c01b445685"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__siteFooter), @"mvc.1.0.view", @"/Views/Shared/_siteFooter.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_siteFooter.cshtml", typeof(AspNetCore.Views_Shared__siteFooter))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"390a9ccda08f0a8e20fcc451f37200c01b445685", @"/Views/Shared/_siteFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0d0a8222bf1d9bd71ff9c96fd1707d2fc9e42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__siteFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 187, true);
            WriteLiteral("\r\n<div id=\"wr-footer-container\" class=\"span-32 last\">\r\n    <div id=\"wr-footer-container-row1\">\r\n        <div class=\"li-table\">\r\n            <ul id=\"wr-footer-links\">\r\n                <li>");
            EndContext();
            BeginContext(188, 82, false);
#line 6 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteFooter.cshtml"
               Write(Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { id = "tab-lh" }));

#line default
#line hidden
            EndContext();
            BeginContext(270, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(298, 90, false);
#line 7 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteFooter.cshtml"
               Write(Html.ActionLink("Contact Us", "Contact", "Home", new { area = "" }, new { id = "tab-lh" }));

#line default
#line hidden
            EndContext();
            BeginContext(388, 27, true);
            WriteLiteral("</li>\r\n                <li>");
            EndContext();
            BeginContext(416, 79, false);
#line 8 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteFooter.cshtml"
               Write(Html.ActionLink("FAQ", "Faq", "Home", new { area = "" }, new { id = "tab-lh" }));

#line default
#line hidden
            EndContext();
            BeginContext(495, 492, true);
            WriteLiteral(@"</li>
            </ul>
        </div>
    </div>
    <div id=""wr-footer-container-row2"">
        <div class=""span-9 prepend-4"">
            <div id=""wr-footer-image"">
                <div id=""wr-footer-address"">
                    <ul>
                        <li><strong>DotNet Core 2.2 Template</strong></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
    <div class=""version span-32 alignLeft"">
        Braidss Version: ");
            EndContext();
            BeginContext(1019, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1075, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
