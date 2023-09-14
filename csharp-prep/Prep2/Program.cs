using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your total score? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number >= 90)
        {
            Console.WriteLine("Congratulations, you passed and got an A!");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Congratulations, you passed and got a B!");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Congratulations, you passed and got a C!");
        }
        else if (number >= 60)
        {
            Console.WriteLine("You got a D. Try again next time.");
        }
        else
        {
            Console.WriteLine("You got an F. Try again next time.");
        }
    }
}