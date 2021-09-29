#pragma checksum "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65afc9e9b67312303146115e39a9099ad87f5f34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetPet.App.Frontend.Pages.Admin.Mascotas.Pages_Admin_Mascotas_ListMascotas), @"mvc.1.0.razor-page", @"/Pages/Admin/Mascotas/ListMascotas.cshtml")]
namespace VetPet.App.Frontend.Pages.Admin.Mascotas
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
#line 1 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/_ViewImports.cshtml"
using VetPet.App.Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
using VetPet.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/mascotas/list")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65afc9e9b67312303146115e39a9099ad87f5f34", @"/Pages/Admin/Mascotas/ListMascotas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d7a196cfb9db79444ac7303b3e1fba71aff380", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Mascotas_ListMascotas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Sistema de clínica veterinaría";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<a class=""h1"" data-toggle=""tooltip"" data-placement=""right"" title=""En está pagina podrás gestionar las mascotas"">Gestionar Mascotas</a>
<br>
<div class=""mt-sm-4"">
<a class=""btn btn-primary table-btn"" href=""/admin/mascotas/add"">Agregar mascotas</a>
<div class=""table-responsive"">
<table class=""table table-hover"">
    <thead class=""thead-dark"">
        <tr>
        <th scope=""col"">Tipo</th>
        <th scope=""col"">Nombre</th>
        <th scope=""col"">Edad</th>
        <th scope=""col"">Descripción</th>
        <th scope=""col"">Dueño</th>
	    	<th scope=""col"">Gestión</th>
        </tr>
    </thead>
");
#nullable restore
#line 24 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
     foreach(var mascota in Model.mascotas) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\n        <td>");
#nullable restore
#line 26 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
       Write(mascota.tipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 27 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
       Write(mascota.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
       Write(mascota.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
       Write(mascota.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 30 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
             if(mascota.propietario == null) {

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                         Write(Model.message);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                                            } 
            else {

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
             Write(mascota.propietario.nombre);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                             ; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                          Write(Model.space);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                                           ; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                                        Write(mascota.propietario.apellido);

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
                                                                                          ;}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        <td>
            <a class=""btn btn-info table-btn"" href=""/admin/propietarios/detail""><i class=""fa fa-info-circle""></i></a>
            <a class=""btn btn-success table-btn"" href=""/admin/propietarios/edit""><i class=""fa fa-edit""></i></a>
            <a class=""btn btn-danger table-btn"" href=""/admin/propietarios/delete""><i class='fa fa-trash'></i></a>
        </td>
    </tr>
");
#nullable restore
#line 38 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Mascotas/ListMascotas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </table>\n</div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetPet.App.Frontend.ListMascotasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.ListMascotasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.ListMascotasModel>)PageContext?.ViewData;
        public VetPet.App.Frontend.ListMascotasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
