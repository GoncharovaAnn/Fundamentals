namespace Fundamentals
{
    class Program
    {
         static void FizzBuzz(int n)
        {
            if ((n % 3 == 0) && (n % 5 == 0)) { Console.WriteLine("FizzBuzz"); }
            else if (n % 3 == 0) { Console.WriteLine("Fizz"); }
            else if (n % 5 == 0) { Console.WriteLine("Buzz"); }
            else { Console.WriteLine(n); }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number from 1 to 100:");

            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 100) { Console.WriteLine("Error: You can enter number in the range of 1 to 100"); }
            else { FizzBuzz(n); }
        }

    }
   
}


