using System;

class Program
{
    // Main function for displaying all the prompts and results
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareOfNumber = SquareNumber(userNumber);

        DisplayResults(userName, squareOfNumber);

    }

    // Function for displaying the welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function for asking the user name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    // Function for asking the user to enter a number
    static int PromptUserNumber()
    {
        Console.Write("Plese enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    // Funtion for finding the square of the entered number
    static int SquareNumber(int userNumber)
    {
        int squareOfNumber = userNumber * userNumber;
        return squareOfNumber;
    }

    // Function for displaying the results
    static void DisplayResults(string userName, int squareOfNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareOfNumber}.");
    }
}