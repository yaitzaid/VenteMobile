#pragma checksum "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da7ac024436d20aafcc79bf8fa9ccaf3dfcda43"
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
#line 1 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\_ViewImports.cshtml"
using VenteMobile.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da7ac024436d20aafcc79bf8fa9ccaf3dfcda43", @"/Views/Vendeurs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Vendeurs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VenteMobile.Models.Vendeur>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div style=""margin-top:60px; margin-bottom:10px;"">
    <h4 class=""text-center table-bordered alert-success"" style=""border-radius:5px; padding:10px;"">Informations sur le Vendeur</h4>
    <dl class=""dl-horizontal table-bordered jumbotron alert-info "" style=""color:black;"">


        <div>
            <hr />
            <dl class=""row"">
                <dt class=""col-sm-2"">
");
            WriteLiteral("                    Nom\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
               Write(Html.DisplayFor(model => model.VendeurNom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("                    Address\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 28 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
               Write(Html.DisplayFor(model => model.VendeurAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n");
            WriteLiteral("                    NoTel\r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 35 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
               Write(Html.DisplayFor(model => model.VendeurNoTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        \r\n            <p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1373, "\"", 1439, 1);
#nullable restore
#line 40 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
WriteAttributeValue("", 1380, Url.Action("Edit","Vendeurs",new { id = Model.VendeurId }), 1380, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btnStyle\" style=\"background-color:gray; width:120px;\">Edit</a> |\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1537, "\"", 1575, 1);
#nullable restore
#line 41 "C:\Users\Amine\Desktop\New folder (4)\VenteMobile\VenteMobile\VenteMobile\Views\Vendeurs\Details.cshtml"
WriteAttributeValue("", 1544, Url.Action("Index","Vendeurs"), 1544, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btnStyle\" style=\"background-color:cornflowerblue; width:120px;\">Retour</a>\r\n\r\n            </p>\r\n       \r\n          \r\n</div>\r\n");
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
