#pragma checksum "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3aec50084bc37099ff7567799eaca1973203d1cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VendeurManufacturiers_List), @"mvc.1.0.view", @"/Views/VendeurManufacturiers/List.cshtml")]
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
#line 1 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aec50084bc37099ff7567799eaca1973203d1cc", @"/Views/VendeurManufacturiers/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_VendeurManufacturiers_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VenteMobile.Models.VendeurManufacturier>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
  
    ViewData["Title"] = "List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"text-align:center\"><B> Liste Des Manufacturiers vendu par ");
#nullable restore
#line 8 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
                                                                 Write(((Vendeur)ViewBag.Vendeurs).VendeurNom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</B></h3>\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
Write(Html.ActionLink("Cliquer ici pour revenir", "Details", "Vendeurs", new { id = ((Vendeur)ViewBag.Vendeurs).VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
Write(Html.ActionLink("Cliquer ici pour assigner une manifacturier", "CreateVendeurManufacturierss", "VendeurManufacturiers", new { vendeurId = ((Vendeur)ViewBag.Vendeurs).VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Vendeur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Manufacturier));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vendeur.VendeurNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 37 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
               Write(Html.ActionLink(item.Manufacturier.ManufacturierMarque, "Detail", "Manufacturiers", new { idM = item.Manufacturier.ManufacturierId, idV = item.Vendeur.VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { idV = item.Vendeur.VendeurId, idM = item.Manufacturier.ManufacturierId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\VendeurManufacturiers\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VenteMobile.Models.VendeurManufacturier>> Html { get; private set; }
    }
}
#pragma warning restore 1591
