using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto.ToUpper()}, e tenho {Idade} anos e sou um professor e ganho {Salario}.");

        }
    }
}