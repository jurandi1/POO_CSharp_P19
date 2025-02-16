using POO_CSharp_P19.Service;

namespace POO_CSharp_P19
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            PrintService printService = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            printService.Print();

            Console.WriteLine("First: " + printService.First());
        }
    }
}