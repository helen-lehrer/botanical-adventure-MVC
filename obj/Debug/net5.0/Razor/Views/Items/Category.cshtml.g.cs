#pragma checksum "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07549aeb2b50ce594378fe10f67017206c58d176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Category), @"mvc.1.0.view", @"/Views/Items/Category.cshtml")]
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
#line 5 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
using ForageMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07549aeb2b50ce594378fe10f67017206c58d176", @"/Views/Items/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40ea02e49d09b87f45804e478cbd7b45230b36a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Items_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/botanist.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 20em; height:35em;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
  
	Layout = "_Layout";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07549aeb2b50ce594378fe10f67017206c58d1764623", async() => {
                WriteLiteral(" ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07549aeb2b50ce594378fe10f67017206c58d1764878", async() => {
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
                WriteLiteral(" ");
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"mascot\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "07549aeb2b50ce594378fe10f67017206c58d1766815", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div id=""center-cat"">
<h3 id=""d-heading""><span>Select Difficulty Level:</span></h3>
<form id=""difficulty-level"">
  <select class=""custom-select"" id=""select"" style=""width: 200px;"">
      <option>Select Level</option> 
      <option value=""easy"">Easy</option> 
      <option value=""medium"">Medium</option>
      <option value=""hard"">Hard</option>  
  </select>
<button id=""button"" type=""submit"">Select</button>
</form>
</div>

<script type=""text/javascript"">
function submitEvent(event) {
  event.preventDefault();
  handleFormSubmission();
}
function handleFormSubmission () {
  hideResults();
  let formvalue = document.getElementById(""select"").value;
    if (formvalue == ""easy"") {
        document.getElementById(""easy"").removeAttribute(""class"", ""hidden"");
    }
    if (formvalue == ""medium"") {
        document.getElementById(""medium"").removeAttribute(""class"", ""hidden"");
    }
    if (formvalue == ""hard"") {
        document.getElementById(""hard"").removeAttribute(""class"", ""hidde");
            WriteLiteral(@"n"");
    }
    else {
    }
}
  function hideResults() {
  document.getElementById(""easy"").setAttribute(""class"", ""hidden""); 
  document.getElementById(""medium"").setAttribute(""class"", ""hidden""); 
  document.getElementById(""hard"").setAttribute(""class"", ""hidden""); 
}

window.addEventListener(""load"", function() {
  hideResults();
  const form = document.getElementById(""difficulty-level"");
  form.addEventListener(""submit"", submitEvent);
});
</script>

<div id=""easy"" class=""hidden common-class"">
");
#nullable restore
#line 57 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
     foreach (Item item in Model)
	{
    if (item.Difficulty == "easy")
    {
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
         using (Html.BeginForm("Details", "Items", new { id = item.ItemId}))   
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h6> <img");
            BeginWriteAttribute("src", " src=\"", 1916, "\"", 1951, 1);
#nullable restore
#line 63 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
WriteAttributeValue("", 1922, Url.Content(item.CatPicture), 1922, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\"/><br>");
#nullable restore
#line 63 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
                                                                  Write(Html.ActionLink(@item.Name, "Details", new { id = item.ItemId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 64 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<br>\r\n");
#nullable restore
#line 66 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
    }
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div id=\"medium\" class=\"hidden common-class\">\r\n");
#nullable restore
#line 71 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
     foreach (Item item in Model)
	{
    if (item.Difficulty == "medium")
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
     using (Html.BeginForm())   
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h6> <img");
            BeginWriteAttribute("src", " src=\"", 2263, "\"", 2298, 1);
#nullable restore
#line 77 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
WriteAttributeValue("", 2269, Url.Content(item.CatPicture), 2269, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\"/><br>");
#nullable restore
#line 77 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
                                                                  Write(Html.ActionLink(@item.Name, "Details", new { id = item.ItemId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 78 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
                                                                           
    }
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<div id=\"hard\" class=\"hidden common-class\">\r\n");
#nullable restore
#line 85 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
     foreach (Item item in Model)
	{
    if (item.Difficulty == "hard")
    {
		

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
         using (Html.BeginForm("Details", "Items", new { id = item.ItemId}))   
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h6> <img");
            BeginWriteAttribute("src", " src=\"", 2717, "\"", 2752, 1);
#nullable restore
#line 91 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
WriteAttributeValue("", 2723, Url.Content(item.CatPicture), 2723, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150px\"/><br>");
#nullable restore
#line 91 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
                                                                  Write(Html.ActionLink(@item.Name, "Details", new { id = item.ItemId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 92 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
     
    }
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n<div id=\"cat-link\"><span>\r\n");
#nullable restore
#line 97 "C:\Users\HLehr\desktop\botanical-adventure-MVC\Views\Items\Category.cshtml"
Write(Html.ActionLink("Choose Another Ecosystem", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n");
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
