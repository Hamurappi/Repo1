using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[5];
            int i,j,small_value;
            int sum=0;
            for (i = 0; i < Array.Length; i++)
            {
                Console.Write("Введите элемент массива "+i+": ");
                Array[i]= int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            // Вывод массива в обратном порядке
            Console.Write("Массив в обратном порядке: ");
            for (j = (Array.Length-1); j >= 0; j--)
            {
                Console.Write(Array[j]+" ");
            }
            Console.WriteLine();
            // Найти сумму четных чисел в массиве
            for (j = (Array.Length - 1); j >= 0; j--)
            {
                if (Array[j]%2==0)
                {
                    sum += Array[j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Сумма чётных элементов в массиве равна: "+sum);
            Console.WriteLine( );
            // Найти наименьший член массива
            small_value = Array[4];
            for (j = (Array.Length - 1); j >= 0; j--)
            {
                if(Array[j]<=small_value)
                small_value = Array[j];
            }
            Console.WriteLine("Наименьшее значение равно: "+small_value);
            Console.WriteLine();
        }
    }
}
