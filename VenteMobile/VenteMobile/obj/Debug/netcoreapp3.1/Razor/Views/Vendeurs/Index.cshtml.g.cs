#pragma checksum "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0d0eccced7d0e627d7f1fcee456b14db25d0927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendeurs_Index), @"mvc.1.0.view", @"/Views/Vendeurs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0d0eccced7d0e627d7f1fcee456b14db25d0927", @"/Views/Vendeurs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendeurs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VenteMobile.Models.Vendeur>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"text-align:center\"><B> Liste Des Vendeurs</B></h3>\r\n<p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 167, "\"", 195, 1);
#nullable restore
#line 9 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
WriteAttributeValue("", 174, Url.Action("Create"), 174, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n        <span class=\"glyphicon glyphicon-plus\"></span>Ajouter\r\n    </a>\r\n</p>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"text-align:center\">\r\n");
            WriteLiteral("                Nom\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n");
            WriteLiteral("                Address\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n");
            WriteLiteral("                NoTel\r\n            </th>\r\n");
            WriteLiteral("            <th style=\"text-align:center\">\r\n                Opérations\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 41 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VendeurNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VendeurAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.VendeurNoTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
            WriteLiteral("                <td style=\"text-align:center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1897, "\"", 1949, 1);
#nullable restore
#line 53 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
WriteAttributeValue("", 1904, Url.Action("Edit",new {id = item.VendeurId}), 1904, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-edit\"></span>\r\n                    </a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2103, "\"", 2158, 1);
#nullable restore
#line 56 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
WriteAttributeValue("", 2110, Url.Action("Details",new {id = item.VendeurId}), 2110, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-list\"></span>\r\n                    </a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2312, "\"", 2367, 1);
#nullable restore
#line 59 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
WriteAttributeValue("", 2319, Url.Action("Delete", new {id = item.VendeurId}), 2319, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-trash\"></span>\r\n                    </a>\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 65 "C:\Users\Mohamed\Desktop\projetfinalprogavancee\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VenteMobile.Models.Vendeur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
