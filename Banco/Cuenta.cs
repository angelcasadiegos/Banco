using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public abstract class Cuenta
    {
        public decimal Saldo { get; set; }
        private List<Movimiento> movimientos { get; set; }


        public Cuenta(decimal saldo)
        {
            Saldo = saldo;
            movimientos = new List<Movimiento>();
        }

        public abstract string Consignar(decimal valor);


        public abstract string Retirar(decimal valor);
        
           

        
        
        public string ConsultarSaldo()
        {
            return $"su saldo es {Saldo}";
        }
        public  void AgregarMovimiento(string tipoTransaccion, decimal valor, string tipoCuenta)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = DateTime.Now;
            movimiento.Valor = valor;
            movimiento.TipoTransaccion = tipoTransaccion;
            movimiento.Saldo = Saldo;
            movimiento.TipoCuenta = tipoCuenta;
            movimientos.Add(movimiento);
        }

        public string ConsultarMovimientos()
        {
            string listaMovimientos = "";
            foreach (var item in movimientos)
            {
                listaMovimientos += ("\nResumen de Movimientos\n"+item.Fecha + "\n"+ item.TipoCuenta+ "\n"+ item.TipoTransaccion +"\n"+
                    item.Valor +"\n"+ item.Saldo) + "\n";
            }

            return listaMovimientos;

        }

    }
}
