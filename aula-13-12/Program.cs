// See https://aka.ms/new-console-template for more information
using aula_13_12.Models;

Console.WriteLine("Hello, World!");

Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Nicole";
pessoa1.Idade = 18;
pessoa1.Apresentar();

pessoa1.Nome = "Mar";
pessoa1.Idade = 21;
pessoa1.Apresentar();