#pragma checksum "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Partials\Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "646334224ee0c95848d7bdc0d8ed8a5d22f9e78c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Header), @"mvc.1.0.view", @"/Views/Partials/Header.cshtml")]
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
#line 1 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\_ViewImports.cshtml"
using Alex_Andersen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\_ViewImports.cshtml"
using Alex_Andersen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"646334224ee0c95848d7bdc0d8ed8a5d22f9e78c", @"/Views/Partials/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622c26a949408575ba1a903da5706303dca9fcad", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<header>\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Partials\Header.cshtml"
   Write(ViewData["Headline"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h3>");
#nullable restore
#line 8 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Partials\Header.cshtml"
   Write(ViewData["Description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591