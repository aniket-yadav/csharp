using System;

namespace practice
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                
                Console.Write("\nEnter positive number to check odd n even : ");
                int no = int.Parse(Console.ReadLine());
                if (no % 2 == 0)
                {
                    Console.WriteLine("Number is even number.");
                }
                else
                {
                    Console.WriteLine("Number is odd number.");
                }
                count++;
                Console.WriteLine("Do you want to continue y/n ?");
                char c = Convert.ToChar(Console.Read());
                if(c=='n'){
                    break;
                }

            }
            Console.WriteLine("\nyour have checked {0} number ", count);
        } 
    }
}
