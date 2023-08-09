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

            float biggest = firstNum;
            float secondInSequenece = secondNum;
            float thirdInSequenece = thirdNum;

            if (biggest < secondInSequenece && biggest >= thirdInSequenece)
            {
                secondInSequenece = biggest;
                biggest = secondNum;

                if (biggest < thirdInSequenece)
                {
                    biggest = thirdInSequenece;
                    thirdInSequenece = secondInSequenece;
                }
            }
            if (biggest < thirdInSequenece)
            {
                thirdInSequenece = biggest;
                biggest = thirdNum;
            }

            Console.WriteLine("{0} {1} {2}", biggest, secondInSequenece, thirdInSequenece);
        }
    }
}



/*
Description
Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Don’t use arrays and the built-in sorting functionality.


Input
On the first three lines, you will receive the three numbers, each on a separate line.

Output
Output a single line on the console - the sorted numbers, separated by a whitespace

Constraints
The three numbers will always be valid integer numbers in the range [-1000, 1000]
Time limit: 0.1s
Memory limit: 16MB
*/