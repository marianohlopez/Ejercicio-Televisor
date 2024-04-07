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
        private string marca;
        private string modelo;
        private int cantPulg;
        private bool estado;
        private int canal;

        public Televisor(string marca, string modelo, int cantPulg)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cantPulg = cantPulg;
            Estado = false;
            Canal = 1;
        }

        public int obtenerCanalActual()
        {
            return Canal;
        }

        public bool cambiarCanal(int nuevoCanal) 
        {
            if(nuevoCanal <= 149 && nuevoCanal > 0 && Estado) 
            {
                Canal = nuevoCanal;
                return true;
            }
            Canal = 1;
            return false;
        }
        public bool cambiarCanal()
        {
            if (Estado && Canal < 149)
            {
                Canal++;
                return true;
            }

            Canal = 1;

            return false;
        }

        public bool verPrendido()
        {
            return Estado;
        }

        public void CambiarEstado()
        {
            Estado = !Estado;
        }

        public override string ToString()
        {
            return $"Televisor {Marca} {Modelo} de {CantPulg} pulgadas";
        }

        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int CantPulg { get => cantPulg; set => cantPulg = value; }
        public bool Estado { get => estado; set => estado = value; }
        public int Canal { get => canal; set => canal = value; }
    }
}
