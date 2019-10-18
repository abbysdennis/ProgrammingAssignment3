using System;

namespace ProgramAssignment3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //This is the line of code that has the user bet their amount 
            Console.WriteLine("Please enter the amount of gil in your pocket: ");
            string userAmount = Console.ReadLine();
            int gilAmount;

            bool notValid = true;

            //This portion of the code compares the amount of gil in the user's pocket to see if it is a valid amount
            if (int.TryParse(userAmount, out gilAmount))
            {
                if (gilAmount >= 1 && gilAmount <= 1000000000)
                {
                    notValid = false;
                }
            }

            //This portion of the code provides an error message for any incorrent amount or character
            while (notValid)
            {
                Console.WriteLine("Please enter a valid choice: ");
                userAmount = Console.ReadLine();

                if (int.TryParse(userAmount, out gilAmount))
                {
                    if (gilAmount >= 1 && gilAmount <= 1000000000)
                    {
                        notValid = false;
                    }
                }

            }

            CreateMenu(ref gilAmount);
        }

        public static void CreateMenu(ref int gilAmount)
        {
            string menuChoice = GetMenuChoice();

            while (menuChoice != "4")
            {
                if (menuChoice == "1")
                {
                    //This portion of the code welcomes the user to the game "Slot Machine" when they select option 1 from the menu
                    Console.WriteLine("");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    Console.WriteLine("Welcome to Slot Machine");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    //This portion of the code brings the user into the game "Slot Machine" by directing to the method 
                    SlotMachine(ref gilAmount);
                }

                else if (menuChoice == "2")
                {
                    //This portion of the code welcomes the user to the game "Dice" when they select option 2 from the menu
                    Console.WriteLine("");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    Console.WriteLine("Welcome to Dice");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    //This portion of the code brings the user into the game "Dice" by directing to the method
                    Dice(ref gilAmount);
                }

                else
                {
                    //This portion of the code welcomes the user to the game "Roulette" when they select option 3 from the menu
                    Console.WriteLine("");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    Console.WriteLine("Welcome to Roulette");
                    Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
                    //This portion of the code brings the user into the game "Roulette" by directing to the method
                    Roulette(ref gilAmount);
                }

                //This line of code brings the user back to the menu after playing and completing a game
                menuChoice = GetMenuChoice();
            }

            //This gives the user an exit message before exiting the game
            if (menuChoice == "4")
            {
                Console.WriteLine("Thanks for playing!");
            }
        }

        public static string GetMenuChoice()
        {
            //This portion of the code outputs the user menu options
            Console.WriteLine("");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("Welcome to Jolly Jackpot Land!");
            Console.WriteLine("Please select an option from the menu below: ");
            Console.WriteLine("1: Slot Machine");
            Console.WriteLine("2: Dice");
            Console.WriteLine("3: Roulette");
            Console.WriteLine("4: Exit");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("");

            //This portion of the code records the user's choice option
            string userInput = Console.ReadLine();
            int choice;
            bool notValid = true;

            //This portion of the code compares the user's choice to see if it is a valid option
            if (int.TryParse(userInput, out choice))
            {
                if (choice >= 1 && choice <= 4)
                {
                    notValid = false;
                }
            }

            //This portion of the code provides an error message for any incorrent number or character
            while (notValid)
            {
                Console.WriteLine("Please enter a valid choice: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {
                        notValid = false;
                    }
                }

            }

            return choice + "";
        }

        //This portion of the code creates the game "Slot Machine"
        public static void SlotMachine(ref int gilAmount)
        {
            Console.WriteLine("Please enter amount of gil you want to bet (more than 0 gil): ");
            //This portion of the code records the user's gil to bet
            string userInput = Console.ReadLine();
            int gilBet;
            bool notValid = true;

            //This portion of the code compares the user's choice to see if it is a valid option
            if (int.TryParse(userInput, out gilBet))
            {
                if (gilBet >= 1 && gilBet <= gilAmount)
                {
                    notValid = false;
                }
            }

            //This portion of the code provides an error message for any incorrent number or character
            while (notValid)
            {
                Console.WriteLine("Please enter a valid amount of gil to bet: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out gilBet))
                {
                    if (gilBet >= 1 && gilBet <= gilAmount)
                    {
                        notValid = false;
                    }
                }

            }

            int num1 = RandomNumber(1, 7);

            int num2 = RandomNumber(1, 7);

            int num3 = RandomNumber(1, 7);

            //This portion of the code is responsible for assigning the first random number to a word
            if (num1 == 1)
            {
                Console.WriteLine("Elephant");
            }
            else if (num1 == 2)
            {
                Console.WriteLine("Computer");
            }
            else if (num1 == 3)
            {
                Console.WriteLine("Football");
            }
            else if (num1 == 4)
            {
                Console.WriteLine("Resume");
            }
            else if (num1 == 5)
            {
                Console.WriteLine("Capstone");
            }
            else
            {
                Console.WriteLine("Crimson");
            }

            //This portion of the code is responsible for assigning the second random number to a word
            if (num2 == 1)
            {
                Console.WriteLine("Elephant");
            }
            else if (num2 == 2)
            {
                Console.WriteLine("Computer");
            }
            else if (num2 == 3)
            {
                Console.WriteLine("Football");
            }
            else if (num2 == 4)
            {
                Console.WriteLine("Resume");
            }
            else if (num2 == 5)
            {
                Console.WriteLine("Capstone");
            }
            else
            {
                Console.WriteLine("Crimson");
            }

            //This portion of the code is responsible for assigning the third random number to a word
            if (num3 == 1)
            {
                Console.WriteLine("Elephant");
            }
            else if (num3 == 2)
            {
                Console.WriteLine("Computer");
            }
            else if (num3 == 3)
            {
                Console.WriteLine("Football");
            }
            else if (num3 == 4)
            {
                Console.WriteLine("Resume");
            }
            else if (num3 == 5)
            {
                Console.WriteLine("Capstone");
            }
            else
            {
                Console.WriteLine("Crimson");
            }

            Console.WriteLine("");

            //This portion of the code prints out whether or not the user won anything
            if ((num1 == num2) && (num1 == num3) && (num2 == num3))
            {
                int totalWon = gilBet * 3;
                Console.WriteLine("Congratulations!  You won " + totalWon);
                Console.WriteLine("");
                gilAmount = totalWon + gilAmount;
            }
            else if ((num1 == num2) || (num1 == num3) || (num2 == num3))
            {
                int totalWon = gilBet * 2;
                Console.WriteLine("Congratulations!  You won " + totalWon);
                Console.WriteLine("");
                gilAmount = totalWon + gilAmount;
            }
            else
            {
                gilAmount = gilAmount - gilBet;
                Console.WriteLine("Sorry, none of the words match");
                Console.WriteLine("You lost {0} gil.", gilBet);
                Console.WriteLine("");
            }

            Console.WriteLine("You now have {0} in your pocket.", gilAmount);
            Console.WriteLine("");
        }
        
        //This portion of the code creates the game "Dice"
        public static void Dice(ref int gilAmount)
        {
            //This portion of the code calls the function to get each result of each rolled die
            int num1 = RandomNumber(1, 7);

            int num2 = RandomNumber(1, 7);

            int num3 = RandomNumber(1, 7);

            int num4 = RandomNumber(1, 7);

            int num5 = RandomNumber(1, 7);

            //This integer is the sum of all the dice
            int diceTotal = num1 + num2 + num3 + num4 + num5;

            //This retrieves the user's guess to be compared to the dice total
            Console.WriteLine("Enter Guess (must be an integer from 5-36): ");
            string userInput = Console.ReadLine();
            int guess;
            bool notValid = true;

            //This portion of the code compares the user's choice to see if it is a valid option
            if (int.TryParse(userInput, out guess))
            {
                if (guess >= 5 && guess <= 36)
                {
                    notValid = false;
                }
            }

            //This portion of the code provides an error message for any incorrent number or character
            while (notValid)
            {
                Console.WriteLine("Please enter a valid guess (must be an integer from 5-36): ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out guess))
                {
                    if (guess >= 5 && guess <= 36)
                    {
                        notValid = false;
                    }
                }

            }

            gilAmount = gilAmount - 3;
            int count = 0;
            count++;

            while( (diceTotal != guess) && (count < 4) )
            {
                if (guess > diceTotal)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, too high.  Guess again: ");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Sorry, too low.  Guess again: ");
                }

                Console.WriteLine("Enter Guess (must be an integer from 5-36): ");
                userInput = Console.ReadLine();
                notValid = true;

                //This portion of the code compares the user's choice to see if it is a valid option
                if (int.TryParse(userInput, out guess))
                {
                    if (guess >= 5 && guess <= 36)
                    {
                        notValid = false;
                    }
                }

                //This portion of the code provides an error message for any incorrent number or character while the user is guessing
                while (notValid)
                {
                    Console.WriteLine("Please enter a valid guess (must be an integer from 5-36): ");
                    userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out guess))
                    {
                        if (guess >= 5 && guess <= 36)
                        {
                            notValid = false;
                        }
                    }

                }
                count++;
            }

            if(diceTotal == guess)
            {
                Console.WriteLine("");
                Console.WriteLine("Correct!  You won 50 gil!");
                gilAmount = gilAmount + 50;
                Console.WriteLine("");
                Console.WriteLine("You now have {0} in your pocket.", gilAmount);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                int gilLost = count * 3;
                Console.WriteLine("You Lost!  The dice total equaled {0}", diceTotal);
                Console.WriteLine("You lost {0} gil", gilLost);
                Console.WriteLine("You now have {0} in your pocket.", gilAmount);
                Console.WriteLine("");
            }
        }

        //This potion of the code creates the game "Roulette"
        public static void Roulette(ref int gilAmount)
        {
            Console.WriteLine("Please enter amount of gil you want to bet (more than 0 gil): ");
            //This portion of the code records the user's gil to bet
            string userInput = Console.ReadLine();
            int gilBet;
            bool notValid = true;

            //This portion of the code compares the user's choice to see if it is a valid option
            if (int.TryParse(userInput, out gilBet))
            {
                if (gilBet >= 1 && gilBet <= gilAmount)
                {
                    notValid = false;
                }
            }

            //This portion of the code provides an error message for any incorrent number or character
            while (notValid)
            {
                Console.WriteLine("Please enter a valid amount of gil to bet: ");
                userInput = Console.ReadLine();

                if (int.TryParse(userInput, out gilBet))
                {
                    if (gilBet >= 1 && gilBet <= gilAmount)
                    {
                        notValid = false;
                    }
                }

            }

            Console.WriteLine("What color would you like to bet on?  Red or Black? ");
            string color = Console.ReadLine().ToLower();
           // color = string.ToLower();

            //This loops an error message if the user does not enter either black or red
            while (color != "red" && color != "black")
            {
                Console.WriteLine("Error: not a valid color option.");
                Console.WriteLine("Please enter a valid color to bet on: ");
                color = Console.ReadLine().ToLower();
                Console.WriteLine("");
            }

            //This line chooses a random number between 1 and 36
            int num = RandomNumber(1, 37);

            Console.WriteLine("Number is " + num);

            //This assigns each number to a color to see if you won or not
            if( (color == "red") && (num == 1 || num == 3 || num == 5 || num == 7 || num == 9 || num == 12 || num == 14 || num == 16 || num == 18 || num == 19 || num == 21 || num == 23 || num == 25 || num == 27 || num == 30 || num == 32 || num == 34 || num == 36))
            {
                Console.WriteLine("Congratulations!");
                int gilWon = gilBet * 2;
                Console.WriteLine("You won {0} gil!", gilWon);
                gilAmount = gilWon + gilAmount;
            }

            else if( (color == "black") && (num == 2 || num == 4 || num == 6 || num == 8 || num == 10 || num == 11 || num == 13 || num == 15 || num == 17 || num == 20 || num == 22 || num == 24 || num == 26 || num == 28 || num == 29 || num == 31 || num == 33 || num == 35))
            {
                Console.WriteLine("Congratulations!  You won!");
                int gilWon = gilBet * 2;
                Console.WriteLine("You won {0} gil!", gilWon);
                gilAmount = gilWon + gilAmount;
            }

            //If the user didn't choose the color, then this error message with the amount of gil the user lost will be displayed
            else
            {
                Console.WriteLine("Too bad ;(");
                gilAmount = gilAmount - gilBet;
                Console.WriteLine("You lost {0} gil", gilBet);
            }

            Console.WriteLine("You currently have {0} gil", gilAmount);
        }

        //This method was created to find the random numbers needed for each of the 3 games
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
