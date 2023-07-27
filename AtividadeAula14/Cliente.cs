using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeAula14
{
    internal class Cliente
    {
        private string nome;
        private string email;
        private string senha;
        public ContaBancaria contaBancaria;


        public Cliente(string nome, string email, string senha, double saldo, bool credito, bool debito)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.contaBancaria = new ContaBancaria(saldo, credito, debito);

        }

        public void mostra()
        {
            Console.WriteLine($"{nome},{email}");
        }


       



    }
}
