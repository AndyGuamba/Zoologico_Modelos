using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoologico_Modelos
{
    public class Animal
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        //FKW
        public int EspecieCodigo { get; set; }
        public int RazaId { get; set; }

        //Navegacion    
        public Especie? Especie { get; set; }
        public Raza? Raza { get; set; }
    }
}
