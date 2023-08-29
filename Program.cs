// See https://aka.ms/new-console-template for more information
namespace Euler_FourtyEight 
{
    class Program 
    {
        static void Main()
        {
            long sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += ModdedSelfPower(i,10000000000);
                sum %= 10000000000;
            }
            Console.WriteLine($"sum of self powers last 10 digits is {sum}");
        }
        static long ModdedSelfPower(long number, long mod)
        {
            long output = 1;
            for (long i = 1; i <= number && output != 0; i++ )
            {
                output *= number;
                output %= mod;
            }
            return output;
        }
    }
}