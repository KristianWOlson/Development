using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sampleArray1 = new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] sampleArray2 = new int[] { 999, -60, -77, 14, 160, 301 };
            int[] sampleArray3 = new int[] {10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };

            int sumValuesOfAnArray(int[] array, int arrayNumber)
            {
                int sumOfArray = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sumOfArray += array[i];
                }
                Console.WriteLine("#" + arrayNumber + " Array Sum: " + sumOfArray);
                return sumOfArray;
            }

            sumValuesOfAnArray(sampleArray1, 1);
            sumValuesOfAnArray(sampleArray2, 2);
            sumValuesOfAnArray(sampleArray3, 3);
        }
    }
}
