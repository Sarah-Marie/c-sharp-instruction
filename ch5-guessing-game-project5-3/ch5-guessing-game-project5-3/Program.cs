using System;

namespace ch5_guessing_game_project5_3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess The Number Game!");

             int Guess = 0;

             int Target = 0-100;
            

            string choice = "y";

            while (choice.Contains("y") || choice.Contains("Y")) {

                int count = 0;
                Random random = new Random();
                int randNbr = random.Next(1, 100);
                Guess = int Target(1, 100);

                int guess = 0;
                while (guess != randNbr) {
                    if (guess == int Target) 
                        Console.Write("Great Work! You are a mathematical wizard!")
                            {

                    }
                    else 
                }

                Console.Write("I'm thinking of a number between 1 & 100. Try to guess it.");

                string GuessInput = Console.ReadLine();
                Guess = Convert.ToInt32(GuessInput);

                Console.WriteLine("You guessed " + Guess + Target);





            }
        }
    }
}
