using static System.Runtime.InteropServices.JavaScript.JSType;

namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number and a power, divided with space:");
            string[] input = Console.ReadLine().Split(" ");
            int number = int.Parse(input[0]);
            int power = int.Parse(input[1]);
            Console.WriteLine($"Alright, {number} to the {power} power is:");
            Console.WriteLine(Power(number, power));
        }
        static int Power(int number, int power)
        {
            if (power != 0)
            {
                return Power(number, power - 1) * number;
            }
            else
            {
                return 1;
            }
        }
    }
}
