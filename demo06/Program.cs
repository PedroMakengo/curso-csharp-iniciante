DateTimeExemplo();

static void DateTimeExemplo()
{
  DateTime dataInicio = new DateTime(2019, 10, 01); // Data
  DateTime hoje = DateTime.Today; // Hoje
  DateTime agora = DateTime.Now; // Agora

  // Console.WriteLine("Data de Início " + dataInicio.ToString("dd/MM/yyyy HH:mm:ss"));
  // Console.WriteLine("" + hoje);


  DayOfWeek diaDaSemana = hoje.DayOfWeek;
  Console.WriteLine("Dia da semana " + diaDaSemana);

  // DateTime dataFim = hoje.AddDays(10);
  // Console.WriteLine("Data de Fim " + dataFim.ToString("dd/MM/yyyy HH:mm:ss"));

  // bool ehorarioVeracao = agora.IsDaylightSavingTime();

  // DateOnly dateOnly = new DateOnly(2023, 19, 02);

  // DateOnly dateOnlyFromDateNow = DateOnly.FromDateTime(DateTime.Now);

  // DateTime horaEntrada  = DateTime.Now; 
  // Console.WriteLine("Hora de Entrada" + horaEntrada);
  // TimeSpan horarioTrabalho = new TimeSpan(8, 0, 0);
  // DateTime horaSaida = horaEntrada.Add(horarioTrabalho);
  // Console.WriteLine("Hora de Saída " + horaSaida);

  // TimeOnly horaEntradaTimeOnly = new TimeOnly(22, 19, 24);
  // Console.WriteLine("Hora de entrada " + horaEntradaTimeOnly);
}