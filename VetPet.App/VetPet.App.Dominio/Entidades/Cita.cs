using System;

namespace VetPet.App.Dominio {

    public class Cita
    {
        public int id {get; set;} 
        public string fecha {get; set;}
        public string hora {get; set;}
        public Mascota mascota {get; set;}
    }
}
