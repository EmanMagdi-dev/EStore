#pragma checksum "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "794057d0d3983e51a725abfea85269d186cfe6a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\t\Desktop\GB\eStore\eStore\Views\_ViewImports.cshtml"
using eStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\t\Desktop\GB\eStore\eStore\Views\_ViewImports.cshtml"
using eStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"794057d0d3983e51a725abfea85269d186cfe6a6", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a7cd37460f953b9787e736e6c4fe42df2fc1ad", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:20px; width:fit-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<style>\r\n    .off{\r\n        display:none;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794057d0d3983e51a725abfea85269d186cfe6a65043", async() => {
                WriteLiteral(@"
<div  style=""display:flex; width:fit-content;padding:50px;  box-shadow: 0 0px 5px var(--box-shadow-color);
border:2px solid var(--main-color-opp);
justify-content:space-evenly; color:var(--main-color-opp)"">
    <div  style=""text-align:center; margin-right:90px"">
        <a style=""cursor:pointer"" onclick=""previous()"">
         <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""var(--main-color-opp)"" class=""bi bi-skip-backward-circle-fill"" viewBox=""0 0 16 16"">
  <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zm-4.79-2.907L8.5 7.028V5.5a.5.5 0 0 0-.79-.407L5 7.028V5.5a.5.5 0 0 0-1 0v5a.5.5 0 0 0 1 0V8.972l2.71 1.935a.5.5 0 0 0 .79-.407V8.972l2.71 1.935A.5.5 0 0 0 12 10.5v-5a.5.5 0 0 0-.79-.407z""/>
</svg>
        </a>
        <img class=""on"" style=""width:250px""");
                BeginWriteAttribute("src", " src=\"", 955, "\"", 982, 2);
                WriteAttributeValue("", 961, "/images/", 961, 8, true);
#nullable restore
#line 20 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
WriteAttributeValue("", 969, Model.Image1, 969, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n        <img class=\"off\" style=\"width:250px\"");
                BeginWriteAttribute("src", " src=\"", 1033, "\"", 1060, 2);
                WriteAttributeValue("", 1039, "/images/", 1039, 8, true);
#nullable restore
#line 21 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
WriteAttributeValue("", 1047, Model.Image2, 1047, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n        <img class=\"off\" style=\"width:250px\"");
                BeginWriteAttribute("src", " src=\"", 1111, "\"", 1138, 2);
                WriteAttributeValue("", 1117, "/images/", 1117, 8, true);
#nullable restore
#line 22 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
WriteAttributeValue("", 1125, Model.Image3, 1125, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /> 

       <a style=""cursor:pointer""onclick=""next()"">
           <svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""var(--main-color-opp)"" class=""bi bi-skip-forward-circle-fill"" viewBox=""0 0 16 16"">
  <path d=""M16 8A8 8 0 1 1 0 8a8 8 0 0 1 16 0zM4.79 5.093A.5.5 0 0 0 4 5.5v5a.5.5 0 0 0 .79.407L7.5 8.972V10.5a.5.5 0 0 0 .79.407L11 8.972V10.5a.5.5 0 0 0 1 0v-5a.5.5 0 0 0-1 0v1.528L8.29 5.093a.5.5 0 0 0-.79.407v1.528L4.79 5.093z""/>
</svg>
       </a>

        <br />
        <h2 style=""color:var(--main-color)"">");
#nullable restore
#line 31 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n    </div>\r\n    <div style=\"text-align:center\">\r\n");
#nullable restore
#line 34 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
          if (User.IsInRole("admin"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <br />\r\n                <br />\r\n                <br />\r\n");
#nullable restore
#line 39 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3>Category :<span style=\"color:var(--main-color-alt)\">");
#nullable restore
#line 40 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
                                                           Write(Model.Cat.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></h3>\r\n        <h3> Price per item : <span style=\"color:var(--main-color-alt)\">");
#nullable restore
#line 41 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
                                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>$</h3>\r\n        \r\n");
#nullable restore
#line 43 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
         if (User.IsInRole("customer")) 
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <label>Quantity : </label>\r\n            <input style=\"width:50px\" min=\"1\" max=\"100\" id=\"quantity\" type=\"number\" value=\"1\" name=\"quantity\" />\r\n            <br /><br />\r\n            <a style=\"cursor:pointer; color:var(--main-color-alt)\"");
                BeginWriteAttribute("onclick", "\r\n                onclick=\"", 2389, "\"", 2519, 3);
                WriteAttributeValue("", 2416, "this.href=\'/cart/saveOrder?ProductId=\'+", 2416, 39, true);
#nullable restore
#line 49 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
WriteAttributeValue("", 2455, Model.id, 2455, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2464, "+\'&quantity=\'+document.getElementById(\'quantity\').value", 2464, 55, true);
                EndWriteAttribute();
                WriteLiteral(@">
                Add to cart &nbsp;
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""var(--main-color-alt)"" class=""bi bi-cart"" viewBox=""0 0 16 16"">
                <path d=""M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 1 0 2 1 1 0 0 1 0-2zm7 0a1 1 0 1 1 0 2 1 1 0 0 1 0-2z""/>
                </svg>
            </a>");
#nullable restore
#line 54 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n</div>\r\n<div style=\"margin-top:20px;margin-left:20px\">\r\n");
#nullable restore
#line 58 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
     if (User.IsInRole("admin"))
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794057d0d3983e51a725abfea85269d186cfe6a611855", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
                                   WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n           <span>&nbsp; &nbsp; &nbsp; &nbsp;</span> \r\n");
#nullable restore
#line 62 "C:\Users\t\Desktop\GB\eStore\eStore\Views\Product\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "794057d0d3983e51a725abfea85269d186cfe6a614337", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>
let imgs = document.querySelectorAll(""form img"")
let i=0;

function next()
{
    if(imgs[i].className=""on"" && i<2){
        imgs.forEach((li) => {
            li.className = ""off"";
        });
        imgs[i+1].className=""on"";
        i++;
    }
}

function previous()
{
    if(imgs[i].className=""on"" && i>0){
        imgs.forEach((li) => {
            li.className = ""off"";
        });
        imgs[i-1].className=""on"";
        i--;
    }
}
</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
