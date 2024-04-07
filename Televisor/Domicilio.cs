using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor
{
    internal class Domicilio
    {
        private string calle;
        private int numero;
        private string barrio;

        public Domicilio(string calle, int numero, string barrio)
        {
            this.Calle = calle;
            this.Numero = numero;
            this.Barrio = barrio;
        }

        public override string ToString()
        {
            return $"Domicilio: {Calle} {Numero} {Barrio}";
        }

        public string Calle { get => calle; set => calle = value; }
        public int Numero { get => numero; set => numero = value; }
        public string Barrio { get => barrio; set => barrio = value; }
    }
}
