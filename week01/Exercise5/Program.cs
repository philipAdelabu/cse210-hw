using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, SquareNumber(number));
    }

    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
        return ;
    }
    static string PromptUserName(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber(){
        Console.Write("Enter your favourite number : ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number){
        return number * number;
    }

    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your number is {number}");
        return;
    }
}