namespace DesafioDesenvolvedor
{
    public class CasoUm
    {
        public static string Run()
        {
            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {
                K = K + 1;
                SOMA = SOMA + K;
            }

            Console.WriteLine($"\n A soma resulta em : {SOMA} \n");
            return SOMA.ToString();
        }
    }
}
 