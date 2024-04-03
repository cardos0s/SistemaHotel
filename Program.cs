using SistemaHotel;

internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Bem vindo ao hotel x: ");
        Hospede hospede = new Hospede();
        Console.WriteLine("Digite seu nome para a reserva:");
        hospede.Nome = Console.ReadLine();
        Console.WriteLine("Digite seu CPF para a reserva:");
        hospede.Cpf = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua idade para a reserva:");
        hospede.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("========================");


        Suite suite = new Suite(100,101);
        DateTime dataInicio = DateTime.Today;
        DateTime dataFim = DateTime.Today.AddDays(15);

        Rserva reserva = new Rserva(hospede, suite, dataInicio, dataFim);
        Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal():C}");

        Console.WriteLine("========================");

        Console.WriteLine("Reserva:");

        Console.WriteLine("=======================");

        Console.WriteLine($"Hóspede: {reserva.Hospede.Nome}");
        Console.WriteLine($"Suíte: {reserva.Suite.Numero}");
        Console.WriteLine($"Data de início: {reserva.DataInicio.ToShortDateString()}");
        Console.WriteLine($"Data de fim: {reserva.DataFim.ToShortDateString()}");
        Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal():C}");

        Console.ReadLine();
    }
}