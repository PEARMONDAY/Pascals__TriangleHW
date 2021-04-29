using System;

namespace Pascals__Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            while (check != true)
            {
                Console.Write("Input number = ");
                int r = int.Parse(Console.ReadLine());
                if (r >= 0)
                {
                    R(r);
                    check = true;
                }
                else
                    Console.Write("Invalid Pascal’s triangle row number.");
            }
        }
        static void R(int r)
        {
            int x = 1;
            for (int i = 0; i <= r; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        x = 1;
                    }
                    else
                        x = x * (i - j + 1) / j;
                    Console.Write("{0}", x);
                }
                Console.WriteLine();
            }
        }
    }
}
