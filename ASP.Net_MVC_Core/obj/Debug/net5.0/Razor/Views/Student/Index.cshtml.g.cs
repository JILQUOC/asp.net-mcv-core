#pragma checksum "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3a362f287584ec01c202259e08415f6b1a85f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3a362f287584ec01c202259e08415f6b1a85f4c", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57813776563c54affa2fa1cd2a44caa69c64d8fc", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ASP.Net_MVC_Core.Models.Student>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""row list_container"">
        <div class=""title col-12"">Danh sách sinh viên </div>
        <div>Tìm theo mã sinh viêm :  </div>
        <div class=""data_grid col-12"">
            <table>
                <tr>
                    <th>Mã SV</th>
                    <th>Họ và tên</th>
                    <th>Ngày sinh</th>
                    <th>Địa chỉ</th>
                </tr>
");
#nullable restore
#line 14 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
                  
                    if (Model != null && Model.Any())
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line (20,38)-(20,45) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line (21,38)-(21,47) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line (22,38)-(22,80) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
Write(item.birthday.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line (23,38)-(23,55) 6 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
Write(item.address_full);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            </tr>\n");
#nullable restore
#line 25 "/Users/hoangdoan/Library/Mobile Documents/com~apple~CloudDocs/EDU/BaiTapLapTrinhWeb_ASP.Net MVC Core/SourceCode/ASP.Net_MVC_Core/Views/Student/Index.cshtml"
                        }
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </table>\n        </div>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ASP.Net_MVC_Core.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
