using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            float firstNum = float.Parse(Console.ReadLine());
            float secondNum = float.Parse(Console.ReadLine());
            float thirdNum = float.Parse(Console.ReadLine());

            int countNegative = 0;

            if (firstNum < 0)
            {
                countNegative++;
            }
            if (secondNum < 0)
            {
                countNegative++;
            }
            if (thirdNum < 0)
            {
                countNegative++;
            }

            if (countNegative == 0)
            {
                Console.WriteLine("+");
            }
            else if (countNegative % 2 == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }
}



/*
Description
Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.

Input
On the first three lines, you will receive the three numbers, each on a separate line

Output
Output a single line - the sign of the product of the three numbers

Constraints
The input will always consist of valid floating-point numbers
Time limit: 0.1s
Memory limit: 16MB
*/