using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula14
{
    internal class ContaBancaria
    {
        public double saldo;
        public bool credito;
        public bool debito;


        public ContaBancaria(double saldo, bool credito, bool debito)
        {
            this.saldo = saldo;
            this.credito = credito;
            this.debito = debito;
        }


        public void mostra()
        {
            Console.WriteLine($" Saldo:{saldo}, Crédito:{credito}, Débito:{debito} ");
        }





    }  
    




}
