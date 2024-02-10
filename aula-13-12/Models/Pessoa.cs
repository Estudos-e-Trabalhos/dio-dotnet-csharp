using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula_13_12.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public void Deconstruct(out string nome, out string sobrenome)
        {
            // aqui fazemos a operação inversa de cima, onde out é uma propriedade de saida
            // onde o nome vai sair com o valor de Nome e sobrenome sai com o valor de Sobrenome
            nome = Nome;
            sobrenome = Sobrenome;
        }

        private string _nome;
        private int _idade;
        public string Nome
        {
            // validações de retorno, todo retorno
            // efetivamente feito
            get => _nome; // body expression
                
            // validção de set - caso seja facil é jogado uma excessão
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public int Idade { 

            get => _idade;
            
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }

                _idade = value;
            }
            
            }

        public virtual void Apresentar()
        // o virtual significa que ele esta habito para aplicar polimorfismo/ser sobrescrito
        {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto.ToUpper()}, e tenho {Idade} anos.");
        }
    }
}