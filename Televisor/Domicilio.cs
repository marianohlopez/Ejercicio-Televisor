using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    internal class Domicilio
    {
        private string calle {  get; set; }
        private int numero { get; set; }
        private string barrio { get; set; }

        public Domicilio(string calle, int numero, string barrio)
        {
            this.calle = calle;
            this.numero = numero;
            this.barrio = barrio;
        }

    }
}
