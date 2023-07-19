using demo18;

List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(new Pessoa {Id = 1, Nome = "João", Idade = 18});
pessoas.Add(new Pessoa {Id = 2, Nome = "Maria", Idade = 18});
pessoas.Add(new Pessoa {Id = 3, Nome = "José", Idade = 18});
pessoas.Add(new Pessoa {Id = 4, Nome = "Henrique", Idade = 18});
pessoas.Add(new Pessoa {Id = 5, Nome = "Joana", Idade = 18});


pessoas.Insert(2, new Pessoa {Id=6, Nome = "Makengo", Idade = 22 });
foreach(Pessoa p in pessoas)
{
  Console.WriteLine("Id: {0} - Nome: {1} - Idade: {2}", p.Id, p.Nome, p.Idade);

}
