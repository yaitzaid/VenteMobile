#pragma checksum "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7ba33ea160bc112eb2e119d8b6a9de333a35df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendeurs_Details), @"mvc.1.0.view", @"/Views/Vendeurs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7ba33ea160bc112eb2e119d8b6a9de333a35df", @"/Views/Vendeurs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendeurs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VenteMobile.Models.Vendeur>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Nom\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendeurNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            Address\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendeurAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("            NoTel\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.VendeurNoTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            La liste des Manifacturier\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
       Write(Html.ActionLink("Cliquer ici pour afficher la liste des manifacturier", "List", "VendeurManufacturiers", new { vendeurId = Model.VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            La liste des Telephones\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
       Write(Html.ActionLink("Cliquer ici pour afficher la liste des Telephones", "List", "TelephoneVendeurs", new { vendeurId = Model.VendeurId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1787, 1);
#nullable restore
#line 52 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
WriteAttributeValue("", 1728, Url.Action("Edit","Vendeurs",new { id = Model.VendeurId }), 1728, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btnStyle\" style=\"background-color:gray; width:120px;\">Edit</a> |\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1877, "\"", 1915, 1);
#nullable restore
#line 53 "C:\Users\Youness\Pictures\Projet_VF\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
WriteAttributeValue("", 1884, Url.Action("Index","Vendeurs"), 1884, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btnStyle\" style=\"background-color:cornflowerblue; width:120px;\">Retour</a>\r\n\r\n    </p>\r\n\r\n\r\n</div>\r\n");
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
