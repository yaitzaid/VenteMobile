#pragma checksum "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ebdb7c063c480fa98d067357c5c7732f753443"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Telephones_Index), @"mvc.1.0.view", @"/Views/Telephones/Index.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
using PagedList.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
using PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ebdb7c063c480fa98d067357c5c7732f753443", @"/Views/Telephones/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a97ff0ef11d197b60ccbf445710a0d5ee171efb6", @"/Views/_ViewImports.cshtml")]
    public class Views_Telephones_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.IPagedList<VenteMobile.Models.Telephone>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container jumbotron alert-success text-center table-bordered\" style=\"position:relative ; top:50px; z-index:100; border-color:black;\">\r\n    <h3 style=\"text-align:center\"><B> Liste Des Téléphones</B></h3>\r\n    <p>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 383, "\"", 411, 1);
#nullable restore
#line 13 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
WriteAttributeValue("", 390, Url.Action("Create"), 390, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n            <span class=\"glyphicon glyphicon-plus\"></span>Ajouter\r\n        </a>\r\n    </p>\r\n</div>\r\n\r\n<div class=\"row container form-inline\">\r\n    <div class=\"pull-right input-group\" style=\"margin-top:22px;\">\r\n");
#nullable restore
#line 21 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
         using (Html.BeginForm("Index", "Telephones", FormMethod.Get))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
       Write(Html.TextBox("searchString", ViewBag.currentFilter as string, new
            {
                @class = "form-control",
                @placeholder = "Rechercher"
            }));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button type=\"submit\" class=\"btn input-group-addon\"><i class=\"glyphicon glyphicon-search\" style=\"padding:3px;\"></i></button>\r\n");
#nullable restore
#line 31 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row container form-inline\">\r\n    <span class=\"input-group \">Page ");
#nullable restore
#line 36 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
                                Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" de ");
#nullable restore
#line 36 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
                                                                                               Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</div>\r\n\r\n");
#nullable restore
#line 39 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert-danger  jumbotron conainter table-bordered text-center\" style=\"margin-top:60px; margin-bottom:10px;\">\r\n        Aucun telephone disponible avec le filtre n\'a &eacute;t&eacute; utilis&eacute;\r\n    </div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1542, "\"", 1582, 1);
#nullable restore
#line 44 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
WriteAttributeValue("", 1549, Url.Action("Index","Telephones"), 1549, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn  btnStyle\" style=\"background-color:cornflowerblue; width:120px;\">Back to List</a>\r\n");
#nullable restore
#line 45 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"

    return;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th style=\"text-align:center\">\r\n                ");
#nullable restore
#line 53 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
           Write(Html.ActionLink("Model", "Index", new { sortOrder = ViewBag.NomSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n                ");
#nullable restore
#line 57 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
           Write(Html.ActionLink("Prix", "Index", new { sortOrder = ViewBag.NomSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n                ");
#nullable restore
#line 61 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
           Write(Html.ActionLink("Couleur", "Index", new { sortOrder = ViewBag.NomSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n                ");
#nullable restore
#line 65 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
           Write(Html.ActionLink("Fabricant", "Index", new { sortOrder = ViewBag.NomSortParm }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </th>\r\n            <th style=\"text-align:center\">\r\n                Opérations\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 74 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TelephoneModel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 81 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TelephoneCout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 84 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TelephoneCouleur));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n                    ");
#nullable restore
#line 87 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Manufacturier.ManufacturierMarque));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td style=\"text-align:center\">\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3355, "\"", 3409, 1);
#nullable restore
#line 91 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
WriteAttributeValue("", 3362, Url.Action("Edit",new {id = item.TelephoneId}), 3362, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-edit\"></span>\r\n                    </a> |\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3563, "\"", 3620, 1);
#nullable restore
#line 94 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
WriteAttributeValue("", 3570, Url.Action("Details",new {id = item.TelephoneId}), 3570, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-list\"></span>\r\n                    </a> |\r\n");
            WriteLiteral("                    <a");
            BeginWriteAttribute("href", " href=\"", 3965, "\"", 4022, 1);
#nullable restore
#line 99 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
WriteAttributeValue("", 3972, Url.Action("Delete", new {id = item.TelephoneId}), 3972, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info btn-lg\">\r\n                        <span class=\"glyphicon glyphicon-trash\"></span>\r\n                    </a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Youness\Desktop\C sharp\ProjetFinal\VenteMobile\VenteMobile\VenteMobile\Views\Telephones\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.IPagedList<VenteMobile.Models.Telephone>> Html { get; private set; }
    }
}
#pragma warning restore 1591
