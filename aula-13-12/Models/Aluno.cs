using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        // sobrescrevendo metodo apresentar da classe pessoa/aplicando polimorfismo
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto.ToUpper()}, e tenho {Idade} anos e sou um aluno nota {Nota}.");

        }
    }
}