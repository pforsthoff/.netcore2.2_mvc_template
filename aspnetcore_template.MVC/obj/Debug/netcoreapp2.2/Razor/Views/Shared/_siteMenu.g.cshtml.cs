#pragma checksum "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3468eb08cf2c55c09c03e94caf7942d15b9b0c96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__siteMenu), @"mvc.1.0.view", @"/Views/Shared/_siteMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_siteMenu.cshtml", typeof(AspNetCore.Views_Shared__siteMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3468eb08cf2c55c09c03e94caf7942d15b9b0c96", @"/Views/Shared/_siteMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0d0a8222bf1d9bd71ff9c96fd1707d2fc9e42c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__siteMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 43, true);
            WriteLiteral("<ul id=\"sf-menu\" class=\"sf-menu\">\r\n    <li>");
            EndContext();
            BeginContext(44, 96, false);
#line 2 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteMenu.cshtml"
   Write(Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @style = "font-size: 10px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(140, 17, true);
            WriteLiteral("</li>\r\n    <li>\r\n");
            EndContext();
            BeginContext(204, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(213, 97, false);
#line 5 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteMenu.cshtml"
   Write(Html.ActionLink("MPS", "Index", "MPS", new { area = "MPS" }, new { @style = "font-size: 10px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(310, 25, true);
            WriteLiteral("\r\n\r\n    </li>\r\n    <li>\r\n");
            EndContext();
            BeginContext(394, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(403, 117, false);
#line 10 "C:\Projects\Core\Core2.2\aspnetcore_template.MVC\Views\Shared\_siteMenu.cshtml"
   Write(Html.ActionLink("Ind Demand", "Index", "Iwa_Spares", new { area = "IWA_SPARES" }, new { @style = "font-size: 8px;" }));

#line default
#line hidden
            EndContext();
            BeginContext(520, 13, true);
            WriteLiteral("\r\n    </li>\r\n");
            EndContext();
            BeginContext(544, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
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
