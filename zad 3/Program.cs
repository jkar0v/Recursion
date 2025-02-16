namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's reverse the number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Reversed:");
            Console.WriteLine(Reversed(n));
        }
        static int Reversed(int number, int reversed = 0)
        {
            if (number == 0)
            {
                return reversed;
            }
            return Reversed(number / 10, reversed * 10 + number % 10);
        }
    }
}
