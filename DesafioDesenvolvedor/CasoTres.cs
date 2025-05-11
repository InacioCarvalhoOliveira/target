
using System.Globalization;
using System.Text.Json;

namespace DesafioDesenvolvedor
{
    public class FaturamentoMensal
    {
        public Dictionary<string, string> FaturamentoDiario { get; set; }
    }

    public class CasoTres
    {
        public static void Run()
        {
            //decimal[] faturamentoDiario = { 0,400, 1500,601,1200, 0, 2300, 1800, 0, 0, 2100, 1900, 0, 0, 2200, 2000, 2500 }; // Dias sem faturamento representados como 0

            string filePath = "util\\faturamentoMensal.json";
            string json = System.IO.File.ReadAllText(filePath);
            var faturamentoData = JsonSerializer.Deserialize<FaturamentoMensal>(json);         

            var faturamentoDiario = faturamentoData.FaturamentoDiario
                .ToDictionary(
                    KeyValuePair => KeyValuePair.Key,
                    KeyValuePair => decimal.TryParse(KeyValuePair.Value,CultureInfo.InvariantCulture, out decimal value) ? value : 0
                )
                .Where(KeyValuePair => KeyValuePair.Value > 0)
                .Select(KeyValuePair => KeyValuePair.Value)
                .ToArray();

            if (!faturamentoDiario.Any())
            {
                Console.WriteLine("não há faturamento no mês a processar. Verifique o arquivo JSON.");
                return;
            }

            decimal menorFaturamento = faturamentoDiario.Min();
            decimal maiorFaturamento = faturamentoDiario.Max();

            decimal mediamensal = faturamentoDiario.Average();

            int diasAcimaDaMedia = faturamentoDiario.Count(f => f > mediamensal);

            Console.WriteLine($"Menor faturamento em um dia no mês: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento em um dia no mês: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        }
    }
}