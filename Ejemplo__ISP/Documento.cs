using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo__ISP
{
    public abstract class Documento : IImprimir
    {
        public DateTime Fecha { get; set; }
        public int Numeros { get; set; }
        public Documento(int num, DateTime fecha)
        {
            Numeros = num;
            Fecha = fecha;
        }
        public abstract void Imprimir();
        /*public abstract void EnviarPorcorreo();*/
    }
}
