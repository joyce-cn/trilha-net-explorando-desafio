using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");
Pessoa p3 = new Pessoa(nome: "Hóspede 3");
Pessoa p4 = new Pessoa(nome: "Hóspede 4");
Pessoa p5 = new Pessoa(nome: "Hóspede 5");
Pessoa p6 = new Pessoa(nome: "Hóspede 6");
Pessoa p7 = new Pessoa(nome: "Hóspede 7");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);
hospedes.Add(p6);


// Cria a suíte
Suite suiteEconomica = new Suite(tipoSuite: "Econômica", capacidade: 2, valorDiaria: 120);
Suite suiteStandard = new Suite(tipoSuite: "Standard", capacidade: 3, valorDiaria: 180);
Suite suiteLuxo = new Suite(tipoSuite: "Luxo", capacidade: 4, valorDiaria: 300);
Suite suitePremium = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 450);
Suite suiteMaster = new Suite(tipoSuite: "Master", capacidade: 6, valorDiaria: 600);

Console.WriteLine("Escolha uma suíte:");
Console.WriteLine("1 - Econômica");
Console.WriteLine("2 - Standard");
Console.WriteLine("3 - Luxo");
Console.WriteLine("4 - Premium");
Console.WriteLine("5 - Master");

Console.WriteLine("Digite a suíte desejada: ");
string opcao = Console.ReadLine();

Suite suiteEscolhida = null;

switch (opcao)
{
    case "1":
        suiteEscolhida = suiteEconomica;
        break;
    case "2":
        suiteEscolhida = suiteStandard;
        break;
    case "3":
        suiteEscolhida = suiteLuxo;
        break;
    case "4":
        suiteEscolhida = suitePremium;
        break;
    case "5":
        suiteEscolhida = suiteMaster;
        break;
    default:
        Console.WriteLine("Opcão inválida");
        break;
}

if (suiteEscolhida != null)
{
    Console.WriteLine($"Suíte escolhida: {suiteEscolhida.TipoSuite}, Capacidade: {suiteEscolhida.Capacidade}, Diária: R${suiteEscolhida.ValorDiaria}");


    // Cria uma nova reserva, passando a suíte e os hóspedes
    Reserva reserva = new Reserva(diasReservados: 10);
    reserva.CadastrarSuite(suiteEscolhida);
    reserva.CadastrarHospedes(hospedes);

    // Exibe a quantidade de hóspedes e o valor da diária
    Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor da diária: {reserva.CalcularValorDiaria()}");
}
else
{
    Console.WriteLine("Reserva não pode ser concluída por falta de suíte válida.");
}