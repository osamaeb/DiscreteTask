using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, count, n1, n2;
            Console.WriteLine("Enter a number: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a greater number: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("n1 must be smaller than n2 \n");
                return;
            }

            Console.WriteLine("prime Numbers between " + n1 + " and " + n2 + " are: ");
            for (i = n1; i <= n2; i++)
            {
                count = 0;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i > 1)
                    Console.WriteLine(i);
            }
            Console.WriteLine();
            return;

        }
    }
}
