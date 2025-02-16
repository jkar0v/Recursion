namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете число:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Powerof2(number)}");
        }
        static bool Powerof2(int number)
        {
            if (number == 1)
            {
                return true;
            }
            if (number % 2 == 0)
            {
                return Powerof2(number / 2);
            }
            return false;
        }
    }
}
