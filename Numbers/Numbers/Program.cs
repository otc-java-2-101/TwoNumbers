using System;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            int sum;
            int difference;
            int product;
            int quotient;
            int remainder;
            int average;

            //request first number
            WriteLine("Please enter the first number: ");
            firstNumber= Convert.ToInt32(Console.ReadLine());

            //request second number
            WriteLine("Please enter the second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //output both numbers and dividing line
            WriteLine("The first number was: " + firstNumber);
            WriteLine("The second number was: " + secondNumber);
            WriteLine("------------------------------");

            //calculations
            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            product = firstNumber * secondNumber;
            quotient = firstNumber / secondNumber;
            remainder = firstNumber % secondNumber;
            average = (firstNumber + secondNumber) / 2;

            // output of calculations
            WriteLine("The sum = " + sum);
            WriteLine("The difference = " + difference);
            WriteLine("The product = " + product);
            WriteLine("The quotient = " + quotient);
            WriteLine("The remainder = " + remainder);
            WriteLine("The average = " + average);
            Read();
        }
    }
}
