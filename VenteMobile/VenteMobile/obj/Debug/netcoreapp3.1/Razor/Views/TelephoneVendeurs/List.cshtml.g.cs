#pragma checksum "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80d0da6d8219ac002c4a06ae0df33c4cef9c567"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TelephoneVendeurs_List), @"mvc.1.0.view", @"/Views/TelephoneVendeurs/List.cshtml")]
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
#line 1 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80d0da6d8219ac002c4a06ae0df33c4cef9c567", @"/Views/TelephoneVendeurs/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_TelephoneVendeurs_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VenteMobile.Models.TelephoneVendeur>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
  
    ViewData["Title"] = "List";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"text-align:center\"><B> Liste Des Telephones vendu par ");
#nullable restore
#line 8 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
                                                             Write(((Vendeur)ViewBag.Vendeurs).VendeurNom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</B></h3>\r\n<p>\r\n    ");
#nullable restore
#line 10 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
Write(Html.ActionLink("Cliquer ici pour revenir", "Details", "Vendeurs", new { id = ((Vendeur)ViewBag.Vendeurs).VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 13 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
Write(Html.ActionLink("Cliquer ici pour assigner un telephone", "AjouterTelephone", "TelephoneVendeurs", new { vendeurId = ((Vendeur)ViewBag.Vendeurs).VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Vendeur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
           Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
         foreach (var item in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Vendeur.VendeurNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 37 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
               Write(Html.ActionLink(item.Telephone.TelephoneModel, "Detail", "Telephones", new { idT = item.Telephone.TelephoneId, idV = item.Vendeur.VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { idV = item.Vendeur.VendeurId, idT = item.Telephone.TelephoneId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Amine\Desktop\New folder (6)\VenteMobile\VenteMobile\VenteMobile\Views\TelephoneVendeurs\List.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VenteMobile.Models.TelephoneVendeur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
