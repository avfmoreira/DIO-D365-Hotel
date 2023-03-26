using DIO_D365_Hotel.Models;

Pessoa p1 = new Pessoa(nome: "Carlos", sobrenome: "de Nobrega");
Pessoa p2 = new Pessoa(nome: "Silvo", sobrenome: "Santos");
//Pessoa p3 = new Pessoa(nome: "Ana Maria", sobrenome: "Braga");

List<Pessoa> hospedes = new List<Pessoa>();

hospedes.Add(p1);
hospedes.Add(p2);
//hospedes.Add(p3);

Suite suiteBasica = new Suite(tipoSuite: "Básica", capacidade: 2, valorDiaria: 75.23M);

Reserva reserva = new Reserva(diasReservados: 12);
reserva.CadastrarSuite(suiteBasica);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"A suite foi reservada para {reserva.ObterQuantidadeHospedes()} hóspedes");
Console.WriteLine($"O valor da diária é {reserva.CalcularValorDiaria():C}");