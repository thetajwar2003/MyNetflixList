#pragma checksum "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/Web/Pages/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f6538baf7076884a3097a27fa54261f3e3b1a1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_index), @"mvc.1.0.razor-page", @"/Pages/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f6538baf7076884a3097a27fa54261f3e3b1a1e", @"/Pages/index.cshtml")]
    public class Pages_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron\">\n <h1 class=\"display-3\">Welcome to Northwind!</h1>\n <p class=\"lead\">We supply products to our customers.</p>\n <hr />\n <p>It\'s ");
#nullable restore
#line 15 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/Web/Pages/index.cshtml"
    Write(Model.DayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("! Our customers include restaurants,\nhotels, and cruise lines.</p>\n <p>\n <a class=\"btn btn-primary\" href=\"shows\">Learn more about\nour suppliers</a>\n </p>\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 3 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/Web/Pages/index.cshtml"
 
    public string DayName { get; set; }
    public void OnGet()
    {
        ViewData["Title"] = "Netflix Website";
        Model.DayName = DateTime.Now.ToString("dddd");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_index>)PageContext?.ViewData;
        public Pages_index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
