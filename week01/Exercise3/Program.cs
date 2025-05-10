using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your magic number?");
        int magic_number = int.Parse(Console.ReadLine());
        string next = "yes";
        int attempt = 1;
        while(next == "yes" ){
            Console.Write("What is your guess?");
            int guess = int.Parse(Console.ReadLine());
            if(guess > magic_number){
                  Console.WriteLine("Your guess is high, try a lower number");
            }else if(guess < magic_number){
                 Console.WriteLine("Your guess is low, try a higher one.");
            }else{
                Console.WriteLine("You guessed it !!");
                Console.WriteLine("Would you like to play again (yes|no) ?");
               next = Console.ReadLine();
                if(next == "no")
                   break;
            }
            
            attempt++;
        }
        Console.WriteLine($"Number of attemp: {attempt}");
    }
}