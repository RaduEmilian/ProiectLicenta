#pragma checksum "C:\Users\radue\Desktop\123\TestFinal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18304ac3037d50061b3d5f9ad759dd6bfdec7d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18304ac3037d50061b3d5f9ad759dd6bfdec7d48", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"158d93a35f0892a906b7c42f4f5e4e81dc1d6507", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:contain;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("First slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/6.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Second slide"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\radue\Desktop\123\TestFinal\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"
<div class=""col pt-1"">
    <!--Carousel Wrapper-->
    <div id=""carousel-example-2"" class=""carousel slide carousel-fade z-depth-1-half"" data-ride=""carousel"">
        <!--Indicators-->
        <ol class=""carousel-indicators"">
            <li data-target=""#carousel-example-2"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carousel-example-2"" data-slide-to=""1""></li>
        </ol>
        <!--/.Indicators-->
        <!--Slides-->
        <div class=""carousel-inner"" role=""listbox"">
            <div class=""carousel-item active"">
                <div class=""view"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18304ac3037d50061b3d5f9ad759dd6bfdec7d486620", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"mask rgba-black-light\"></div>\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"carousel-item\">\r\n                <!--Mask color-->\r\n                <div class=\"view\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "18304ac3037d50061b3d5f9ad759dd6bfdec7d488161", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""mask rgba-black-light""></div>
                </div>
            </div>
        </div>
        <!--/.Slides-->
        <!--Controls-->
        <a class=""carousel-control-prev"" href=""#carousel-example-2"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carousel-example-2"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
        <!--/.Controls-->
    </div>
    <!--/.Carousel Wrapper-->
</div>




<!-- Remove the container if you want to extend the Footer to full width. -->
<!-- Footer -->
<footer class=""text-center text-lg-start text-white""
        style=""background-color: #1c2331"">
    <!-- Section: Social media -->
    <section class=""d-flex justify-conten");
            WriteLiteral(@"t-between p-4""
             style=""background-color: #6351ce"">
        <!-- Left -->
        <div class=""me-5"">
            <span>Get connected with us on social networks:</span>
        </div>
        <!-- Left -->
        <!-- Right -->
        <div>
            <a");
            BeginWriteAttribute("href", " href=\"", 4907, "\"", 4914, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa-brands fa-facebook\"></i>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5029, "\"", 5036, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa fa-twitter\"></i>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5143, "\"", 5150, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa fa-google\"></i>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5256, "\"", 5263, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa fa-instagram\"></i>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5372, "\"", 5379, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa fa-linkedin\"></i>\r\n            </a>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 5487, "\"", 5494, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white me-4\">\r\n                <i class=\"fa fa-github\"></i>\r\n            </a>\r\n        </div>\r\n        <!-- Right -->\r\n    </section>\r\n    <!-- Section: Social media -->\r\n    <!-- Section: Links  -->\r\n    <section");
            BeginWriteAttribute("class", " class=\"", 5720, "\"", 5728, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""container text-center text-md-start mt-5"">
            <!-- Grid row -->
            <div class=""row mt-3"">
                <!-- Grid column -->
                <div class=""col-md-3 col-lg-4 col-xl-3 mx-auto mb-4"">
                    <!-- Content -->
                    <h6 class=""text-uppercase fw-bold"">Company name</h6>
                    <hr class=""mb-4 mt-0 d-inline-block mx-auto""
                        style=""width: 60px; background-color: #7c4dff; height: 2px"" />
                    <p>
                        Here you can use rows and columns to organize your footer
                        content. Lorem ipsum dolor sit amet, consectetur adipisicing
                        elit.
                    </p>
                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto mb-4"">
                    <!-- Links -->
                    <h6 class=""text-uppercase fw-bold"">Pr");
            WriteLiteral(@"oducts</h6>
                    <hr class=""mb-4 mt-0 d-inline-block mx-auto""
                        style=""width: 60px; background-color: #7c4dff; height: 2px"" />
                    <p>
                        <a href=""#!"" class=""text-white"">MDBootstrap</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">MDWordPress</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">BrandFlow</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">Bootstrap Angular</a>
                    </p>
                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto mb-4"">
                    <!-- Links -->
                    <h6 class=""text-uppercase fw-bold"">Useful links</h6>
                    <hr class=""mb-4 mt-0 d-inline-block mx-auto""
          ");
            WriteLiteral(@"              style=""width: 60px; background-color: #7c4dff; height: 2px"" />
                    <p>
                        <a href=""#!"" class=""text-white"">Your Account</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">Become an Affiliate</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">Shipping Rates</a>
                    </p>
                    <p>
                        <a href=""#!"" class=""text-white"">Help</a>
                    </p>
                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class=""col-md-4 col-lg-3 col-xl-3 mx-auto mb-md-0 mb-4"">
                    <!-- Links -->
                    <h6 class=""text-uppercase fw-bold"">Contact</h6>
                    <hr class=""mb-4 mt-0 d-inline-block mx-auto""
                        style=""width: 60px; background-color: #7c4dff; height: 2px"" />
       ");
            WriteLiteral(@"             <p><i class=""fa fa-home mr-3""></i> New York, NY 10012, US</p>
                    <p><i class=""fa fa-envelope mr-3""></i> info@example.com</p>
                    <p><i class=""fa fa-phone mr-3""></i> + 01 234 567 88</p>
                    <p><i class=""fa fa-print mr-3""></i> + 01 234 567 89</p>
                </div>
                <!-- Grid column -->
            </div>
            <!-- Grid row -->
        </div>
    </section>
    <!-- Section: Links  -->
    <!-- Copyright -->
    <div class=""text-center p-3""
         style=""background-color: rgba(0, 0, 0, 0.2)"">
        © 2020 Copyright:
        <a class=""text-white"" href=""https://mdbootstrap.com/"">MDBootstrap.com</a>
    </div>
    <!-- Copyright -->
</footer>
<!-- Footer -->
<!-- End of .container -->
<!-- Optional JavaScript -->
<!-- jQuery first, then Popper.js, then Bootstrap JS -->
<script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1");
            WriteLiteral(@"yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"" integrity=""sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6"" crossorigin=""anonymous""></script>
");
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