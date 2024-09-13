namespace DesafioDesenvolvedor
{
    public class CasoCinco
    {
        public static void Run()
        {
            // Dados do problema
            double distanciaTotal = 125.0; // Distância entre Ribeirão Preto e Barretos em km
            double velocidadeCarro = 90.0; // Velocidade do carro em km/h
            double velocidadeCaminhao = 80.0; // Velocidade do caminhão em km/h
            int numPedagios = 3; // Número de pedágios
            double atrasoCarroPorPedagio = 5.0 / 60.0; // Atraso do carro por pedágio em horas (5 minutos)

            // Calcular o tempo de atraso total para o carro
            double tempoAtrasoCarro = numPedagios * atrasoCarroPorPedagio; // Atraso total em horas

            // Fórmula para o tempo de encontro (ignora pedágio por enquanto):
            // t = d / (v_carro + v_caminhao), onde v_carro e v_caminhao são as velocidades dos veículos
            double tempoEncontroSemAtraso = distanciaTotal / (velocidadeCarro + velocidadeCaminhao);

            // Tempo total para o carro (adicionando o atraso dos pedágios)
            double tempoTotalCarro = tempoEncontroSemAtraso + tempoAtrasoCarro;

            // Distância percorrida pelo carro e caminhão no ponto de encontro
            double distanciaCarro = velocidadeCarro * tempoEncontroSemAtraso;
            double distanciaCaminhao = distanciaTotal - distanciaCarro;

            // Exibir os resultados
            Console.WriteLine("\nTempo de encontro sem pedágio: " + tempoEncontroSemAtraso.ToString("F2") + " horas");
            Console.WriteLine("Tempo de atraso total do carro devido aos pedágios: " + tempoAtrasoCarro.ToString("F2") + " horas");
            Console.WriteLine("Tempo total de viagem do carro até o ponto de encontro: " + tempoTotalCarro.ToString("F2") + " horas");
            Console.WriteLine("Distância percorrida pelo carro até o ponto de encontro: " + distanciaCarro.ToString("F2") + " km");
            Console.WriteLine("Distância percorrida pelo caminhão até o ponto de encontro: " + distanciaCaminhao.ToString("F2") + " km\n");
        }
    }
}