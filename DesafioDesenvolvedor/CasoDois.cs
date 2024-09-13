namespace DesafioDesenvolvedor
{
    public class CasoDois
    {
        public static void Run()
        {
            // a) 1, 3, 5, 7, ___ (incremento de 2)
            int[] seqA = { 1, 3, 5, 7 };
            int nextA = seqA[seqA.Length - 1] + 2;
            Console.WriteLine($"\nPróximo elemento de a): {nextA}");

            // b) 2, 4, 8, 16, 32, 64, ___ (multiplicação por 2)
            int[] seqB = { 2, 4, 8, 16, 32, 64 };
            int nextB = seqB[seqB.Length - 1] * 2;
            Console.WriteLine($"Próximo elemento de b): {nextB}");

            // c) 0, 1, 4, 9, 16, 25, 36, ___ (quadrados perfeitos)
            int[] seqC = { 0, 1, 4, 9, 16, 25, 36 };
            int nextC = (int)Math.Pow(seqC.Length, 2); // próximo quadrado perfeito
            Console.WriteLine($"Próximo elemento de c): {nextC}");

            // d) 4, 16, 36, 64, ___ (quadrados de números pares)
            int[] seqD = { 4, 16, 36, 64 };
            int nextD = (int)Math.Pow(2 * (seqD.Length + 1), 2); // quadrado do próximo número par
            Console.WriteLine($"Próximo elemento de d): {nextD}");

            // e) 1, 1, 2, 3, 5, 8, ___ (sequência de Fibonacci)
            int[] seqE = { 1, 1, 2, 3, 5, 8 };
            int nextE = seqE[seqE.Length - 1] + seqE[seqE.Length - 2]; // soma dos dois últimos números
            Console.WriteLine($"Próximo elemento de e): {nextE}");

            // f) 2, 10, 12, 16, 17, 18, 19, ___ (alternância entre números pares e consecutivos)
            int[] seqF = { 2, 10, 12, 16, 17, 18, 19 };
            int nextF = seqF[seqF.Length - 1] + 1; // sequência de números consecutivos
            Console.WriteLine($"Próximo elemento de f \n): {nextF}");
        }
    }
}