using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    internal class Persona
    {
        private string nombre;
        private Domicilio domicilio;

        public Persona(string nombre, Domicilio domicilio)
        {
            this.Nombre = nombre;
            this.Domicilio = domicilio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal Domicilio Domicilio { get => domicilio; set => domicilio = value; }
    }
}
