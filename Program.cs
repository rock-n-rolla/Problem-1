using static System.Console;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(Sum(1000));
        }

        static int Sum(int hi)
        {
            var sum = 0;

            for (int i = 3; i < hi; i += 3)
            {
                sum += i;
            }

            for (int i = 5; i < hi; i += 5)
            {
                if (i % 3 == 0 ^ i % 5 == 0)
                    sum += i;
                else
                    continue;
            }

            return sum;
        }
    }
}
