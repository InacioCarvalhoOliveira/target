
using System.Linq; 
namespace DesafioDesenvolvedor
{
    public class CasoTres
    {
        public static void Run()
        {
            // Exemplo de faturamento diário para todos os dias de um ano (pode ajustar conforme necessário)
            decimal[] faturamentoDiario = { 0, 1500, 0, 2300, 1800, 0, 0, 2100, 1900, 0, 0, 2200, 2000, 2500 }; // Dias sem faturamento representados como 0

            // Filtrar dias com faturamento > 0 (ignora finais de semana/feriados)
            var diasComFaturamento = faturamentoDiario.Where(f => f > 0).ToArray();

            // Calcular o menor e o maior valor de faturamento
            decimal menorFaturamento = diasComFaturamento.Min();
            decimal maiorFaturamento = diasComFaturamento.Max();

            // Calcular a média de faturamento anual (somente para dias com faturamento)
            decimal mediaAnual = diasComFaturamento.Average();

            // Calcular o número de dias em que o faturamento foi superior à média anual
            int diasAcimaDaMedia = diasComFaturamento.Count(f => f > mediaAnual);

            // Exibir resultados
            Console.WriteLine($"Menor faturamento do ano: {menorFaturamento}");
            Console.WriteLine($"Maior faturamento do ano: {maiorFaturamento}");
            Console.WriteLine($"Número de dias com faturamento acima da média anual: {diasAcimaDaMedia}");
        }
    }
}