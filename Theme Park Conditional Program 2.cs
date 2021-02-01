using System;
class Program
{
    //In this program, the user has to guess the random number (1-10)
    static void Main()
    {
        Console.WriteLine("Simple Guessing Game");

        Random random = new Random();

        int secretNumber = random.Next(1, 11);

        Console.WriteLine("Guess the random number!");
        string inputString = Console.ReadLine();

        int userGuess = int.Parse(inputString);

        if (secretNumber == userGuess)
        {
            Console.WriteLine("Congratulations, you win!");
        }
        else
        {
            Console.WriteLine("Sorry, you lose!");
        }
    }
}

