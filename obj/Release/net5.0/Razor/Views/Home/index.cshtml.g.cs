#pragma checksum "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3558f3bef09afb213da925d4f6fb8b4157043016"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Northwind.Views.Home.Views_Home_index), @"mvc.1.0.view", @"/Views/Home/index.cshtml")]
namespace Northwind.Views.Home
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
#line 1 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
using Northwind.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3558f3bef09afb213da925d4f6fb8b4157043016", @"/Views/Home/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70bf1df53b33fea91dda06fa7f9b47512c91048", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Discount>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/client.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<div class=""jumbotron my-2 border border-secondary"">
    <h1 class=""display2"">Northwind</h1>
    <p class=""lead"">We have the best prices and selection of high quality foods &amp; beverages on the planet! Check out our featured discounts below.</p>
    <hr class=""my-4 bg-white"">
    <p>For exceptional international quisuine, look no further.</p>
    <a class=""btn btn-outline-light btn-lg"" href=""#"" role=""button""><i class=""fas fa-shopping-cart""></i> Order Now</a>
</div>
<div class=""row row-cols-1 row-cols-lg-3"">
");
#nullable restore
#line 12 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
     foreach (Discount d in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col discounts px-2 py-4\">\r\n            <h3>");
#nullable restore
#line 15 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
           Write(d.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div class=\"mb-4\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
           Write(d.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <i>Discount expires: ");
#nullable restore
#line 19 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
                            Write(d.EndTime.ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i><br />\r\n            <a href=\"#\" class=\"code\" data-code=\"");
#nullable restore
#line 20 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
                                           Write(d.code);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"code\"><i class=\"far fa-hand-point-right\"></i> Discount Code</a>\r\n        </div>\r\n");
#nullable restore
#line 22 "C:\Users\Owner\source\repos\Northwind\Views\Home\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
<!-- toast -->
    <div id=""toast"" class=""toast"">
        <div class=""toast-header"">
            <strong class=""mr-auto"" id=""product"">Product Name</strong>
            <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"" aria-label=""Close"">
                <span aria-hidden=""true"">&times;</span>
            </button>
        </div>
        <div class=""toast-body"">
            Discount Code: <strong id=""code"">CODE</strong>
        </div>
    </div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3558f3bef09afb213da925d4f6fb8b41570430166402", async() => {
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
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Discount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
