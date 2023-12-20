// See https://aka.ms/new-console-template for more information
using aula_13_12.Models;

Console.WriteLine("Hello, World!");

// Operador condicional 

int quantidadeEmEstoque = 10;

int quantidadeCompra = 4;

if(quantidadeEmEstoque >= quantidadeCompra){
    Console.WriteLine("Venda realizada");
} else {
    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");

}

 
// Convertendo de forma segura

string aNumber = "15";

int bNumber = 0;

int.TryParse(aNumber, out bNumber); // no tryparse caso ele consiga converter ele joga o valor de saida para o b, não sendo as certeza que irá ser convertido, mas não para o programa.
Console.WriteLine("Conversão realizada!");
Console.WriteLine(bNumber);


// Tipos de operadores

double calc = 4 / 2 + 4;

Console.WriteLine(calc);

// Casting Implicito

int castingNumber = 5;
double castingDouble = castingNumber; // um inteiro cabe no double (pode suportar valores inteiros, o mesmo funcionaria para long) sendo possivel o casting (conversão)

Console.WriteLine(castingDouble);


// Convertendo tipos de variaveis - casting - STRING

int stringNumber = 5;
string NumberToString = stringNumber.ToString();

Console.WriteLine(NumberToString);


// Convertendo tipos de variaveis - casting - INT

int number = Convert.ToInt32("5"); // int32 usado especificamente apra valores inteiros
int numberParse = int.Parse("5"); // 

Console.WriteLine(number);
Console.WriteLine(numberParse);

// a diferença de ambos é o tratamento de valores nulos, onde o Convert devolve o valor 0
// e o parse retorna um erro relatando que o valor não pode ser nulo

// atribução
int a = 10;
int b = 20;

int c = a + b;

c += 5; // atribuição composta em variavel já existente

Console.WriteLine(c);

// datatime
DateTime dataAtual = DateTime.Now.AddDays(5);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

// tipos
string apresentacao = "Hello";
int quantidadeNumber = 10;
double altura = 1.80;
decimal preco = 1.80M;


// classe pessoa
Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Nicole";
pessoa1.Idade = 18;
pessoa1.Apresentar();

pessoa1.Nome = "Mar";
pessoa1.Idade = 21;
pessoa1.Apresentar();