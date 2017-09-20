using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string doAgain = null;
            bool evenOrOdd;
            int integerEntered;

            //Prompt the user to enter their name
            Console.Write("Hello! What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("Hi " + userName + ". Let's find out if numbers are even or odd.");
            Console.WriteLine();

            do
            {
                //Prompt the user to enter a number using the GetInteger() method
                integerEntered = GetInteger();
                
                //Check to see if the number entered is even or odd by calling the CheckIfEven() method
                evenOrOdd = CheckIfEven(integerEntered);

                if (evenOrOdd == false)
                {
                    Console.WriteLine(userName + ", The number that you entered is " + integerEntered + " and that number is odd.");
                }
                else if (evenOrOdd == true)
                {
                    //Determine the range that the even number falls into
                    if (integerEntered >= 2 && integerEntered <= 25)
                    {
                        Console.WriteLine(userName + ", The number that you entered is " + integerEntered + ". That number is even and between 2 - 25.");
                    }
                    else if (integerEntered >= 26 && integerEntered <= 60)
                    {
                        Console.WriteLine(userName + ", The number that you entered is " + integerEntered + ". That number is even and between 26 - 60.");
                    }
                    else
                    {
                        Console.WriteLine(userName + ", The number that you entered is " + integerEntered + ". That number is even and greater than 60.");
                    }
                }
                
                //Prompt the user to continue (or not)
                Console.Write("Would you like to continue (Y/N)? ");
                doAgain = Console.ReadLine().ToUpper();
                Console.WriteLine();
            } while (doAgain == "Y");
           
        }

        static int GetInteger()
        {
            int userInteger;

            Console.Write("Please enter a number between 1 - 100: ");
            userInteger = int.Parse(Console.ReadLine());
            if (userInteger > 0 && userInteger <= 100)
            {
                return userInteger;
            }
            else
            {
                //If the number entered is not between 1-100, then keep asking the user for a different number
                Console.WriteLine("I'm sorry, that number  is not valid. Please enter a different number.");
                userInteger = GetInteger();
                return userInteger;
            }
        }

        static bool CheckIfEven(int integerToCheck)
        {
            bool isEven;

            //If the number is evenly divisible by 2, then the number is even. If not, the number is odd.
            if ((integerToCheck % 2) == 0)
            {
                isEven = true;
            }
            else
            {
                isEven = false;
            }
            return isEven;
        }
        
    }
}
