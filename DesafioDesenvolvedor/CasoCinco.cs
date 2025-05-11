namespace DesafioDesenvolvedor
{
    public class CasoCinco
    {
        public static void Run()
        {                 
            Console.WriteLine("escreva algo para inverter:");
            string input = Console.ReadLine();
            string[] str = {};
            char[] reversedArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[i] = input[input.Length - 1 - i];
            }
            string reversedString = new string(reversedArray);
            Console.WriteLine($"String invertida: {reversedString}");
        }
    }
}

