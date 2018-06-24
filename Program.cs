using System;

namespace firstdemo
{
    public class pyramid
    {
        public pyramid(){
            Console.WriteLine("Enter Lavel of Pyramid ");
            int l = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter pattern : ");
            String pn = Console.ReadLine();

            int sp=l*pn.Length, s=1;
            for (int i = 0; i < l;i++){
                for (int j = 0; j < sp;j++){
                    Console.Write(" ");
                }
                for (int k = 0; k < s;k++){
                    Console.Write("{0}",pn);
                    for (int m = 0; m < pn.Length; m++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
                sp -= pn.Length;
                s += 1;
            }
        }
    }
    public  class MainClass
    {
        public static void Main(string[] args)
        {
            pyramid pyramid =  new pyramid();
        }
    }
}
