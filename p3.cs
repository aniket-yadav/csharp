using System;

namespace practice
{
     class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter marks to check grade : ");
            int mark = int.Parse(Console.ReadLine());
            switch (mark)
            {
                case 10:
                    Console.Write("10");
                    break;
                case 20:
                    Console.Write("20");
                    break;
                case 30:
                    Console.Write("30");
                    break;
                case 40:
                    Console.Write("40");
                    break;
                case 50:
                    Console.Write("50");
                    break;
                case 60:
                    Console.Write("60");
                    break;
                case 70:
                    Console.Write("70");
                    break;
                case 80:
                    Console.Write("80");
                    break;
                case 90:
                    Console.Write("90");
                    break;
                case 100:
                    Console.Write("100");
                    break;
                default :
                    Console.Write("Invalid input");
                    break;
            }

        } 
    }
}
