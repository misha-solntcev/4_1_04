using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Вариант 4
Дана целочисленная прямоугольная матрица. Определить:
1. количество строк, не содержащих ни одного нулевого элемента;
2. максимальное из чисел, встречающихся в заданной матрице более одного раза. */

namespace _4_1_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 9, 2, 3, 4, 5 },
                { 4, 1, 6, 7, 9 },
                { 7, 8, 0, 5, 2 },
                { 0, 7, 5, 0, 1 },
            };

            // Количество строк, не содержащих ни одного нулевого элемента;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                bool flag = false;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == 0)
                        flag = true;
                }
                if (!flag)
                    count++;
            }
            Console.WriteLine(count);
            Console.WriteLine("-----------");

            // Максимальное из чисел, встречающихся в заданной матрице более одного раза.                        
            List<int> digits = new List<int>();            
            foreach (int k in array)
            {
                int digit = k;
                count = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if ((array[i,j] == k) && (digits.Contains(k) == false))
                            count++;
                    }
                }
                if (count > 1)
                    digits.Add(digit);
            }

            int max = digits[0];
            foreach (int digit in digits)
                if (digit > max)
                    max = digit;
            Console.WriteLine($"max = {max}");            
            Console.ReadKey();
        }
    }
}
