// See https://aka.ms/new-console-template for more information
using aula_13_12.Models;


// Incremento e Decremento

int numeroIncremento = 10;
int numeroDecremento = 10;
Console.WriteLine(numeroIncremento);
Console.WriteLine(numeroDecremento);

//numero = numero + 1;
numeroIncremento++;
numeroDecremento--;

Console.WriteLine(numeroIncremento);
Console.WriteLine(numeroDecremento);


// usando a classe calculadora

Calculadora calcu = new Calculadora();

calcu.Somar(2, 8);
calcu.Potencia(3, 3);
calcu.Seno(30);
calcu.Coseno(30);
calcu.Tangente(30);

calcu.RaizQuadrada(9);

// operador NOT - !

bool choveu = false;
bool estaTarde = false;

// caso ele espere true e esteja o sinal de negação ele espera false
// caso esteja false eles irão esperar true
if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar");
}
else
{
    Console.WriteLine("Vou pedalar outro dia");

}

// operador AND && - mais restritivo

bool represencaMinima = false;
double media = 7.5;

if (represencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}

// operador OR ||
bool ehMaiorDeIdade = false;
bool possuiAutirizacaoDoResponsavel = true;

if (ehMaiorDeIdade || possuiAutirizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada");

}
else
{
    Console.WriteLine("Entrada não liberada");
}

// switch case

Console.WriteLine("Digite uma letra");

string? letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma Vogal");
        break;
}

if (letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u"
)
{
    Console.WriteLine("vogal");

}
else
{
    Console.WriteLine("Não é uma vogal");

}

// Operador condicional 

int quantidadeEmEstoque = 10;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra; // operador ternario

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade Compra: {quantidadeCompra}");
Console.WriteLine($"é possivel realizar venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda invalida");
}
else if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada");
    quantidadeEmEstoque = quantidadeEmEstoque -= quantidadeCompra;
    Console.WriteLine($"Quantidade de estoque restante: {quantidadeEmEstoque}");

}
else
{
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