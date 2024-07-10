// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;

Console.WriteLine("Welcome to the COIN FLIP CHALLENGE!");
Console.WriteLine("What is your name?");
var name = Console.ReadLine();
Console.WriteLine("Welcome"+" "+ name+". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
var choice = Console.ReadLine();
if (choice == null || (!choice.Equals("yes", StringComparison.OrdinalIgnoreCase)&&(!choice.Equals("No",StringComparison.OrdinalIgnoreCase))))// checking for null values
{
    Console.WriteLine("Invalid Input");
    return;
}
if (choice.Equals("Yes",StringComparison.OrdinalIgnoreCase)) 
{
    int score = 0;
    int numberOfFlips = 5;
    Random random = new(); // initializing random
    for (int i = 0; i < numberOfFlips; i++)
    {
        int flip =  random.Next(2);// Generate 0 or 1
        Console.WriteLine("Heads or Tails?");
        string? userGuess = Console.ReadLine();// nullable string
        string coinSide = flip == 0 ? "heads" : "tails";// ternary operator if it is true =0(heads) false=1(tails)
        if(userGuess == null || (!userGuess.Equals("heads",StringComparison.OrdinalIgnoreCase) && (!userGuess.Equals("tails", StringComparison.OrdinalIgnoreCase)))){
            Console.WriteLine("Invalid Input");
            continue;
        }

        if (userGuess.Equals(coinSide,StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong!");
        }

    }
    Console.WriteLine("Thank you"+" "+ name+". "+"You got a score of"+ score+"!");
}
else
{
    Console.WriteLine("You are Coward "+" "+name);
}