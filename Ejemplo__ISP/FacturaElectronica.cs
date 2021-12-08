using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo__ISP
{

    public class FacturaElectronica : Documento, IEnviar
    {
        public FacturaElectronica(int num, DateTime fecha) : base(num, fecha) { }
        public string CAE { get; set; }

        public void EnviarPorcorre()
        {
            Console.WriteLine($" Enviando por correo\n factura electronica \n numero {Numeros} \n fecha y hora {Fecha} \n CAE {CAE}");
        }
        /*public override void EnviarPorcorreo()
        {
            Console.WriteLine($" Enviando por correo\n factura electronica \n numero {Numeros} \n fecha y hora {Fecha} \n CAE {CAE}");
        }*/
        public override void Imprimir()
        {
            Console.WriteLine($" Imprimiendo\n factura electronica \n numero {Numeros} \n fecha y hora {Fecha} \n CAE {CAE}");
        }
    }
}
