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
		{
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

            //ex.1.Sharp to display the first 10 natural numbers. (for loop)
            int x;
            Console.WriteLine("Display the first 10 natural numbers; ");
   
            Console.WriteLine("The first 10 natural number are: ");
            // for loop
            for(x = 0; x <= 10; x++)
            {
                Console.WriteLine("{0}", x);
            }

		}
	}
}

