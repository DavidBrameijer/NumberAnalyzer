using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome to the Number Analyzer. What is your name?");
string name = Console.ReadLine();
int number = -1;
bool answer = true;
do
{
    Console.WriteLine($"Thank you {name}. Please choose a number from 1 to 100.");
    number = int.Parse(Console.ReadLine());
    if (number % 2 == 0 && number > 0 && number <= 100)
    {
        if (number >= 2 && number <= 24)
        {
            Console.WriteLine($"{name} your number is even and less than 25.");
        }
        else if (number >= 26 && number <= 60)
        {
            Console.WriteLine($"{name} your number is even and between 26 and 60.");
        }
        else
        {
            Console.WriteLine($"{name} your number is even and greater than 60.");
        }
    }
    else if (number % 2 != 0 && number > 0 && number <= 100)
    {
        if (number < 60)
        {
            Console.WriteLine($"{name} your number is odd and less than 60.");
        }
        else
        {
            Console.WriteLine($"{name} your number is odd and greater than 60.");
        }
    }
    else
    {
        Console.WriteLine($"{name} please enter a valid number.");
        continue;
    }
    Console.WriteLine("Would you like to try again? y/n");
    string choice = Console.ReadLine();
    if (choice == "n")
    {
        Console.WriteLine($"{name} Thanks for playing!");
        break;
    }
    else
    {
        continue;
    }
}

while (answer = true);