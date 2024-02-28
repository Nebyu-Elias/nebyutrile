using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Arrays1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declare a 20 array ith size 2,2
            int[,] array1 = new int[,] {
                { 1, 2 },
                { 3, 4 }
            };
            //Print out the number of array 1
            Console.WriteLine($"array1[0,0]: {array1[0, 0]}");
            Console.WriteLine($"array1[0,1]: {array1[0, 1]}");
            Console.WriteLine($"array1[1,0]: {array1[1, 0]}");
            Console.WriteLine($"array1[1,1]: {array1[1, 1]}");
            Console.WriteLine();

            //using loops
            Console.WriteLine("Length of array1 is:" + array1.Length);

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            //Declare the  same 20 array with size 4,4
            Console.WriteLine("Recreating the  same 20 array with size 4,4");

            array1 = new int[4, 4] {
            {1, 2, 3, 4 },
            { 5, 6, 7, 8 },
            { 9, 10, 11, 12 },
            { 13, 14, 15, 16}

            };
            Console.WriteLine("Length of array1 is:" + array1.Length);

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }
            int ans = 0;
            Console.WriteLine("Length of array1 is:" + array1.Length);

            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    ans = ans + array1[i, j];
                    Console.WriteLine(ans);
                }


            }
            Console.WriteLine();
            Console.WriteLine("The total sum is: " + ans);
            Console.WriteLine();
            Console.WriteLine("This is the Dynamic result below:");

            var arr1 = new int[4, 4]
                {
                   {1,2,3,4 },
                   {5,6,7,8 },
                   {9,10,11, 12},
                   {11,12,13,14},
                };

            int l; int m;

            for (l = 0; l < Math.Sqrt(arr1.Length); l++)
            {
                for (m = 0; m < Math.Sqrt(arr1.Length); m++)
                {
                    Console.WriteLine(arr1[l, m]);
                }
            }

        }
    }
}
