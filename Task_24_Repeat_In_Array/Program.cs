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
            int[] array = { 7, 6, 6, 5, 3, 5, 2, 5, 7, 12, 7, 6, 6, 5, 54, 5, 2, 12, 7, 7, 7, 6, 6, 5, 5, 5, 2, 34, 7, 7 };
            int[] list = new int[array.Length * 2];
            int checkRepeat = array[0];
            int numberRepetitions = 1;
            int positionInList = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (checkRepeat == array[i])
                {
                    numberRepetitions++;                             
                }
                else
                {
                    list[positionInList] = array[i-1];          
                    list[positionInList +1] = numberRepetitions;
                    positionInList+=2;
                    numberRepetitions = 1;
                    checkRepeat = array[i];
                    continue;
                } 
            }
            
            list[positionInList] = array[array.Length-1];          
            list[positionInList + 1] = numberRepetitions;
            numberRepetitions = list[1] - 1;
            int repeatNumber = 0;

            for (int i = 1; i < list.Length; i+=2)
            {
                if (numberRepetitions < list[i])
                {
                    repeatNumber = list[i - 1];
                    numberRepetitions = list[i];
                }
            }

            Console.WriteLine($"\nЧисло {repeatNumber} повторяется {numberRepetitions} раз подряд");
        }
    }
}
