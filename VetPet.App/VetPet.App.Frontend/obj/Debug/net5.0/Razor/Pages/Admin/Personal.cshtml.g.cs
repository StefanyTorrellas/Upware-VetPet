#pragma checksum "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Personal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b485cffdf60162c7f3c4482233e1ace602a3107d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetPet.App.Frontend.Pages.Admin.Pages_Admin_Personal), @"mvc.1.0.razor-page", @"/Pages/Admin/Personal.cshtml")]
namespace VetPet.App.Frontend.Pages.Admin
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/personal")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b485cffdf60162c7f3c4482233e1ace602a3107d", @"/Pages/Admin/Personal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d7a196cfb9db79444ac7303b3e1fba71aff380", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Personal : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Personal.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Sistema de clínica veterinaría";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Personal</h1>
    <p>Acá podrás encontrar el personal actual de VetPet</p>
    <a class=""btn btn-success"" href=""/admin/veterinarios/list"">Veterinarios</a>
    <a class=""btn btn-info"" href=""/admin/gestion/"">Gestión</a>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetPet.App.Frontend.PersonalModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.PersonalModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.PersonalModel>)PageContext?.ViewData;
        public VetPet.App.Frontend.PersonalModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
