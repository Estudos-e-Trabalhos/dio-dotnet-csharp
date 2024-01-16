// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Globalization;
using aula_13_12.Models;
using Newtonsoft.Json;

// DESERIALIZAÇÃO

// CRIAMOS UMA CLASSE PARA REPRESENTAR O CONTEUDO DO ARQUIVO 

string conteudo = File.ReadAllText("Arquivos/vendas.json");

List<VendaDeserializada>? listVenda = JsonConvert.DeserializeObject<List<VendaDeserializada>>(conteudo);

foreach (var venda in listVenda)
{
    Console.WriteLine(venda);
}

// SERIALIZAÇÃO

DateTime dataAtualVenda = DateTime.Now;

List<Venda> listaVendas = new List<Venda>(); // listando objetos do tipo venda

Venda v1 = new Venda(1, "Material de escritorio", 25.00M, dataAtualVenda);
Venda v2 = new Venda(2, "Licença de software", 110.00M, dataAtualVenda);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);

// IF TERNARIO

int numero = 20;
bool ehPar = false;

ehPar = numero % 2 == 0;

Console.WriteLine($"O {numero} é" + (ehPar ? "par" : "impar"));


// forma covencional
if (numero % 2 == 0)
{
    Console.WriteLine($"O {numero} é par");
}
else
{
    Console.WriteLine($"O {numero} é impar");
}


// Descontrutor

// o descontrutor serve para separar informações do seu objeto

Pessoa ana = new Pessoa("Ana clara", "Silva");

(string nome, string sobrenome) = ana;
Console.WriteLine(nome, sobrenome);

// Declarando tupla

(int Id, string Nome, string Sobrenome) tuplaNico = (18, "Nicole", "Souza");  // forma mais vantajosa de criação, pois permite nomear o atributo
ValueTuple<int, string, string> outraTupla = (18, "Nicole", "Souza"); // segunda forma de declarar uma tupla
var outroExemplo = Tuple.Create(18, "Nicole", "Souza");

Console.WriteLine(tuplaNico.Nome);

// Testando método de retorno de tuplas
LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // desconstrução do objeto

// Ao trabalhar com tuplas podemos faze o descarte de informações que não vamos utilizar, para isso apenas substitua
// no local da informação em questão para o simbolo de _

if (sucesso)
{
    //Console.WriteLine("Quantidade de linhas do arquivo:" + quantidadeLinhas);
    foreach (var linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo");
}

// Dictionary - coleção de dados

Dictionary<string, string> estados = new Dictionary<string, string>(); // garante que elementos sejam unicos de acordo com o primeiro elemento

estados.Add("SP", "São Paulo"); // Não podemos alterar a chave
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["BA"]); // acesso ao valor


foreach (var item in estados)
{
    Console.WriteLine(item.Key, item.Value);
}

estados.Remove("SP");
estados["SP"] = "São Paulo - valor alterado";

string chave = "SP";
if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Chave ja existente{chave}");
}
else
{
    Console.WriteLine($"Chave não existente, é seguro adicionar a chave {chave}");
}

// Pilha - Stack
Stack<int> pilha = new Stack<int>();

pilha.Push(4); // insere um objeto no topo da pilha
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item.ToString());
}

pilha.Pop(); // remove o objeto do topo da pilha e o retorna

// Fila Queue

Queue<int> fila = new Queue<int>();

fila.Enqueue(2); // adiciona elemento no fim da fila
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (var item in fila)
{
    Console.WriteLine(item.ToString());
}

fila.Dequeue(); // removendo primeiro elemento da fila

// Throw

//new ExemploExcecao().Metodo2();


// Fazendo leitura de arquivo txt

try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

    foreach (var linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine(ex.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
finally
{
    // o finally é executado independente de exceções
    // durante o programa ou não
    Console.WriteLine("FIM");
}


// Trabalhando com datas

DateTime data = DateTime.Now;
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm:ss"));
// Existem diferença entre horarios representados com letras maiusculas ou minusculas, o mesmo funciona com datas
// podemos verificar os formatos aceitos

// formatando data e hora
Console.WriteLine(data.ToShortDateString()); // apenas data
Console.WriteLine(data.ToShortTimeString()); // apenas horas

DateTime dataFormat = DateTime.Parse("17/04/2022 18:00"); // converte string para uma data valida

// utilizando tryparse

string dataString = "2022-04-04 18:00";

DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime dataTimer); // recebemos a data que queremos trabalhar
                                                                      // seu formato, sua localização que aqui é independe
                                                                      // e caso ele consiga converter jogara em uma var chamada datetimer

DateTime dataFormatString = DateTime.Parse(dataString); // converte string para uma data valida


// alterando localização do codigosistema

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// convertendo valores monetarios

decimal valorMonetario = 83.40M;

// internamente as represenatacoes de moeda serão pegas do sistema
// ou seja isso pode haver mudanças de acordo com a maquina 
Console.WriteLine($"{valorMonetario:C}");

// alterando a localização da cultura
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// formatações persofinalizadas
Console.WriteLine(valorMonetario.ToString("C1")); // apos o c podemos escolher as casas decimais

// representação de porcentagem

double porcetagem = .3421;
Console.WriteLine(porcetagem.ToString("P"));


// formatação de separadores

double formartNumber = 123456;
Console.WriteLine(formartNumber.ToString("aa-aa-aa"));


// usando construtor
Pessoa p3 = new Pessoa(nome: "Nicole", sobrenome: "Souza");
p3.Idade = 19;
p3.Apresentar();

// normalmente
Pessoa p4 = new Pessoa();
p4.Nome = "Mar";
p4.Sobrenome = "Roberta";
p4.Idade = 21;

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);

cursoDeIngles.ListarAlunos();


// Listas 

// Classe de lista<Tipo da Lista>

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MO");

for (int i = 0; i < listaString.Count; i++)
{
    Console.WriteLine($"o estado é {listaString[i]}");
}

foreach (var listaItem in listaString)
{
    Console.WriteLine($"o estado é {listaItem}");
}

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Cpacidade: {listaString.Capacity}");

listaString.Add("SC");
listaString.Add("RJ");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Cpacidade: {listaString.Capacity}");

listaString.Remove("MO");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Cpacidade: {listaString.Capacity}");


// Arrays e listas

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

// arrayInteiros[3] = 1;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
}

int contadorForeach = 0;
foreach (var inteiro in arrayInteiros)
{
    Console.WriteLine($"Foreach com inteiros {inteiro} - {contadorForeach}");
    contadorForeach++;
}

// Copiando um array para o outro

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// menu interativo com While

bool exibirMenu = false;

while (exibirMenu)
{

    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente ");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    string? opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar de cliente");
            break;

        case "3":
            Console.WriteLine("Apagar de cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false;
            // Environment.Exit(0); - ira encerrar o programa
            break;

        default:
            Console.WriteLine("Opção invalida");
            break;
    }

}

// Estrutura de repetição - DO WHILE
int numeroDoWhile = 0;
int somaDoWhile = 0;

do
{

    Console.WriteLine("Digite um número (0 para parar)");
    numeroDoWhile = Convert.ToInt32(Console.ReadLine());

    somaDoWhile += numeroDoWhile;

} while (numeroDoWhile != 0);

// caso precise debugar o do while mudar tipo de console na pasta vscode
// para "integratedTerminal"
Console.WriteLine($"Total da soma dos números digitados é: {somaDoWhile}");


// Estruturas de repetição - WHILE

int numeroWhile = 5;
int contadorWhile = 0;

while (contadorWhile <= 10)
{
    Console.WriteLine($"{numeroWhile} x {contadorWhile} = {numeroWhile * contadorWhile}");
    contadorWhile++;

    if (contadorWhile == 5)
    {
        break;
    }

}

// Estruturas de repetição - FOR
int numeroFor = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numeroFor} x {contador} = {numeroFor * contador}");
}


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