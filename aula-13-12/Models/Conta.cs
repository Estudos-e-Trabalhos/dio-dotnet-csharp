using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public abstract class Conta // classe abstrata que serve como modelo, sem instancia com serventia apenas para ser herdada
    {
        protected decimal saldo; // protected - protegidos po alterações externas com excessão de suas classes filhas

        public abstract void Creditar(decimal valor); // metodos abtratos não tem estrutura

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é:" + saldo);
        }


    }
}