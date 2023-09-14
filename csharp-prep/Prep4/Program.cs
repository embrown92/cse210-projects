using System;

class Program
{
    static void Main(string[] args)
    {
        // Make a new list
        List<int> numbers = new List<int>();

        int numberInput = -1;
        while (numberInput != 0)
        {
            // Ask user to input number and type 0 to stop
            Console.Write("Please enter any number, then type 0 to quit: ");
            string userInput = Console.ReadLine();
            numberInput = int.Parse(userInput);

            // Add all the numbers that is not 0
            if (numberInput != 0)
            {
                numbers.Add(numberInput);
            }

        }

        // Use for loop to find the sum of all the numbers 
        // and then print the total
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum of all numbers is: {sum}.");

        // Find the average of all the numbers in the list then print
        double average = Queryable.Average(numbers.AsQueryable());
        Console.WriteLine($"The average of all the numbers in the list is: {average}.");

        // Find the largest number in the list and print
        int largestNumber = numbers.AsQueryable().Max();
        Console.WriteLine($"The largest number in the list is: {largestNumber} ");
    }

}