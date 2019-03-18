using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Calculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            int solution = 0;
            //prompt user to enter what kind of calculation they would like
            Console.WriteLine("Please choose what type of calculation you would like: Add, Subtract, Multiply or Divide");
            string calculate = Console.ReadLine();

            //ask user for number a
            Console.WriteLine("Please enter what number you would like to " + calculate + " .");
            int numberA = Convert.ToInt32(Console.ReadLine());
            //ask user for number b
            Console.WriteLine("Please enter the other number you would like to " + calculate + " with.");
            int numberB = Convert.ToInt32(Console.ReadLine());

            Answer();

        }

        //if statement to determine which method to use for calculation results
        private static Answer (int numberA, int numberB, string calculate)
        {
            if (calculate == "Add" || "add")
            {
            solution = Add();
            Console.WriteLine("The sum of " + numberA + " & " + numberB + " is " + solution);
            Console.ReadLine();
            }

        }
        
        //add method - run given numbers through chosen calculations
        private static Add(int numberA, int numberB)
        {
            int sum = numberA + numberB;
            return sum();
        }

        //subtract method
        //run given numbers through chosen calculations
        //multiply method
        //run given numbers through chosen calculations
        //divide method
        //run given numbers through chosen calculations


    }
}
