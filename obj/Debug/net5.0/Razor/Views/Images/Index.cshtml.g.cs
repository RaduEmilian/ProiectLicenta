#pragma checksum "C:\Users\radue\Desktop\123\TestFinal\Views\Images\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1129e9b3c830158fab2081b564572b1fbc28e740"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Images_Index), @"mvc.1.0.view", @"/Views/Images/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1129e9b3c830158fab2081b564572b1fbc28e740", @"/Views/Images/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158d93a35f0892a906b7c42f4f5e4e81dc1d6507", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Images_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/lightbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1129e9b3c830158fab2081b564572b1fbc28e7404081", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1129e9b3c830158fab2081b564572b1fbc28e7404377", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css\" rel=\"stylesheet\">\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n<!-- JavaScript Bundle with Popper -->\r\n<!--<script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js\" ></script>-->\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<link rel=""stylesheet"" href=""//cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css"" media=""screen"">
<script src=""//cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js""></script>



<!-- Page Content -->
<div class=""row>
    <div class=""col"">
        <div class=""jumbotron jumbotron-fluid"">
            <div class=""container"">
                <h1 class=""display-4"">Image Gallery</h1>
                <p class=""lead"">Just some random images from 4MOVING!</p>
            </div>
        </div>
    </div>
</div>
<div class=""container page-top"">



    <div class=""row"">


        <div class=""col-lg-3 col-md-4 col-xs-6 th");
            WriteLiteral(@"umb"">
            <a href=""https://images.pexels.com/photos/62307/air-bubbles-diving-underwater-blow-62307.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/62307/air-bubbles-diving-underwater-blow-62307.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 6622, "\"", 6628, 0);
            EndWriteAttribute();
            WriteLiteral(@">

            </a>
        </div>
        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/38238/maldives-ile-beach-sun-38238.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/38238/maldives-ile-beach-sun-38238.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""zoom img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 7051, "\"", 7057, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/158827/field-corn-air-frisch-158827.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/158827/field-corn-air-frisch-158827.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 7495, "\"", 7501, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/302804/pexels-photo-302804.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/302804/pexels-photo-302804.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 7921, "\"", 7927, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/1038914/pexels-photo-1038914.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/1038914/pexels-photo-1038914.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 8339, "\"", 8345, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/414645/pexels-photo-414645.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/414645/pexels-photo-414645.jpeg?auto=compress&cs=tinysrgb&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 8753, "\"", 8759, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/56005/fiji-beach-sand-palm-trees-56005.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/56005/fiji-beach-sand-palm-trees-56005.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 9203, "\"", 9209, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>

        <div class=""col-lg-3 col-md-4 col-xs-6 thumb"">
            <a href=""https://images.pexels.com/photos/1038002/pexels-photo-1038002.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""fancybox"" rel=""ligthbox"">
                <img src=""https://images.pexels.com/photos/1038002/pexels-photo-1038002.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=650&w=940"" class=""zoom img-fluid """);
            BeginWriteAttribute("alt", " alt=\"", 9633, "\"", 9639, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
        </div>




    </div>




</div>

<style>
    body {
        background-color: #1d1d1d !important;
        font-family: ""Asap"", sans-serif;
        color: #989898;
        margin: 10px;
        font-size: 16px;
    }

    .jumbotron{
        margin-top:100px;
    }

    #demo {
        height: 100%;
        position: relative;
        overflow: hidden;
    }


    .green {
        background-color: #6fb936;
    }

    .thumb {
        margin-bottom: 30px;
    }

    .page-top {
        margin-top: 85px;
    }


    img.zoom {
        width: 100%;
        height: 200px;
        border-radius: 5px;
        object-fit: cover;
        -webkit-transition: all .3s ease-in-out;
        -moz-transition: all .3s ease-in-out;
        -o-transition: all .3s ease-in-out;
        -ms-transition: all .3s ease-in-out;
    }


    .transition {
        -webkit-transform: scale(1.2);
        -moz-transform: scale(1.2);
        -o-transfor");
            WriteLiteral("m: scale(1.2);\r\n        transform: scale(1.2);\r\n    }\r\n\r\n    .modal-header {\r\n        border-bottom: none;\r\n    }\r\n\r\n    .modal-title {\r\n        color: #000;\r\n    }\r\n\r\n    .modal-footer {\r\n        display: none;\r\n    }\n\r\n</style>");
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
