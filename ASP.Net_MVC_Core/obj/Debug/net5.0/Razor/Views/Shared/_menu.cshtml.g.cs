#pragma checksum "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5ccc1e8681a134b0fd60459fd1769d0f2c1484"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__menu), @"mvc.1.0.view", @"/Views/Shared/_menu.cshtml")]
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
#line 1 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/_ViewImports.cshtml"
using ASP.Net_MVC_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/_ViewImports.cshtml"
using ASP.Net_MVC_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5ccc1e8681a134b0fd60459fd1769d0f2c1484", @"/Views/Shared/_menu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57813776563c54affa2fa1cd2a44caa69c64d8fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"menu_container container\">\n    <div class=\"menu_title\">\n        Quản lý sinh\n    </div>\n    <div class=\"menu_item\">\n        <div class=\"row item\">\n            ");
#nullable restore
#line (7,14)-(7,60) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml"
Write(Html.ActionLink("Lớp học", "index", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"row item\">\n            ");
#nullable restore
#line (10,14)-(10,62) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml"
Write(Html.ActionLink("Sinh viên", "index", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"row item\">\n            ");
#nullable restore
#line (13,14)-(13,61) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml"
Write(Html.ActionLink("Môn học", "course", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"row item\">\n            ");
#nullable restore
#line (16,14)-(16,57) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml"
Write(Html.ActionLink("Điểm", "point", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n        <div class=\"row item\">\n            ");
#nullable restore
#line (19,14)-(19,71) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Shared/_menu.cshtml"
Write(Html.ActionLink("Thành tích học tập", "index", "student"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591