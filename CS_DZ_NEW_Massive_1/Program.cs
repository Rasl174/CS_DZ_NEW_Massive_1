using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_NEW_Massive_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 3, 56, 4, 4, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 0, 0 };
            int repits = 0;
            int maxRepits = 0;
            int repitedNumbers = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    repits++;
                }
                else
                {
                    repits = 0;
                }
                if (repits >= maxRepits)
                {
                    repitedNumbers = numbers[i];
                    maxRepits = repits + 1;
                }
            }


            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine(repitedNumbers);
            Console.WriteLine(maxRepits);
        }
    }
}
