#pragma checksum "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7afce936e4eafa8bd0245a8e961e1e6a0447ec8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TelephoneVendeurs_AjouterTelephone), @"mvc.1.0.view", @"/Views/TelephoneVendeurs/AjouterTelephone.cshtml")]
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
#line 1 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7afce936e4eafa8bd0245a8e961e1e6a0447ec8e", @"/Views/TelephoneVendeurs/AjouterTelephone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_TelephoneVendeurs_AjouterTelephone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VenteMobile.Models.Vendeur>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/TelephoneVendeurs/AjouterTelephone"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
  
    ViewData["Title"] = "AjouterTelephone";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h7></h7>\r\n<h3 style=\"text-align:center\"> Assigner un telephone a <B>");
#nullable restore
#line 9 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
                                                     Write(Model.VendeurNom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</B></h3>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7afce936e4eafa8bd0245a8e961e1e6a0447ec8e5763", async() => {
                WriteLiteral("\r\n\r\n    <ul style=\'list-style-type:none;\'>\r\n");
#nullable restore
#line 14 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
         foreach (var Telephone in ViewBag.Telephone)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
             foreach (var VendManu in ViewBag.VendeurManufacturier)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
                 if (@Telephone.ManufacturierId == VendManu.ManufacturierId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <li>\r\n                        <input type=\"checkbox\" name=\"TelephoneIds\"");
                BeginWriteAttribute("value", " value=\"", 640, "\"", 670, 1);
#nullable restore
#line 21 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
WriteAttributeValue("", 648, Telephone.TelephoneId, 648, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
#nullable restore
#line 21 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
                                                                                               Write(Telephone.TelephoneModel);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 23 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\r\n\r\n    <input type=\"submit\" value=\"Assigner un telephone\" class=\"btn btn-default\" />\r\n\r\n    <a");
                BeginWriteAttribute("href", " href=\"", 879, "\"", 936, 1);
#nullable restore
#line 31 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\AjouterTelephone.cshtml"
WriteAttributeValue("", 886, Url.Action("List",  new { id = Model.VendeurId }), 886, 50, false);

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
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7afce936e4eafa8bd0245a8e961e1e6a0447ec8e10725", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7afce936e4eafa8bd0245a8e961e1e6a0447ec8e11825", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
