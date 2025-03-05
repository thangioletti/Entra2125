namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(f(5));
        }

        static int f (int n)
        {
            
            if (n == 0)
            {
                return 1;
            }

            return n*f(n-1);
        }
    }
}