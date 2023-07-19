// Pasandos valores para métodos 

// int numero1 = 10;
// int numero2 = 20;

// Console.WriteLine(SomarNumeros(numero1, numero2));

// static int SomarNumeros (int numero1, int numero2) 
// {
//   numero2 += 10;
//   int resultado = numero1 + numero2;
//   return resultado;
// }


// int numero1Ref = 10;
// int numero2Ref = 20;

// SomarNumerosRef(numero1Ref, ref numero2Ref);
// Console.WriteLine(numero2Ref);

// static void SomarNumerosRef(int numero1, ref int numero2)
// {
//   numero2 += 10;
//   int resultado = numero1 + numero2;
//   Console.WriteLine(resultado);
// }

int numero1Out = 10;
int numero2Out = 20;

int resultado = SomarNumerosComOut(numero1Out, out numero2Out);
Console.WriteLine ($"Resultado soma out {resultado}");

static int SomarNumerosComOut(int numero1Out, out int numero2Out) 
{
  numero2Out = 30;
  int resultado = numero1Out + numero2Out;

  return resultado;
}




ParametroComIn(10, 20);
static void ParametroComIn(int numero1, in int numero2)
{
  numero2 = 10; // Sempre que atribuir com in será sempre variavel de leitura.
  int resultado = numero1 + numero2;
  Console.WriteLine(resultado);
}