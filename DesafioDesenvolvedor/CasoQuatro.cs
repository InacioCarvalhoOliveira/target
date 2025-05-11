namespace DesafioDesenvolvedor
{
    public class CasoQuatro
    {
        public static void Run()
        {       
            decimal[] faturamentoMensal = [67836.43m, 36678.66m, 29229.88m, 27165.48m, 19849.53m];
            string[] estados = new[] { "SP", "RJ", "MG", "ES" };
            decimal faturamentoOutros = faturamentoMensal[faturamentoMensal.Length - 1];
            decimal faturamentoTotalMensal = 0;
            for (int j = 0; j < faturamentoMensal.Length; j++)
            {
                faturamentoTotalMensal += faturamentoMensal[j];
            }
            Console.WriteLine($"O faturamento total mensal da distribuidora é: {faturamentoTotalMensal:C}"+"\n");

            for(int i = 0; i < estados.Length; i++)
            {
                decimal percentualRepresentacao = faturamentoMensal[i] / faturamentoTotalMensal * 100;
                Console.WriteLine($"O faturamento mensal do estado {estados[i]} é: {faturamentoMensal[i]:C}");
                Console.WriteLine($"O percentual de representação do estado {estados[i]} é: {percentualRepresentacao:F2}%"+"\n");
            }
            decimal percentualOutros = faturamentoOutros / faturamentoTotalMensal * 100;
            Console.WriteLine($"O percentual de representação não estadual [outros] é: {percentualOutros:F2}%");
            Console.WriteLine($"O Faturamento não estadual [outros] é: {faturamentoOutros:C}");
        }
    }
}

