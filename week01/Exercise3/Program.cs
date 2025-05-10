using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("The game of number guess.");
        Random  generator = new Random();
        int magic_number =  generator.Next(1, 100); //int.Parse(Console.ReadLine());
        string next = "yes";
        int attempt = 1;
        while(next == "yes" ){
            Console.Write("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());
            if(guess > magic_number){
                  Console.WriteLine("Your guess is high, try a lower number");
            }else if(guess < magic_number){
                 Console.WriteLine("Your guess is low, try a higher one.");
            }else{
                Console.WriteLine("You guessed it !!");
                 Console.WriteLine($"Number of attemp: {attempt}");
                Console.Write("Would you like to play again (yes|no) ? ");
                attempt = 0;
               next = Console.ReadLine();
                if(next == "no")
                   break;
               magic_number =  generator.Next(1, 100);
            }
            
            attempt++;
        }
       
    }
}