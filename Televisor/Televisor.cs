using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Televisor
{
    internal class Televisor
    {
        private string marca {  get; set; }
        private string modelo { get; set; }
        private int cantPulg { get; set; }
        private bool estado { get; set; }
        private int canal { get; set; }

        public Televisor(string marca, string modelo, int cantPulg)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cantPulg = cantPulg;
            estado = false;
            canal = 1;
        }

        public int obtenerCanalActual()
        {
            return canal;
        }

        public bool cambiarCanal(int nuevoCanal) 
        {
            if(nuevoCanal <= 149 && nuevoCanal > 0 && estado) 
            {
                canal = nuevoCanal;
                return true;
            }
            canal = 1;
            return false;
        }
        public bool cambiarCanal()
        {
            if (estado && canal < 149)
            {
                canal++;
                return true;
            }

            canal = 1;

            return false;
        }

        public bool verPrendido()
        {
            return estado;
        }

        public void CambiarEstado()
        {
            estado = !estado;
        }

        public override string ToString()
        {
            return $"Televisor {marca} {modelo} de {cantPulg} pulgadas";
        }
    }
}
