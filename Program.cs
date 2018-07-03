using System;


/*
namespace practicals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter int to convert into boolean : ");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine(" boolean of int {0} is {1}.", no, Convert.ToBoolean(no));
        }
    }
}
*/


/*
namespace practicals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.Write("Enter no1 = ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter no2 = ");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select operation by Index ");
            Console.WriteLine("\t\t1.Addition\n\t\t2.Subtraction\n\t\t3.Multiplication\n\t\t4.Division");
            Console.Write("Enter choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Addition : {0}", no1 + no2);
                    break;
                case 2:
                    Console.WriteLine("Subtraction : {0}", no1 - no2);
                    break;
                case 3:
                    Console.WriteLine("Multiplicatio : {0}", no1 * no2);
                    break;
                case 4:
                    Console.WriteLine("Division : {0}", no1 / no2);
                    break;
                default:
                    Console.WriteLine("Invalid input ");
                    break;
            }
        }
    }
}
*/


/*
namespace practicals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter no : ");
            int no = int.Parse(Console.ReadLine());
            if(no%2==0){
                Console.WriteLine("{0} is even.", no);
            }else{
                Console.WriteLine("{0} is odd.", no);
            }
        }
    }
}
*/


/*
namespace practicals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value of no1 : ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of no2 : ");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("value before swapping no1={0} and no2={1} ",no1,no2);
            int temp = no1;
            no1 = no2;
            no2 = temp;
            Console.WriteLine("Value after swap no1={0} and no2={1} ", no1, no2);
        }
    }
}
*/


/*
namespace practicals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string to reverse : ");
            String str = Console.ReadLine();
            char[] arr = str.ToCharArray();
            string revstr = "";
            for (int i = arr.Length - 1; i >= 0;i--){
                revstr += arr[i];
            }
            Console.WriteLine("reverse of {0} is {1} . ", str, revstr);

        }
    }
}
*/


/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number to get the sum of digits : ");
            int no = int.Parse(Console.ReadLine());
            int n = no;
            int sum = 0, rem = 0;
            while(no>0){
                rem = no % 10;
                sum += rem;
                no /= 10;
            }
            Console.WriteLine("sum  of digits of number {0} is {1} ", n, sum);
        }
    }
}
*/


/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter no : ");
            int no = int.Parse(Console.ReadLine());
            int n = no;
            int count = 0;
            while (no > 0)
            {
                if (no % 10 == 1)
                {
                    count++;
                }

                no /= 10;
            
            Console.WriteLine("no of 1's in {0} is {1}.", n, count);
        }
    }
}
*/


/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter year : ");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("year {0} is leap year.",year);

            }
            else{
                Console.WriteLine("Year {0} is not leap year.",year);
            }
            
        }
    }
}
*/


/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random no = new Random();
           int n= no.Next(1, 100);
            Console.Write("Random no between 1 to 100 is {0} ",n);
        }
    }
}
*/


/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string :");
            string str = Console.ReadLine().ToLower();
            string[] s = str.Split();
            int count = 0;
            foreach(string b in s){
                if(b.Equals("the")){
                    count++;
                }
            }
            Console.WriteLine(" frequency of 'the' in sentence {0} is {1} ", str, count);

        }
    }
}
*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value of no1 : ");
            int no1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of no2 : ");
            int no2 = int.Parse(Console.ReadLine());
            if(no1>no2){
                Console.WriteLine("no1 ={0} is greater than no2={1}.", no1, no2);

            }
            else{
                Console.WriteLine("no2 ={0} is greater than no1={1}.", no2, no1);
            }
        }
    }
}
*/



/*
namespace practicals
{
    class primenumber
    {
        public primenumber()
        {
            int no = 2;
            int flag = 1;
            while (no <= 10)
            {
                for (int i = 2; i < no; i++)
                {
                    if (no % i == 0)
                    {
                        flag = 1;
                        break;

                    }
                    else
                    {
                        flag = 0;

                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(no);
                }
                no++;
            }
        }
        }
        class MainClass
        {
            public static void Main(string[] args)
            {
                new primenumber();
            }
        }
    }

*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value of no : ");
            int no = int.Parse(Console.ReadLine());
            if(no>0){
                Console.WriteLine("{0} is positive .",no);
            }else{
                Console.WriteLine("{0} is not positive.",no);
            }

        }
    }
}
*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string str = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Select a operation by index ");
                Console.WriteLine("\t\t1.Convert string to uppercase \n\t\t2.convert string to lowercase \n\t\t3.count the no of 't' in sentence \n\t\t4.Remove whitespace \n\t\t5.Add '@' at the end of string\n\t\t6.Check 's'  present in string \n");
                Console.Write("Enter your choice :");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(str.ToUpper()+"\n\n");
                        break;
                    case 2:
                        Console.WriteLine(str.ToLower()+"\n\n");
                        break;
                    case 3:
                        int count = 0;
                        char[] arr = str.ToCharArray();
                        foreach (char c in arr)
                        {
                            if ((c.Equals('t'))||(c.Equals('T')))
                            {
                                count++;
                            }
                        }
                        Console.WriteLine("no of 't' is sentence is {0}.\n\n", count);
                        break;
                    case 4:
                        Console.WriteLine(str.Trim()+"\n\n");
                        break;
                    case 5:
                        Console.WriteLine(str.PadRight(str.Length+1,'@')+"\n\n");
                        break;
                    case 6:
                        if((str.Contains("s"))||(str.Contains("S"))){
                            Console.WriteLine("'s' is present in string  {0} \n\n", str);
                        }else
                        {
                            Console.WriteLine("'s' is not present in str {0}\n\n", str);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input\n\n");
                        break;
                }
                Console.Write("Do you want to continue y/n : ");
                string ch = Console.ReadLine();
                if (ch.Equals("n")) {
                    break;
                }

            }
        }
        }
    }
*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] array = new int[3, 5];
            Console.WriteLine("Enter elements of array ");
            for (int i = 0; i < 3;i++){
                for (int j = 0; j < 5;j++){
                    Console.Write("array[{0},{1}] <== ",i,j);
                    array[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Elements of array ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(" "+array[i,j]+" ");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[][] array = new int[5][];
            array[0] = new int[2];
            array[1] = new int[3];
            array[2] = new int[1];
            array[3] = new int[6];
            array[4] = new int[8];
            Console.WriteLine("Enter element of array ");
            for (int i = 0; i < array.Length;i++){
                for (int j = 0; j < array[i].Length;j++){
                    Console.Write("array[{0}][{1}] <== ", i, j);
                    array[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Element of array ");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(" "+array[i][j]+" ");
                }
                Console.WriteLine();
            }
        }   
    }
}
*/



/*

namespace practicala
{
    class calculator{
        public static void Addition(int no1,int no2){
            Console.WriteLine("Addition of {0} and {1} is {2}", no1, no2, no1 + no2);
        } 
        public static void Subtraction(int no1,int no2){
            Console.WriteLine("Subtraction of {0} and {1} is {2}", no1, no2, no1 - no2);
        } 
        public static void Multiplication(int no1,int no2){
            Console.WriteLine("Multiplication of {0} and {1} is {2}", no1, no2, no1 * no2);
        } 
        public static void Division(int no1,int no2){
            Console.WriteLine("Division of {0} and {1} is {2}", no1, no2, no1 / no2);
        } 

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.Write("Enter no1 = ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("Enter no2 = ");
            int no2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Select operation by Index ");
            Console.WriteLine("\t\t1.Addition\n\t\t2.Subtraction\n\t\t3.Multiplication\n\t\t4.Division");
            Console.Write("Enter choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice){
                case 1:
                    calculator.Addition(no1, no2);
                    break;
                case 2:
                    calculator.Subtraction(no1, no2);
                    break;   
                case 3:
                    calculator.Multiplication(no1, no2);
                    break;  
                case 4:
                    calculator.Division(no1, no2);
                    break; 
                default:
                    Console.WriteLine("Invalid input ");
                    break;

            }

        }
    }
}

*/




/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10;i++){
                for (int j = 1; j <= 10;j++){
                    Console.Write(" " + i * j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
*/




/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter string : ");
            string str = Console.ReadLine();
            Console.Write("Enter starting index for substring : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter no of characters in subtring : ");
            int no_of_char = int.Parse(Console.ReadLine());
            if ((no_of_char + start) <=str.Length)
            {
                Console.WriteLine("Subtring : " + str.Substring(start, no_of_char));
            }else{
                Console.WriteLine("Invalid input");
            }
        }
    }
}
*/



/*
namespace practicala
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 numbers  ");
            for (int i = 0; i < 5;i++){
                Console.Write("{0} : ", i+1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Ascending order of 5 numbers ");
            foreach(int a in arr ){
                Console.WriteLine(a);
            }
            Array.Reverse(arr);
            Console.WriteLine("descending order of 5 numbers ");
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}
*/
