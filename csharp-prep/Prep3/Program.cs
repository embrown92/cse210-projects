using System;

class Program
{
    static void Main(string[] args)

    {

        Console.Write("Guess the magic number between 1 and 100.");
        int magicNumber = 6;

        int guessNumber = -1;

        while (guessNumber != magicNumber)
        {
            Console.Write(" What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber < 6)
            {
                Console.WriteLine("Higher!");
            }
            else if (guessNumber > 6)
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