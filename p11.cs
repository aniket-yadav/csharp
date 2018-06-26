using System;

namespace array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Enter First  Matrix ");
            Console.Write("Enter no of rows : ");
            int rows1=int.Parse(Console.ReadLine());
            Console.Write("Enter no of columns : ");
            int cols1 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[rows1, cols1];
            for (int i = 0; i < rows1;i++){
                for (int j = 0; j < cols1;j++){
                    Console.Write("Element[{0},{1}] <== ",i,j);
                    matrix1[i,j] = int.Parse(Console.ReadLine());
                }
            }


            Console.WriteLine("Enter Second  Matrix ");
            Console.Write("Enter no of rows : ");
            int rows2 = int.Parse(Console.ReadLine());
            Console.Write("Enter no of columns : ");
            int cols2 = int.Parse(Console.ReadLine());
            int[,] matrix2 = new int[rows2,cols2];
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write("Element[{0},{1}] <== ", i,j);
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine(" First Matrix ");
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    Console.Write(matrix1[i, j]+" ");

                }
                Console.WriteLine();
            }
            Console.WriteLine(" Second Matrix ");
            for (int i = 0; i < rows2; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    Console.Write(matrix2[i, j] + " ");

                }
                Console.WriteLine();
            }
            if ((rows1 == rows2) && (cols1 == cols2))
            {
                Console.WriteLine("Addition of First and Second Matrix ");
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols1; j++)
                    {
                        Console.Write(matrix1[i, j] + matrix2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
                else
                {
                    Console.WriteLine(" invalid matrix for addition ");
                }
              
                if ((rows1 == rows2) && (cols1 == cols2))
                {
                    Console.WriteLine("Subtraction of Second Matrix from First Matrix ");
                    for (int i = 0; i < rows1; i++)
                    {
                        for (int j = 0; j < cols1; j++)
                        {
                            Console.Write(matrix1[i, j] - matrix2[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                 else
                    {
                        Console.WriteLine("invalid matrix for subtraction ");
                    }
            if(cols1==rows2)
            {
                int[,] Mult = new int[rows1, cols2];
                 Console.WriteLine("Multiplication of First and Second Matrix ");
                for (int i = 0; i < rows1;i++){
                    for (int j = 0; j<cols2;j++){
                        for (int k = 0; k < rows2;k++){
                            Mult[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                        
                    }
                }
                for (int i = 0; i < rows1; i++)
                {
                    for (int j = 0; j < cols2; j++)
                    {
                        Console.Write(Mult[i,j]+ " ");
                    }
                    Console.WriteLine();
                }


            }else{
                Console.WriteLine("Invalid matrix for multiplication ");
            }


                
            }
        }
    }

