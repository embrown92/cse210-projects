using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your total score? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letterGrade = "";

        if (number >= 90)
        {
            letterGrade = "A";
        }
        else if (number >= 80)
        {
            letterGrade = "B";
        }

        else if (number >= 70)
        {
            letterGrade = "C";
        }

        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        if (number >= 67 && number <= 69 || number >= 77 && number <= 79 || number >= 87 && number <= 89 || number >= 97)
        {
            Console.WriteLine($"You got a/an {letterGrade}+!");
        }
        else
        {
            Console.WriteLine($"You got a/an {letterGrade}!");
        }

        if (number >= 70)
        {
            Console.WriteLine("Congratualtions you passed!");
        }
        else
        {
            Console.WriteLine("Try again next time.");
        }


    }
}