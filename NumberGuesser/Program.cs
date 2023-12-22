using System;

// name space
namespace NumberGuesser
{
    // main class
    internal class Program
    {
        // empty point method
        static void Main(string[] args)
        {
            // run getappinfo function to get info
            GetAppInfo();

            //ask for users name and greet
            GreetUser();

            while (true)
            {

            // init correct number 
            //int correctNumber = 7;

            //create a new random object
            Random random = new Random();

            // init guess var
            int correctNumber = random.Next(1, 10);

            // init guess var
            int guess = 0;

            // ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            // while guess is not correct
            while (guess != correctNumber)
            {
                // get users input
                string input = Console.ReadLine();

                // make sure it's a number 
                if (!int.TryParse(input, out guess))
                {

                // print color message
                 PrintColorMessage(ConsoleColor.Red, "Please use a number");
                            
                    //keep going
                    continue;

                }

                // cast to int and put in "guess" var
                guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // print color message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                    }

                //output success message 
                // print color message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");


                // ask user if they want to play again
                Console.WriteLine("play again? [Y or N]");

            //get answer
            string answer = Console.ReadLine().ToUpper();

            if (answer == "Y")
            {
                continue;
            }
            else if (answer == "N")
            {
                return;
            }
            else
            {
                return;
            }
          }
        }

        //get and display app info
        static void GetAppInfo()
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = " Emily Reese";

            //CHange text color 
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info 
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color
            Console.ResetColor();

        }

        // ask users name and greet
        static void GreetUser () {
            // ask users name 
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);
        }

        // print color message
        static void PrintColorMessage (ConsoleColor color, string message)
        {
            //CHange text color 
            Console.ForegroundColor = color;

            // tell user its not a number
            Console.WriteLine(message);

            // reset text color
            Console.ResetColor();
        }
    }
}
