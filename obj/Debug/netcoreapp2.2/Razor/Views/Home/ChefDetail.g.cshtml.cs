#pragma checksum "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/Home/ChefDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d1e319bf8d61e8a88d18df9a8d9b4180450d313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ChefDetail), @"mvc.1.0.view", @"/Views/Home/ChefDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ChefDetail.cshtml", typeof(AspNetCore.Views_Home_ChefDetail))]
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
#line 1 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes;

#line default
#line hidden
#line 2 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d1e319bf8d61e8a88d18df9a8d9b4180450d313", @"/Views/Home/ChefDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e01085002f792202768963d7d0c07b88e1c684e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ChefDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chef>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/Home/ChefDetail.cshtml"
  
    Chef currentChef = ViewBag.CurrentChef;
    int dishCount = ViewBag.ChefCount;

#line default
#line hidden
            BeginContext(100, 15, true);
            WriteLiteral("\n<div>\n    <h3>");
            EndContext();
            BeginContext(116, 21, false);
#line 8 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/Home/ChefDetail.cshtml"
   Write(currentChef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(137, 14, true);
            WriteLiteral("</h3>\n    <h3>");
            EndContext();
            BeginContext(152, 20, false);
#line 9 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/Home/ChefDetail.cshtml"
   Write(currentChef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(172, 28, true);
            WriteLiteral("</h3>\n    <h4><b>Count:</b> ");
            EndContext();
            BeginContext(201, 9, false);
#line 10 "/home/rkratochwill/Documents/codingdojo/asp/ChefsAndDishes/Views/Home/ChefDetail.cshtml"
                 Write(dishCount);

#line default
#line hidden
            EndContext();
            BeginContext(210, 12, true);
            WriteLiteral("</h4>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chef> Html { get; private set; }
    }
}
#pragma warning restore 1591