#pragma checksum "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Login/Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71cfab7e20548d053427167b4e2ae82e794f63d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(VetPet.App.Frontend.Pages.Login.Pages_Login_Login), @"mvc.1.0.razor-page", @"/Pages/Login/Login.cshtml")]
namespace VetPet.App.Frontend.Pages.Login
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71cfab7e20548d053427167b4e2ae82e794f63d0", @"/Pages/Login/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d7a196cfb9db79444ac7303b3e1fba71aff380", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/mc107/Documents/Study/mintic/Upware-VetPet/VetPet.App/VetPet.App.Frontend/Pages/Login/Login.cshtml"
  
    ViewData["Title"] = "Log in ";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n     <h1 class=\"display-4\">Bienvenidos!</h1>\n     <p>Sistema de autenticación.</p>\n </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetPet.App.Frontend.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<VetPet.App.Frontend.Pages.LoginModel>)PageContext?.ViewData;
        public VetPet.App.Frontend.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
