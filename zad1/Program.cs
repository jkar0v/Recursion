namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to be calculated:");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(number));
        }
        static long Calculate(long number)
        {
            if(number == 0)
            {
                return 0;
            }
            return (number % 10) + Calculate(number / 10);
        }
    }
}
