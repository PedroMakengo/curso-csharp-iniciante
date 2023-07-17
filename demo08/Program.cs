
DateTime startTime = new DateTime(1997, 7, 7);
// Conversação de tipo
// Tipo de conversão
Console.WriteLine("Digite a sua idade");
int idade = Convert.ToInt32(Console.ReadLine());

if(idade >= 18) {
  Console.WriteLine("Maior de idade");
}else {
  Console.WriteLine("Menor");
}