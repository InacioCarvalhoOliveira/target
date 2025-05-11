namespace DesafioDesenvolvedor
{
    public class CasoDois
    {
        public static void Run()
        {
            Console.WriteLine("Digite um número inteiro para verificar se pertence a sequência Fibonacci:");
            int num = Convert.ToInt32(Console.ReadLine());
            
            List<int> fibonacciSequence = new List<int> { 0, 1 };
            while (true)
            {
                int next = fibonacciSequence[fibonacciSequence.Count - 1] + fibonacciSequence[fibonacciSequence.Count - 2];
                if (next > num) break;
                fibonacciSequence.Add(next);
            }
           
            bool belongsToFibonacci = fibonacciSequence.Contains(num);

            Console.WriteLine("Sequência Fibonacci gerada:");
            foreach (int value in fibonacciSequence)
            {
                Console.WriteLine(value);
            }

            if (belongsToFibonacci)
            {
                Console.WriteLine($"{num} pertence à sequência Fibonacci.");
            }
            else
            {
                Console.WriteLine($"{num} não pertence à sequência Fibonacci.");
            }
        }
    }
}