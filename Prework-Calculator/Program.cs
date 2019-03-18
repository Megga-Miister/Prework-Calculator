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
            //prompt user to enter what kind of calculation they would like
            Console.WriteLine("Please choose what type of calculation you would like: Add, Subtract, Multiply or Divide");
            string calculate = Console.ReadLine();

            //ask user for number a
            Console.WriteLine("Please enter what number you would like to " + calculate + ".");
            int numberA = Convert.ToInt32(Console.ReadLine());
            //ask user for number b
            Console.WriteLine("Please enter the other number you would like to " + calculate + " with.");
            int numberB = Convert.ToInt32(Console.ReadLine());

        
            if (calculate == "Add")
            {
                int solution = Add(numberA, numberB);
                Console.WriteLine("The sum of " + numberA + " & " + numberB + " is " + solution);
            } else if (calculate == "Subtract")
                {
                int solution = Subtract(numberA, numberB);
                Console.WriteLine("The difference of " + numberA + " & " + numberB + " is " + solution);
                }

            Console.ReadLine();
        }

        
        //add method - run given numbers through chosen calculations
        static int Add(int givenNumberA, int givenNumberB)
        {
            int sum = givenNumberA + givenNumberB;
            return sum;
        }

        //subtract method - run given numbers through chosen calculations
        static int Subtract(int givenNumberA, int givenNumberB)
        {
            int difference = givenNumberA - givenNumberB;
            return difference;
        }

        //multiply method
        //run given numbers through chosen calculations
        //divide method
        //run given numbers through chosen calculations


    }
}
