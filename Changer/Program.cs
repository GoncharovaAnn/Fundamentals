namespace Fundamentals
{
    class Program
    {
        static void Number(int n)
        {
            int a, b, c, d, e, f;
            a = n / 100000;
            b = n / 10000 - a * 10;
            c = n / 1000 - a * 100 - b * 10;
            d = n / 100 - a * 1000 - b * 100 - c * 10;
            e = n / 10 - a * 10000 - b * 1000 - c * 100 - d * 10;
            f = n - a * 100000 - b * 10000 - c * 1000 - d * 100 - e * 10;
            Change();

        }
        static void Change(int m, int k)
        {
            int temp = 0;
            m = k;
            k = temp;
            temp = m;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter six-digit number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ranks to swap numbers: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            if (n <= 99999 || n > 999999) { Console.WriteLine("Error: You need to enter six-digit number"); }
            else { Number (n); }
        }

    }

}
