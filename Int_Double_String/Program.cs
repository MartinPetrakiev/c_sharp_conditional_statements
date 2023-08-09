using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstInput = Console.ReadLine();
            int integerInput = 0;
            double doubleInput = 0.00d;
            string stringInput = "";

            switch (firstInput)
            {
                case "integer":
                    integerInput = int.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine(integerInput);
                    break;
                case "real":
                    doubleInput = double.Parse(Console.ReadLine()) + 1;
                    Console.WriteLine("{0:F2}", doubleInput);
                    break;
                case "text":
                    stringInput = Console.ReadLine() + "*";
                    Console.WriteLine(stringInput);
                    break;
                default:
                    Console.WriteLine("invalid type");
                    break;
            }
        }
    }
}



/*
Description
Write a program that, depending on the first line of the input, reads an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statements.

Input
On the first line you will receive the type of input as string in the following form:
integer for int
real for double
text for string
On the second line you will be given the value of the variable.

Output
Write a single line on the console - the value transformed according to the rules from the description.
Print all double variables with exactly 2-digits precision after the floating point. Example: 0.99

Constraints
The input will always be valid and in the described format.
All input numbers will be between -1000 and 1000.
Time limit: 0.1s
Memory limit: 16MB
*/