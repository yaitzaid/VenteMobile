#pragma checksum "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78736e3c7212ac2de9c9a7e9c8e1e9756bd43d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VendeurManufacturiers_CreateVendeurManufacturierss), @"mvc.1.0.view", @"/Views/VendeurManufacturiers/CreateVendeurManufacturierss.cshtml")]
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
#line 1 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78736e3c7212ac2de9c9a7e9c8e1e9756bd43d7a", @"/Views/VendeurManufacturiers/CreateVendeurManufacturierss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_VendeurManufacturiers_CreateVendeurManufacturierss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VenteMobile.Models.Vendeur>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/VendeurManufacturiers/CreateVendeurManufacturierss"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
  
    ViewData["Title"] = "CreateVendeurManufacturierss";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h7></h7>\r\n<h3 style=\"text-align:center\"> Assigner une manifacturier a <B>");
#nullable restore
#line 9 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
                                                          Write(Model.VendeurNom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</B></h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "78736e3c7212ac2de9c9a7e9c8e1e9756bd43d7a4973", async() => {
                WriteLiteral("\r\n\r\n    <ul style=\'list-style-type:none;\'>\r\n");
#nullable restore
#line 14 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
         foreach (var Manufacturier in ViewBag.Manufacturier)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li>\r\n                <input type=\"checkbox\" name=\"ManufacturierIds\"");
                BeginWriteAttribute("value", " value=\"", 488, "\"", 526, 1);
#nullable restore
#line 17 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
WriteAttributeValue("", 496, Manufacturier.ManufacturierId, 496, 30, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 17 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
                                                                                                   Write(Manufacturier.ManufacturierMarque);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 19 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <input type=\"submit\" value=\"Assigner une manifacturier\" class=\"btn btn-default\" />\r\n");
                WriteLiteral("    <a");
                BeginWriteAttribute("href", " href=\"", 873, "\"", 930, 1);
#nullable restore
#line 26 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\CreateVendeurManufacturierss.cshtml"
WriteAttributeValue("", 880, Url.Action("List",  new { id = Model.VendeurId }), 880, 50, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-default\">\r\n        <span>Cliquer ici pour revenir</span>\r\n    </a>\r\n");
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
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VenteMobile.Models.Vendeur> Html { get; private set; }
    }
}
#pragma warning restore 1591