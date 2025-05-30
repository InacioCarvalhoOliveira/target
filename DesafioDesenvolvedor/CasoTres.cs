
using System.Globalization;
using System.Text.Json;
using Target.Models;

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
            //var faturamentoData = JsonSerializer.Deserialize<FaturamentoMensal>(json);         
            // if (!faturamentoDiario.Any())
            // {
            //     Console.WriteLine("não há faturamento no mês a processar. Verifique o arquivo JSON.");
            //     return;
            // }

            string filePath = "util\\dados.json";
            string json = System.IO.File.ReadAllText(filePath);
            var faturamentoDiario = JsonSerializer.Deserialize<List<FaturamentoDia>>(json);

            var diasComFaturamento = faturamentoDiario
                .Where(dia => dia.Valor > 0)
                .Select(dia => dia.Valor).ToList();           

            if (!faturamentoDiario.Any())
            {
                Console.WriteLine("Não há dias com faturamento para processar.");
                return;
            }

            decimal menorFaturamento = diasComFaturamento.Min();
            decimal maiorFaturamento = diasComFaturamento.Max();
            decimal mediamensal = diasComFaturamento.Average();
            int diasAcimaDaMedia = diasComFaturamento.Count(f => f > mediamensal);

            Console.WriteLine($"Menor faturamento em um dia no mês: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento em um dia no mês: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média mensal: {diasAcimaDaMedia}");
        }
    }
}