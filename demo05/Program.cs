// string message = "Hello World!!";
// string resultado = message.Substring(0, message.Length - 1);


static void OperadoresAritimeticos() {
  int a = 5, b = 10, c = 15, d = 20;

  Console.WriteLine("a + b = " + (a + b));
  Console.WriteLine("a - b = " + (a - b));
  Console.WriteLine("a * b = " + (a * b));
  Console.WriteLine("a / b = " + (a / b));
  Console.WriteLine("a % b = " + (a % b));

  Console.WriteLine(d + b + c);
}

static void OperadoresAritimeticosAtribuicaoReduzidas() {
  int mes = 5;

  mes +=1;
  Console.WriteLine("Mes:" + mes);
  Console.WriteLine("Mes:" + ++mes);
}
OperadoresAritimeticosAtribuicaoReduzidas();