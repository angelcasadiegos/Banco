using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class CuentaCorriente : Cuenta
    {
        public CuentaCorriente(decimal saldo) : base(saldo) { }

        public override string Consignar(decimal valor)
        {

            if (Saldo < 1000000 && valor <= 1000000)
            {
                this.Saldo -= valor;
                AgregarMovimiento("Consignar", valor,"Cuenta Corriente");
                return $"Se consigno {valor} su nuevo saldo es {Saldo}";
            }else if(valor < 0)
              return $"No es posible consignar un valor negativo"; 

            return $"No es posible consignar. Su Cupo";
        }

        public override string Retirar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo += valor;
                AgregarMovimiento("Retirar", valor, "Cuenta Corriente");
                return $"Se retiro {valor} su nuevo saldo es {Saldo}";
            }

            return $"Saldo insuficiente, su saldo es {Saldo}";
        }
    }
}
