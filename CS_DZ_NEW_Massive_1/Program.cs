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
            int[] numbers = { 1, 1, 1, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int repits = 0;
            int repitedNumbers = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        repitedNumbers = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = repitedNumbers;
                        repits++;
                    }
                }
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine(repitedNumbers);
            Console.WriteLine(repits);
        }
    }
}
