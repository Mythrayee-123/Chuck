#pragma checksum "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a5bcfaa1ecd3386b178f7295ff2971d0dc75344"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\_ViewImports.cshtml"
using ChuckJokes.ViewModel;

#line default
#line hidden
#line 2 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\_ViewImports.cshtml"
using ChuckJokes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a5bcfaa1ecd3386b178f7295ff2971d0dc75344", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d3f78a225812d5e60980887fbc0a832550bb6c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\Home\Details.cshtml"
  

    ViewBag.Title = "CategoryList";

#line default
#line hidden
            BeginContext(76, 139, true);
            WriteLiteral("<div class=\"row justify-content-center m-3 \">\r\n    <div class=\"align-content-lg-end\">\r\n        <div>\r\n            <h2 class=\"text-center\"> ");
            EndContext();
            BeginContext(216, 20, false);
#line 10 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\Home\Details.cshtml"
                                Write(Model.Category.Items);

#line default
#line hidden
            EndContext();
            BeginContext(236, 93, true);
            WriteLiteral("</h2>\r\n\r\n        </div>\r\n\r\n        <div class=\"card-body text-center \">\r\n\r\n\r\n            <h4>");
            EndContext();
            BeginContext(330, 19, false);
#line 17 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\Home\Details.cshtml"
           Write(Model.Category.Joke);

#line default
#line hidden
            EndContext();
            BeginContext(349, 45, true);
            WriteLiteral("</h4>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(395, 44, false);
#line 22 "C:\Users\yathi\source\repos\ChuckJokes\ChuckJokes\Views\Home\Details.cshtml"
Write(Html.ActionLink("Back toList", "Categories"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591