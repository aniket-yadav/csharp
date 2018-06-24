using System;

namespace practice
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter marks to check grade : ");
            int mark = int.Parse(Console.ReadLine());
            if(0>mark||mark>100){
                Console.WriteLine("Wrong input.");
            }else if(mark<50){
                Console.WriteLine("Fail");
            }else if(50<=mark&&mark<60){
                Console.WriteLine("D Grade.");
            }else if (60 <= mark &&mark< 70)
            {
                Console.WriteLine("C Grade.");
            }else if (70 <= mark&&mark < 80)
            {
                Console.WriteLine("B Grade.");
            }else if (80 <= mark &&mark< 90)
            {
                Console.WriteLine("A Grade.");
            }else if (90 <= mark&&mark < 100)
            {
                Console.WriteLine("A+ Grade.");
            }else if (mark==100)
            {
                Console.WriteLine("O Grade.");
            }
        } 
    }
}
