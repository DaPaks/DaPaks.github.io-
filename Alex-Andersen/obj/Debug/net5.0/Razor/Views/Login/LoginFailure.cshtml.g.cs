#pragma checksum "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca43044ac19a8ed886d017f3d813726cac7d8ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_LoginFailure), @"mvc.1.0.view", @"/Views/Login/LoginFailure.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca43044ac19a8ed886d017f3d813726cac7d8ea7", @"/Views/Login/LoginFailure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"622c26a949408575ba1a903da5706303dca9fcad", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_LoginFailure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Alex_Andersen.Models.User>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml"
  
    Layout = "../Shared/_LoginLayout.cshtml";
    ViewData["Title"] = "Login fejlede";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Login fejlede</h1>\r\n<h2>Prøv igen</h2>\r\n   \r\n<dl class=\"row\">\r\n\r\n       <dt class = \"col-sm-2\">\r\n           ");
#nullable restore
#line 14 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml"
      Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </dt>\r\n       <dd class = \"col-sm-10\">\r\n           ");
#nullable restore
#line 17 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml"
      Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </dd>\r\n\r\n\r\n       <dt class = \"col-sm-2\">\r\n           ");
#nullable restore
#line 22 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml"
      Write(Html.DisplayNameFor(model => model.UserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </dt>\r\n       <dd class = \"col-sm-10\">\r\n           ");
#nullable restore
#line 25 "C:\Users\David\Documents\GitHub\AlexAndersen\Alex-Andersen\Views\Login\LoginFailure.cshtml"
      Write(Html.DisplayFor(model => model.UserPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </dd>\r\n   \r\n   </dl>\r\n\r\n<div class=\"backToLogin\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca43044ac19a8ed886d017f3d813726cac7d8ea75208", async() => {
                WriteLiteral("Tilbage");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Alex_Andersen.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
