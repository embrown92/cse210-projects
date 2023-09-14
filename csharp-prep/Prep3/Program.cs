using System;

class Program
{
    static void Main(string[] args)

    {

        Console.Write("Guess the magic number between 1 and 100.");
        // int magicNumber = 6;

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write(" What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}