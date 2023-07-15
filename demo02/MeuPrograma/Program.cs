string meuNome = "Pedro Makengo";
string seuNome = "Antónia Vicente";

// string concatenacao1 = ("Olá " + meuNome).ToUpper();
// string concatenacao5 = ("Olá " + meuNome).ToLower();
// Console.WriteLine(concatenacao1);

// string concatenacao2 = string.concat("Olá", meuNome, "!");
// string concatenacao3 = $"Olá {meuNome}!";
// string concatenacao4 = string.format("Olá {0} !", meuNome);



System.Text.StringBuilder sb = new System.Text.StringBuilder();
sb.Append("Olá")
.Append(meuNome)
.Append(" !");

// sb.ToString();

// string[] carros = new string[] {"Fusca", "Gol", "Palio", "Vectra", "Kicks"};

// foreach(string carro in carros) {

//   if(carro == "Fusca") {
//     Console.WriteLine(carro.Substring(0, 2));
//     return;
//   }
// }


string desafio = "Desafio seu nome ! A remover o último caracter !!!";
int totalCaracteres = desafio.Length - 1;
string desafioRestante = desafio.Substring(0, totalCaracteres);

Console.WriteLine(desafioRestante);

