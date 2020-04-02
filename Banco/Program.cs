using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Cuenta Ahorro*/
           
            Cuenta cuentaAhorro = new CuentaAhorro(1000000);
           
            Console.WriteLine(cuentaAhorro.Retirar(2000000));
            Console.WriteLine(cuentaAhorro.Consignar(500000));
            Console.WriteLine(cuentaAhorro.Retirar(1000000));            
            Console.WriteLine(cuentaAhorro.ConsultarMovimientos());

            /* Cuenta Corriente */

            Cuenta cuentaCorriente = new CuentaCorriente(1000000);

            Console.WriteLine(cuentaCorriente.Consignar(100000));           
            Console.WriteLine(cuentaCorriente.Retirar(20000));
            Console.WriteLine(cuentaCorriente.Consignar(100000));
            Console.WriteLine(cuentaCorriente.ConsultarSaldo());
            Console.WriteLine(cuentaCorriente.ConsultarMovimientos());

            Console.ReadKey();
        }
    }
}
