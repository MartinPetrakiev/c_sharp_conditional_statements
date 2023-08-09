using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();

            string[] validCards = new string[] {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

            if (Array.IndexOf(validCards, card) >= 0)
            {
                Console.WriteLine("yes {0}", card);
            }
            else
            {
                Console.WriteLine("no {0}", card);
            }

            //Alternative - use swtich case
        }
    }
}



/*
Description
Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints "yes CONTENT_OF_STRING" if it is a valid card sign or "no CONTENT_OF_STRING" otherwise.

Input
On the only line you will receive a single string.

Output
Output "yes CONTENT_OF_STRING" if the string is a card sign, otherwise print "no CONTENT_OF_STRING".

Constraints
String length will always be between 1 and 5
Time limit: 0.1s
Memory limit: 16MB
*/