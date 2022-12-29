using ExemplosFundamentos.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Afrain";
pessoa1.Idade = 29;
pessoa1.apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;
DateTime dataAtual = DateTime.Now;
DateTime dataAtualMais5Dias = DateTime.Now.AddDays(5);

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável altura.ToString('0.00'): " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);
Console.WriteLine("Valor da variável dataAtual: " + dataAtual);
Console.WriteLine("Valor da variável dataAtualMais5Dias: " + dataAtualMais5Dias);
Console.WriteLine("Valor da variável dataAtualMais5Dias sem o horário: " + dataAtualMais5Dias.ToString("dd/MM/yyyy"));

//SAIDA

// Olá, meu nome é Afrain, e tenho 29 anos.
// Olá, seja bem vindo
// Valor da variável quantidade: 1
// Valor da variável altura: 1,8
// Valor da variável altura.ToString('0.00'): 1,80
// Valor da variável preco: 1,80
// Valor da variável condicao: True
// Valor da variável dataAtual: 20/12/2022 21:14:46
// Valor da variável dataAtualMais5Dias: 25/12/2022 21:14:46
// Valor da variável dataAtualMais5Dias sem o horário: 25/12/2022


// Operador de atribuição =

int a = 20;
int b = 30;
int c = a + b;
Console.WriteLine("Soma:" + c);
// SAIDA -> Soma:50

// Convertendo tipos de variáveis

// cast - casting
int d = Convert.ToInt32("5"); 
int dd = Convert.ToInt32(null); // Convert aceita valores nulos
Console.WriteLine(dd); // SAIDA: 0

int e = int.Parse("5");
Console.WriteLine(d);

int inteiro = 5;
string f = inteiro.ToString();

int g = 5;
double h = g; // Cast implícito

string i = "5c";
int.TryParse(i, out int j); // Conversão de forma segura!

// Operadores lógicos

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelCompra = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine("Quantidade em estoque: " + quantidadeEmEstoque);
Console.WriteLine("Quantidade compra: " + quantidadeCompra);
Console.WriteLine("Possivel compra: " + possivelCompra);

if (quantidadeCompra == 0)
{
    Console.WriteLine("Quantidade inválida!");
}
else if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Compra realizada com sucesso!");
} 
else 
{
    Console.WriteLine("Produto não possui estoque suficiente! Quantidade em estoque é de: " + quantidadeEmEstoque);
}


// Swicth case

//Console.WriteLine("Informe uma letra: ");
//string entrada = Console.ReadLine();
//string letra = entrada.ToLower();

//switch (letra)
//{
    //case "a":
    //case "e":
    //case "i":
    //case "o":
    //case "u":
    //Console.WriteLine("Vogal!");
    //break;

    //default:
    //Console.WriteLine("Não é vogal!");
    //break;
//}

Calculadora calc = new Calculadora();

calc.Somar(10,12);
calc.Subtrair(10,2);
calc.Multiplicar(10,5);
calc.Dividir(100,5);
calc.Potencia(3,3);


// Tabuada utilizando o For
int numero = 10;
for (int cont = 1; cont <= 10; cont++)
{
    Console.WriteLine(numero + " * " + cont + " = " + (numero * cont));
}

// Tabuada utilizando o While
int contador = 1;
while (contador <= 10)
{
    Console.WriteLine(numero + " * " + contador + " = " + (numero * contador));
    contador++;
}

// do while
int soma = 0, numeroDigitado = 0;
do
{
    Console.WriteLine("Digite um número: ");
    numeroDigitado = Convert.ToInt32(Console.ReadLine());
    soma += numeroDigitado;
} while (numeroDigitado != 0);
Console.WriteLine("Soma: " + soma);
