using System;

namespace ConsoleAppNewStart
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * block comment
             * many lines
             */ 
             
            Console.WriteLine("Hello World!");
            Console.WriteLine("I love to code");

            string userAgeString = AskUserFor("your age");

            Console.WriteLine("You typed in " + userAgeString + " as your age.");

            int userAge = Convert.ToInt32(userAgeString);

            if(userAge >= 18)
            {
                Console.WriteLine("Welcome to the bar and have a beer.");                
            }
            else
            {
                Console.WriteLine("Welcome to the candy store, want a lollipop?");
            }
        }//end of main method
                
 //modifyer - return tyo - name - parameter inputs       
        static string AskUserFor(string what)
        {
            Console.Write( "Please enter " + what + ": ");
            string userInput = Console.ReadLine();

            return userInput;
        }
    }//end of program class
}//emd pf namespace
