using System;

namespace practice
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number for table : ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("table of {0} ", no);
            for (int i = 1; i <=10;i++){
                Console.Write("\t{0}\n\n",no * i);
            }

        } 
    }
}
