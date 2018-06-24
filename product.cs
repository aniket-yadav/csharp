using System;
namespace practical{
	public class product{
		public static void Main(){
			Console.WriteLine("Enter No1: ");
			int No1=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter No2: ");
			int No2=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter No3: ");
			int No3=int.Parse(Console.ReadLine());
			Console.WriteLine("Enter No4: ");
			int No4=int.Parse(Console.ReadLine());
            int p=No1*No2*No3*No4;
            Console.WriteLine("Product of {0}, {1}, {2}, {3} is {4}.",No1,No2,No3,No4,p);
		}
	}
}