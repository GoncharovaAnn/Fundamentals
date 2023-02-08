namespace Percent
{
    class Program
    {
        static void Percent(int n, int i)
        {
            int m = n * i / 100;
            Console.WriteLine($"Result: {m}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter percentage you want to calculate:");
            int i = Convert.ToInt32(Console.ReadLine());
            Percent(n, i);
        }

    }

}
