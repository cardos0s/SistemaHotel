# Reserva de Hotel

Este é um programa simples em C# que modela a reserva de um hotel. Ele inclui classes para representar um hóspede (`Pessoa`), uma suíte (`Suite`) e uma reserva (`Reserva`). A classe `Reserva` é capaz de calcular o valor total da reserva e aplicar um desconto de 10% para reservas com mais de 10 dias.

Este código foi proposto como parte do curso da DIO.ME (Digital Innovation One) como um exemplo básico de modelagem de classes em C#.

## Funcionalidades

- Representa um hóspede e uma suíte de hotel.
- Calcula o valor total de uma reserva.
- Aplica um desconto de 10% para reservas com mais de 10 dias.

## Como usar

Para usar este código, basta instanciar objetos das classes `Pessoa`, `Suite` e `Reserva`, fornecendo os parâmetros necessários. Em seguida, você pode chamar os métodos da classe `Reserva` para calcular o valor total da reserva e outras funcionalidades.

Exemplo de uso:

```csharp
// Instanciando uma pessoa


// Instanciando uma suíte


// Definindo datas de início e fim da reserva


// Instanciando uma reserva


// Exibindo informações da reserva
Console.WriteLine("Reserva:");
Console.WriteLine($"Hóspede: {reserva.Hospede.Nome}");
Console.WriteLine($"Suíte: {reserva.Suite.Numero}");
Console.WriteLine($"Data de início: {reserva.DataInicio.ToShortDateString()}");
Console.WriteLine($"Data de fim: {reserva.DataFim.ToShortDateString()}");
Console.WriteLine($"Quantidade de hóspedes: {reserva.CalcularQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal():C}");
