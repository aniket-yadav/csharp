using System;
namespace Practical
{
	public class fibonacci{
		public static void fibonacciseries(int n){
          int sp=n;
         for(int j=0;j<n;j++){
           for(int k=0;k<sp;k++){
           	Console.Write(" ");
           }
           int a=0;
           int b=1;
           int c;
           for(int i=0;i<=j;i++){
           	c=a+b;
           	Console.Write(c+" ");
            a=b;
            b=c;
           }
           Console.WriteLine();
           sp-=1;
       }
		}
		public static void Main(String[] args){
			Console.Write("Enter Range of Series : ");
			int no = Convert.ToInt16(Console.ReadLine());
			fibonacciseries(no);
			
		}
	}

}