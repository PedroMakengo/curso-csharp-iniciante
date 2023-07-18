namespace SaoBento.Dominio;

public class Funcionario: EntidadeBase
{
  public Funcionario(
    string nome, 
    DateTime dataNascimento, 
    string cargo, 
    decimal salario, string departamento
  )  
  {
    Nome = nome;
    DataNascimento = dataNascimento;
    Cargo = cargo;
    Salario = salario;
    Departamento = departamento;
  }

  public string Name { get; private set }
  public DateTime DataNascimento { get; private set }

  // Salário anual para descobrir o mensal basta dividir por 13.3
  public decimal Salario { get; private set }
  public string Cargo { get; private set }

  public string Departamento { get; private set }

  public int idade 
  { 
    get 
    {
      DateTime agora = DateTime.Now;
      int idade = agora.Year - DataNascimento.Year;

      if(agora.DayOfYear < DataNascimento.DayOfYear) {
        idade--;
      }
    } 
  }

  public decimal SalarioAtual { get => Salario * 13.3m; }
}
