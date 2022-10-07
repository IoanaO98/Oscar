using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscar
{
	internal class Program
	{
		static void Main(string[] args)
        {            //Basic
            //ex.5 
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();

                 //FOR LOOP
            //ex.1.Sharp to display the first 10 natural numbers. 
            int x;
            Console.WriteLine("Display the first 10 natural numbers; ");
   
            Console.WriteLine("The first 10 natural number are: ");
            // for loop
            for(x = 0; x <= 10; x++)
            {
                Console.WriteLine("{0}", x);
            }

            //2. Write a C# Sharp program to find the sum of first 10 natural numbers.
             int d,sum = 0;
            for (d = 0; d <= 10; d++)
            {
                    sum = sum + d;
                Console.WriteLine("{0}", d);
            }
            Console.WriteLine($"the sum is {sum}");

            //.ex.2. Write a program in C# Sharp to display n terms of natural number and their sum.
            int n, i, total = 0;
            Console.WriteLine("Input Value of terms : ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= i; i++)
            {
                total = total + i;
            }
                Console.WriteLine("The total of natural number are:  " + total );
            Console.ReadLine();

           // ex.4.
		}
	}
}

