float f = 1.0f;

switch(f) 
{
  case 1.0f:
    Console.WriteLine("1.0f");
    break;
  case 2.0f:
    Console.WriteLine("2.0f");
    break;
  case float.NaN:
    Console.WriteLine("float.NaN");
    break;
  default: 
    Console.WriteLine("default");
    break;
}

Console.WriteLine(RetonarEstacaoesDoAnoNovo(DateTime.Now));
Console.WriteLine(RetonarEstacaoesDoAnoNovo(new DateTime(2022, 1, 7)));
Console.WriteLine(RetonarEstacaoesDoAnoNovo(new DateTime(2021, 8, 7)));

// Modelo apartir do C# 7 trabalhar com metodos em linhas
static string RetonarEstacaoesDoAnoNovo(DateTime data) => data.Month switch 
{
  >= 3 and <= 6 => "Outono",
  >= 6 and <= 9 => "Inverno",
  >= 9 and <= 12 => "Primavera",
  12 or (>= 1 and < 3) => "Verão",
  _ => "Erro"
};