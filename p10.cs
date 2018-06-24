using System;
namespace practice
{
    class MainClass
    {
        public static void checkMinimum(int[] arr){
            int min = arr[0];
            foreach (int a in arr ){
                if(min>a){
                    min = a;
                }
            }
            Console.WriteLine("Minimum element of array arr is {0} ", min);
        }
        public static void checkMaximum(int[] arr){
            int max = arr[0];
            foreach (int a in arr)
            {
                if (max < a)
                {
                    max = a;
                }
            }
            Console.WriteLine("Maximum element of array arr is {0} ", max);
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
            checkMaximum(arr);
            checkMinimum(arr);
        }
    }
}
