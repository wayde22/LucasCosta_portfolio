#pragma checksum "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49b6bb5e6d57e0e97d4c6c9db114aa3f72f8362e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lucas_Chocolate), @"mvc.1.0.view", @"/Views/Lucas/Chocolate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lucas/Chocolate.cshtml", typeof(AspNetCore.Views_Lucas_Chocolate))]
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
#line 1 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/_ViewImports.cshtml"
using LucasHelloWorldMVC;

#line default
#line hidden
#line 2 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/_ViewImports.cshtml"
using LucasHelloWorldMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49b6bb5e6d57e0e97d4c6c9db114aa3f72f8362e", @"/Views/Lucas/Chocolate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2d19e15305489f26582a7e13ccf516ddce506fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Lucas_Chocolate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Lucas/Chocolate/New"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Lucas/Chocolate/Remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
  
    ViewData["Title"] = "Chocolate";
    

#line default
#line hidden
            BeginContext(139, 47, true);
            WriteLiteral("\n<h2>CHOCOLATES</h2>\n\n<h3> Add a new one:</h3>\n");
            EndContext();
            BeginContext(186, 198, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c98b4998378437fb5af8220762a4c94", async() => {
                BeginContext(236, 141, true);
                WriteLiteral("\n    Name <input type=\"text\" name=\"name\" />\n    Description <input type=\"text\" name=\"description\" />\n    <input name=\"Submi\" type=\"submit\"/>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 10, true);
            WriteLiteral("\n\n<hr />\n\n");
            EndContext();
#line 19 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
 if (ViewBag.Chocolates.Count == 0)
{

#line default
#line hidden
            BeginContext(432, 33, true);
            WriteLiteral("  <p>No chocolates added yet</p>\n");
            EndContext();
#line 22 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(474, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(476, 605, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15d83e5bff2a44eeb28f4cc95031df56", async() => {
                BeginContext(529, 144, true);
                WriteLiteral("\n    <table width=\"50%\">\n      <tr>\n        <td>ID</td>\n        <td>Name</td>\n        <td>Description</td>\n        <td>Delete?</td>\n      </tr>\n");
                EndContext();
#line 33 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
       foreach (var chocolate in ViewBag.Chocolates)
      {

#line default
#line hidden
                BeginContext(734, 27, true);
                WriteLiteral("        <tr>\n          <td>");
                EndContext();
                BeginContext(762, 12, false);
#line 36 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
         Write(chocolate.ID);

#line default
#line hidden
                EndContext();
                BeginContext(774, 20, true);
                WriteLiteral("</td>\n          <td>");
                EndContext();
                BeginContext(795, 14, false);
#line 37 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
         Write(chocolate.Name);

#line default
#line hidden
                EndContext();
                BeginContext(809, 20, true);
                WriteLiteral("</td>\n          <td>");
                EndContext();
                BeginContext(830, 21, false);
#line 38 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
         Write(chocolate.Description);

#line default
#line hidden
                EndContext();
                BeginContext(851, 62, true);
                WriteLiteral("</td>\n          <td><input type=\"checkbox\" name=\"chocolateIds\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 913, "\"", 934, 1);
#line 39 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
WriteAttributeValue("", 921, chocolate.ID, 921, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 935, "\"", 953, 1);
#line 39 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
WriteAttributeValue("", 940, chocolate.ID, 940, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(954, 23, true);
                WriteLiteral(" /></td>\n        </tr>\n");
                EndContext();
#line 41 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
      }

#line default
#line hidden
                BeginContext(985, 89, true);
                WriteLiteral("    </table>\n    <br>\n    <input type=\"submit\" value=\"Remove Selected chocolate(s)\" />\n  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1081, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 46 "/Users/lucascosta/Desktop/LucasCosta_portfolio/c#/practice/launch_code/LucasHelloWorldMVC/LucasHelloWorldMVC/Views/Lucas/Chocolate.cshtml"
}

#line default
#line hidden
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
