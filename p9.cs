using System;

namespace practice
{
    class MainClass
    {
        public static void DisplayArray(int[] arr){
            int j = 0;
            Console.WriteLine("Element of Array arr ");
            foreach (int a in arr)
            {
                Console.WriteLine("arr[{0}] => {1}", j, a);
                j++;
            }
        }

        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter value for Array arr : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] <= ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            DisplayArray(arr);

        }
    }
}
