using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaAhorro : Cuenta
    {


        public CuentaAhorro(decimal saldo) : base(saldo)
        {

        }
        public override string Consignar(decimal valor)
        {
            
           if (valor > 0)
                {
                this.Saldo += valor;
                AgregarMovimiento("Consignar", valor,"Cuenta Ahorro");
                return $"Se consigno {valor} su nuevo saldo es {Saldo}";
           }
                return $"No es posible consignar un valor negativo";
        }

        public override string Retirar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                AgregarMovimiento("Retirar", valor,"Cuenta Ahorro");
                return $"Se retiro {valor} su nuevo saldo es {Saldo}";
            }

            return $"Saldo insuficiente, su saldo es {Saldo}";
        }


    }
}
