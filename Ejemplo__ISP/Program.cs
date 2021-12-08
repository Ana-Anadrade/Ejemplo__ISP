using System;

namespace Ejemplo__ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            //LLamando a la clase facturaNormal
            FacturaNormal factura = new FacturaNormal(12344, DateTime.Now);
            factura.CAI = ("151712");
            //factura.EnviarPorcorreo();//no es necesario
            factura.Imprimir();
            //LLamando a la clase facturaElectronica
            FacturaElectronica facturaE = new FacturaElectronica(12344, DateTime.Now);
            facturaE.CAE = ("151712");
            facturaE.EnviarPorcorre();
            facturaE.Imprimir();
        }
    }
}
