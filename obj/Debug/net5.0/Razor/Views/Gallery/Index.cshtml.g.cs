#pragma checksum "C:\Users\radue\Desktop\123\TestFinal\Views\Gallery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829ee5abe3e9838dbd9db41b092634f981a95c8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gallery_Index), @"mvc.1.0.view", @"/Views/Gallery/Index.cshtml")]
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
#line 1 "C:\Users\radue\Desktop\123\TestFinal\Views\_ViewImports.cshtml"
using TestFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\radue\Desktop\123\TestFinal\Views\_ViewImports.cshtml"
using TestFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\radue\Desktop\123\TestFinal\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829ee5abe3e9838dbd9db41b092634f981a95c8e", @"/Views/Gallery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158d93a35f0892a906b7c42f4f5e4e81dc1d6507", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Gallery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestFinal.Models.GalleryIndexModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class =\"row gallery-content\">\r\n");
#nullable restore
#line 5 "C:\Users\radue\Desktop\123\TestFinal\Views\Gallery\Index.cshtml"
         foreach(var image in Model.Images)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"gallery-image-container\">\r\n            <div class=\"gallery-image\"");
            BeginWriteAttribute("style", " style=\"", 268, "\"", 308, 3);
            WriteAttributeValue("", 276, "background-image:url(", 276, 21, true);
#nullable restore
#line 8 "C:\Users\radue\Desktop\123\TestFinal\Views\Gallery\Index.cshtml"
WriteAttributeValue("", 297, image.Url, 297, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 307, ")", 307, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n");
#nullable restore
#line 10 "C:\Users\radue\Desktop\123\TestFinal\Views\Gallery\Index.cshtml"
           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestFinal.Models.GalleryIndexModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
