#pragma checksum "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e8c54ad09b19a6fb0e4b61182b64ed4e564e23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Telephones_Detail), @"mvc.1.0.view", @"/Views/Telephones/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e8c54ad09b19a6fb0e4b61182b64ed4e564e23", @"/Views/Telephones/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Telephones_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VenteMobile.Models.Telephone>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"text-align:center\"><B>Details  ");
#nullable restore
#line 7 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
                                     Write(Html.DisplayFor(model => model.TelephoneModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</B></h3>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Modèle\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TelephoneModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Prix\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TelephoneCout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Couleur\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
       Write(Html.DisplayFor(model => model.TelephoneCouleur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Fabriquant\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Manufacturier.ManufacturierMarque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    <h3 style=\"text-align:center\"><B> Liste Des Critiques</B></h3>\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n");
            WriteLiteral("                    Commentaire\r\n                </th>\r\n                <th>\r\n");
            WriteLiteral("                    Etoiles\r\n                </th>\r\n                <th>\r\n");
            WriteLiteral("                    Client\r\n                </th>\r\n                <th>\r\n");
            WriteLiteral("                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 69 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
             foreach (var item in Model.Critiques)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 73 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CritiqueText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 76 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
                         for (int etoile = 0; etoile < (item.CritiqueEtoiles); etoile++)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"glyphicon glyphicon-star\"></span>\r\n");
#nullable restore
#line 79 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 82 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CritiqueNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("                    </td>\r\n");
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 93 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 100 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Detail.cshtml"
Write(Html.ActionLink("Cliquer ici pour revenir", "List", "TelephoneVendeurs", new { vendeurId = ((Vendeur)ViewBag.Vendeur).VendeurId }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VenteMobile.Models.Telephone> Html { get; private set; }
    }
}
#pragma warning restore 1591
