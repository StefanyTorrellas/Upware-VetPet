#pragma checksum "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2636e09943e217c1108d3750e55d531fb62a34db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetPet.App.Frontend.Pages.Admin.Citas.Pages_Admin_Citas_ListCitas), @"mvc.1.0.razor-page", @"/Pages/Admin/Citas/ListCitas.cshtml")]
namespace VetPet.App.Frontend.Pages.Admin.Citas
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
#line 3 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
using VetPet.App.Dominio;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/citas/list")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2636e09943e217c1108d3750e55d531fb62a34db", @"/Pages/Admin/Citas/ListCitas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d7a196cfb9db79444ac7303b3e1fba71aff380", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Citas_ListCitas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/Citas/AddCitas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
  
    Layout = "_AdminLayout";
    ViewData["Title"] = "Sistema de clínica veterinaría";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Gestionar citas</h1>\n<p class=\"text-left\">Aquí podrás gestionar tus citas</p>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2636e09943e217c1108d3750e55d531fb62a34db4357", async() => {
                WriteLiteral("Añadir Cita");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<table class=\"table table-dark\">\n    <thead>\n        <tr>\n            <th>Mascota</th>\n            <th>Veterinario</th>\n            <th>Día</th>\n            <th>Hora</th>\n            <th>Descripción</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 22 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
         foreach(var cita in Model.citas){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
               Write(cita.mascota.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
               Write(cita.veterinario.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
               Write(cita.dia.ToString("yyyy-MM-dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
               Write(cita.hora.ToString("hh:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
               Write(cita.descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 30 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Admin/Citas/ListCitas.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetPet.App.Frontend.ListCitasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.ListCitasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.ListCitasModel>)PageContext?.ViewData;
        public VetPet.App.Frontend.ListCitasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
