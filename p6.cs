using System;

namespace practice
{
     class MainClass
    {
        String display(String name){
            return (" hello "+ name);
        }
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            Console.WriteLine(new MainClass().display(Console.ReadLine()));

        } 
    }
}
