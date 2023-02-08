namespace Fundamentals
{
    class Program
    {
        static void Diapason(int n, int m)
        {
            for(int i = n; i <= m; i++) { if (n % 2 == 0) { Console.WriteLine(n); n++; } else n++; }
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number of range: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number of range:");
            int m = Convert.ToInt32(Console.ReadLine());
            

            if (n > m) { int temp = 0; temp = m; m = n; n = temp; Diapason(n, m); }
            else { Diapason(n, m); }
        }
    }
}
