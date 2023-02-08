namespace MakeBigNumber
{
    class Program
    {
        static void MakeBigNumber(int a, int b, int c, int d)
        {
            int m = a * 1000 + b * 100 + c * 10 + d;
            Console.WriteLine($"Result: {m}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2st number:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3st number:");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 4st number:");
            int d = Convert.ToInt32(Console.ReadLine());
            MakeBigNumber(a, b, c, d);
        }

    }

}