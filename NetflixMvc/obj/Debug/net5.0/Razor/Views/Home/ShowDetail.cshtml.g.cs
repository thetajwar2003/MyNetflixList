#pragma checksum "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cccfa5493171fa45e86aa29c5016e74fa2a1291"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowDetail), @"mvc.1.0.view", @"/Views/Home/ShowDetail.cshtml")]
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
#line 1 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/_ViewImports.cshtml"
using NetflixMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/_ViewImports.cshtml"
using NetflixMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cccfa5493171fa45e86aa29c5016e74fa2a1291", @"/Views/Home/ShowDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c16949d47bbcab18cf658a7edb2307b2fdcd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Packt.Shared.Shows>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModelBinding", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
  
    ViewData["Title"] = "Show Detail - " + Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 5 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<hr />\n<div>\n <dl class=\"dl-horizontal\">\n <dt>Director</dt>\n");
#nullable restore
#line 10 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
  if (@Model.director == null)
        { 

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>");
#nullable restore
#line 12 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
       Write(Model.director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n");
#nullable restore
#line 13 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dd>Unkown</dd>\n");
#nullable restore
#line 17 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" <dt>Catgory</dt>\n <dd>");
#nullable restore
#line 19 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
Write(Model.listed_in);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n <dt>Duration</dt>\n <dd>");
#nullable restore
#line 21 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
Write(Model.duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n <dt>Description</dt>\n <dd>");
#nullable restore
#line 23 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
Write(Model.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\n <dt>Rating</dt>\n <dd>\n     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cccfa5493171fa45e86aa29c5016e74fa2a12915940", async() => {
                WriteLiteral("Click here to rate the show/movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-show_title", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "/Users/sab0taj/Desktop/AppDev/C# Workspace/FinalProj/NetflixMvc/Views/Home/ShowDetail.cshtml"
              WriteLiteral(Model.title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["show_title"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-show_title", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["show_title"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n </dd>\n<dt>List of trailers</dt>\n<dd>\n    <a href=\"https://youtube.com/results?search_query={Model.title}+trailer\" target=\"_blank\">Trailers</a>\n</dd>\n </dl>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Packt.Shared.Shows> Html { get; private set; }
    }
}
#pragma warning restore 1591
