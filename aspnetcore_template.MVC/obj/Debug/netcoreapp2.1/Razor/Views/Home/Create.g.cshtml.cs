#pragma checksum "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2124c8c2e2e8a40547711a7299d1b5e52e3572c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Create), @"mvc.1.0.view", @"/Views/Home/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Create.cshtml", typeof(AspNetCore.Views_Home_Create))]
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
#line 2 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
using aspnetcore_template.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2124c8c2e2e8a40547711a7299d1b5e52e3572c4", @"/Views/Home/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fd987d7388ad707b6b8d314dfa2b63ad979348", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<aspnetcore_template.Entities.Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#line 7 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(179, 32, true);
            WriteLiteral("    <div id=\"sidebar\">\r\n        ");
            EndContext();
            BeginContext(212, 35, false);
#line 11 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
   Write(await Html.PartialAsync("_Sidebar"));

#line default
#line hidden
            EndContext();
            BeginContext(247, 121, true);
            WriteLiteral("\r\n    </div>\r\n<div id=\"wrapper\">\r\n    <div id=\"main\">\r\n        <h1><span class=\"label label-primary\">Create</span></h1>\r\n");
            EndContext();
#line 16 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
     using (Html.BeginForm("Create", "Home", FormMethod.Post, new {@class = "form-horizontal", role = "form"}))

    {

#line default
#line hidden
            BeginContext(490, 151, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">Name</label>\r\n            <div class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(642, 52, false);
#line 22 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.LabelFor(m => m.Name, new {@class = "sr-only"}));

#line default
#line hidden
            EndContext();
            BeginContext(694, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(713, 53, false);
#line 23 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.EditorFor(m => m.Name, new {@class = "sr-only"}));

#line default
#line hidden
            EndContext();
            BeginContext(766, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(785, 38, false);
#line 24 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(823, 192, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"col-sm-2 control-label\">Cuisine</label>\r\n            <div class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1016, 55, false);
#line 30 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.LabelFor(m => m.Cuisine, new {@class = "sr-only"}));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1090, 134, false);
#line 31 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.DropDownListFor(m => m.Cuisine, Html.GetEnumSelectList(typeof (CuisineType)), new {@class = "btn btn-secondary dropdown-toggle"}));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1243, 41, false);
#line 32 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
           Write(Html.ValidationMessageFor(m => m.Cuisine));

#line default
#line hidden
            EndContext();
            BeginContext(1284, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
            BeginContext(1324, 200, true);
            WriteLiteral("        <div class=\"form-group\">\r\n            <div class=\"col-sm-offset-2 col-sm-10\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Save</button>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Projects\Core\Core2.2\aspnetcore_template\Views\Home\Create.cshtml"
    }

#line default
#line hidden
            BeginContext(1531, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<aspnetcore_template.Entities.Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
