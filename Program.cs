using DesafioDesenvolvedor;
namespace ConsoleApp1
{
    class Program : DesafioDesenvolvedor.CasoUm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulações disponiveis: 1,2,3,5");
            Console.WriteLine("Digite o número da simulação que deseja executar:");
            string selected = Console.ReadLine();
            switch (selected)
            {
                case "1":
                    CasoUm.Run();
                    break;
                case "2":
                    CasoDois.Run();
                    break;
                case "3":
                    CasoTres.Run();
                    break;
                case "5":
                    CasoCinco.Run();
                    break;

                default:
                    Console.WriteLine("Simulação não encontrada.");
                    break;
            }
        }
    }
}