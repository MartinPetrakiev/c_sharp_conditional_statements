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

            if (biggest < secondNum)
            {
                biggest = secondNum;
            }
            if (biggest < thirdNum)
            {
                biggest = thirdNum;
            }

            Console.WriteLine("" + biggest);
        }
    }
}



/*
Description
Write a program that finds the biggest of three numbers that are read from the console.

Input
On the first three lines you will receive the three numbers, each on a separate line.

Output
On the only output line, write the biggest of the three numbers.

Constraints
The three numbers will always be valid floating-point numbers in the range [-200, 200].
Time limit: 0.1s
Memory limit: 16MB
*/