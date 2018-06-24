using System;
namespace Practical{
	public class factorial{
		public static int fact(int n){
			if(n==0){
				return 1;
			}
          return n*fact(n-1);
		}
		public static void Main(){
          Console.Write("Enter Number : ");
          int no = int.Parse(Console.ReadLine());
          Console.WriteLine(" factorial of {0} is {1} .",no,fact(no));
		}
	}
}