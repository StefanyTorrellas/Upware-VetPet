#pragma checksum "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be386124902ea20235d1fa1fc79b1f9cf303c64"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetPet.App.Frontend.Pages.Admin.Propietarios.Pages_Admin_Propietarios_DetailPropietarios), @"mvc.1.0.razor-page", @"/Pages/Admin/Propietarios/DetailPropietarios.cshtml")]
namespace VetPet.App.Frontend.Pages.Admin.Propietarios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/propietarios/detail")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be386124902ea20235d1fa1fc79b1f9cf303c64", @"/Pages/Admin/Propietarios/DetailPropietarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d7a196cfb9db79444ac7303b3e1fba71aff380", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Propietarios_DetailPropietarios : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Sistema de clínica veterinaría";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<a class=\"h1\" data-toggle=\"tooltip\" data-placement=\"right\" title=\"En está pagina podrás ver los detalles del propietario.\">");
#nullable restore
#line 8 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
                                                                                                                      Write(Model.propietario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
                                                                                                                                                Write(Model.propietario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n<ul>\n    <li>Cedula: ");
#nullable restore
#line 10 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
           Write(Model.propietario.cedula);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Nombre: ");
#nullable restore
#line 11 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
           Write(Model.propietario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Apellido: ");
#nullable restore
#line 12 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
             Write(Model.propietario.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Edad: ");
#nullable restore
#line 13 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
         Write(Model.propietario.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Genero: ");
#nullable restore
#line 14 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
           Write(Model.propietario.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Ciudad: ");
#nullable restore
#line 15 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
           Write(Model.propietario.ciudad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n    <li>Dirección: ");
#nullable restore
#line 16 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Propietarios/DetailPropietarios.cshtml"
              Write(Model.propietario.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetPet.App.Frontend.DetailPropietariosModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.DetailPropietariosModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.DetailPropietariosModel>)PageContext?.ViewData;
        public VetPet.App.Frontend.DetailPropietariosModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
