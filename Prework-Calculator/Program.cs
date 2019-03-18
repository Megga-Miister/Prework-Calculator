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
            Console.WriteLine("Please enter what number you would like to " + calculate + " .");
            int numberA = Convert.ToInt32(Console.ReadLine());
            //ask user for number b
            Console.WriteLine("Please enter the other number you would like to " + calculate + " with.");
            int numberB = Convert.ToInt32(Console.ReadLine());

        }

        //TO DO
        private static void Add()
        {

        }
        //add method
        //run given numbers through chosen calculations
        //subtract method
        //run given numbers through chosen calculations
        //multiply method
        //run given numbers through chosen calculations
        //divide method
        //run given numbers through chosen calculations


    }
}
