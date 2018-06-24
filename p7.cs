using System;

namespace practice
{
     class MainClass
    {

        public void show(out int Val1,ref int Val2){
            int a=9;
            Val1 = a;
            //Val2 = a;
            Val1 *= Val1;
            Val2 *= Val2;
            Console.WriteLine(" value of val inside  method is {0},  {1}.", Val1,Val2);
        }
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter number va1 : ");
            //int Val1 = int.Parse(Console.ReadLine());
            int Val1;
            Console.WriteLine("Enter number var2: ");
            int Val2 = int.Parse(Console.ReadLine());
            MainClass main = new MainClass();
          //  Console.WriteLine(" value before calling the function is {0}, {1} ", Val1,Val2);
            main.show(out Val1,ref Val2);
            Console.WriteLine("value after calling the function is {0} , {1} ", Val1,Val2);

        } 
    }
}
