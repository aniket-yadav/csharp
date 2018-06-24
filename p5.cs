using System;

namespace practice
{
     class MainClass
    {

        static void display(){
            Console.WriteLine("You are not eligible to vote!");
        }
        public static void Main(string[] args)
        {

            loop:

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if(age<18){
                display();
            }
            else{
                Console.WriteLine("You are eligible to vote!");
            }
            Console.WriteLine("Do you want to continue y/n?: ");
            if(Console.Read()=='n'){
                Environment.Exit(0);
            }
            goto loop;

        } 
    }
}
