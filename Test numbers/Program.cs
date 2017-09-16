using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var sumBoundary = int.Parse(Console.ReadLine());

            var counter = 0;
            var totalSum = 0;
            bool sumReached = false;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var result = 3 * (i * j);
                    totalSum = totalSum + result;
                    counter = counter + 1;
                    if (totalSum >= sumBoundary)
                    {
                        sumReached = true;
                        goto Finish;
                    }
                }
            }
        Finish: if (sumReached == false)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum} >= {sumBoundary}");
            }
            
        }
    }
}
