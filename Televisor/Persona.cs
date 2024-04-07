using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    internal class Persona
    {
        private string nombre { get; set; }
        private Domicilio domicilio { get; set; }

        public Persona(string nombre, Domicilio domicilio)
        {
            this.nombre = nombre;
            this.domicilio = domicilio;
        }
    }
}
