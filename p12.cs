using System;

namespace array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter size of Jagged Array ");
            int size = int.Parse(Console.ReadLine());
            int[][] jagged = new int[size][];
            int i = 0;
            while (i < size)
            {
                Console.WriteLine("Enter size of {0} element of Jagged array ", i);
                int s = int.Parse(Console.ReadLine());
                jagged[i] = new int[s];
                for (int j = 0; j < s; j++)
                {
                    jagged[i][j] = int.Parse(Console.ReadLine());
                }
                i++;
            }
            Console.WriteLine(" Jagged Array ");
            for (int k = 0; k < jagged.Length;k++){
                for (int j = 0; j < jagged[k].Length;j++){
                    Console.Write(jagged[k][j]+" ");
                }
                Console.WriteLine();
            }


         }
     }
 }

