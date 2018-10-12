using System;

// Namespce
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // run GetappInfo

            AskUssersName();

            while (true)
            {

                // init correct number
                //int correctnumber = 7;

                // create random object
                Random random = new Random();

                //init corrct number
                int correctnumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctnumber)
                {

                    // get users input
                    String input = Console.ReadLine();

                    // make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "Please Use Actual Number");

                        // keep going
                        continue;

                        
                    }
                        int hint;
                        hint = correctnumber - guess;

                    int abshint = Math.Abs(hint);
                        if (abshint == 1)
                        {
                        // Console.WriteLine("you are hot");
                        PrintColor(ConsoleColor.Red,"You Are Hot");
                        }
                        if (abshint == 2)
                         {
                        //Console.WriteLine("You are getting warmer");
                        PrintColor(ConsoleColor.DarkYellow,"You are getting Warmer");
                          }
                    if (abshint > 2)
                    {
                        // Console.WriteLine("you are cold");
                        PrintColor(ConsoleColor.Blue,"You are cold");
                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctnumber)
                    {
                        // tell user wrong number
                        PrintColor(ConsoleColor.Red, "Wrong number please try again");
                    }
           

                    // here is something you should do.

                }
                // Tell Usser they are correct
                PrintColor(ConsoleColor.Yellow, "You Are Correct");
                // ask user to play again
                Console.WriteLine("Play again? [Y or N]");

                String answer = Console.ReadLine().ToUpper();

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

           // Console.ReadKey();



        }

        static void GetAppInfo()
        {
            // Set App Var
            string appName = "Number Guesser";
            String appVersion = "1.0.0";
            string appAuther = "Alan Nix";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app infor
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuther);

            // reset tesxt color
            Console.ResetColor();
        }

        static void AskUssersName()
        {
            // ask users name
            Console.WriteLine("What is your name?");

            // Get users name
            string inputname = Console.ReadLine();

            Console.WriteLine("Hello {0} let's play a game", inputname);


        }

        static void PrintColor(ConsoleColor Color, string Message)
        {

            // change text color
            Console.ForegroundColor = Color;

            // Tell user to enter a number
            Console.WriteLine(Message);

            // reset tesxt color
            Console.ResetColor();
        }

        
    }
}

