using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class ContaCorrente

    {

        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo { get; set; }

        public void Sacar(decimal Valor)
        {
            if (saldo >= Valor)
            {
                saldo -= Valor;
                Console.WriteLine("Saque realizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponivel: {saldo}");

        }
    }
}