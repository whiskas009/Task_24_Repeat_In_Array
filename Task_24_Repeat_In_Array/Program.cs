using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_24_Repeat_In_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 3, 3, 3, 3, 8, 9, 10, 10, 10, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 12, 22, 13, 22, 27, 28, 29, 30 }; 
            int counter = 1;
            int numberRepetitions = 0;
            int repeatNumber = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i-1])
                {
                    counter++;
                }
                else if (numberRepetitions < counter)
                {
                    numberRepetitions = counter;
                    repeatNumber = array[i - 1];
                    counter = 1;
                }
            }

            Console.WriteLine($"\nЧисло {repeatNumber} повторяется {numberRepetitions} раз подряд");
        }
    }
}
