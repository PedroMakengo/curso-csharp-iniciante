
using demo11;

Console.WriteLine("Digite o primeiro número");
int numero1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o segundo número");
int numero2 = Convert.ToInt32(Console.ReadLine());

int soma = Calculadora.CalcularSoma(numero1, numero2);
int subtracao = Calculadora.CalcularSubtracao(numero1, numero2);
int multiplicacao = Calculadora.CalcularMultiplicacao(numero1, numero2);
int divisao = Calculadora.CalcularDivisao(numero1, numero2);

Console.WriteLine($"A soma total é: {soma}");
Console.WriteLine($"A subtracao total é: {subtracao}");
Console.WriteLine($"A multiplicacao total é: {multiplicacao}");
Console.WriteLine($"A divisao total é: {divisao}");

// Sem retorno
// static void CalcularSoma()
// {
//   int a = 10;
//   int b = 20;

//   int c = a + b;
//   Console.WriteLine(c);
// }


// Com retorno
