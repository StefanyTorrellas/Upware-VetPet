using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VetPet.App.Dominio;
using VetPet.App.Persistencia;

namespace VetPet.App.Frontend
{
    public class RemovePropietariosModel : PageModel
    {

        private readonly IRepositorioPropietario repositorioPropietario;
        public Propietario propietario {get; set;}

	      private readonly IRepositorioMascota repositorioMascota;
	      public Mascota mascota {get; set;}

        public RemovePropietariosModel (IRepositorioPropietario repositorioPropietario, IRepositorioMascota repositorioMascota) {
            this.repositorioPropietario = repositorioPropietario;
            this.repositorioMascota = repositorioMascota;	
        }

        public void OnGet(int cedula)
        {
            propietario = repositorioPropietario.getPropietario(cedula);
            mascota = repositorioMascota.getMascotaP(cedula);
        }

        public IActionResult OnPost(Propietario propietario) {
            if (ModelState.IsValid) {
                try {
                    repositorioMascota.removeMascotaP(propietario.cedula);
                    repositorioPropietario.removePropietario(propietario.cedula);
                    return Redirect("/admin/propietarios/list");
                }
                catch (Exception e) {
                    Console.WriteLine(e);
                    return RedirectToPage("/Error");
                }
            }
            else {
                return Page();
            }
        }
    }
}
