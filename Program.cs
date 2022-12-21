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

