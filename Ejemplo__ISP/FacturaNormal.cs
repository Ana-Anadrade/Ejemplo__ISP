using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo__ISP
{
    public class FacturaNormal : Documento
    {
        public FacturaNormal(int Numeros, DateTime Fecha) : base(Numeros, Fecha) { }
        public string CAI { get; set; }
        /*public override void EnviarPorcorreo()
        {
            //Este metodo no se usa 
        }*/
        public override void Imprimir()
        {
            Console.WriteLine($" Imprimiendo \n factura normal \n numero {Numeros} \n fecha y hora {Fecha} \n CAI {CAI}");
        }
    }
}
