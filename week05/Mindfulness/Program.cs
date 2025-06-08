using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int choice = Menu();
        string name;
        string description;
        while(choice != 4){
            Console.Clear();
        switch(choice){
            case 1:
            name = "Breathing";
            description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
            BreathingActivity breathing = new BreathingActivity(name, description);
            breathing.Run();
            break;
            case 2:
            name = "Reflecting";
            description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
            ReflectingActivity reflecting = new ReflectingActivity(name, description);
            reflecting.Run();
            break;
            case 3:
            name = "Listing";
            description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
            ListingActivity listing =  new ListingActivity(name, description);
            listing.Run();
            break;       
        }
        choice =   Menu();
     }

    }

    static int Menu(){
      Console.Clear();
      Console.WriteLine("Menu Options:");
      Console.WriteLine("\t 1. Start breathing activity");
      Console.WriteLine("\t 2. Start reflecting activity");
      Console.WriteLine("\t 3. Start listing activity");
      Console.WriteLine("\t 4. Quit");
      Console.Write("Select a choice from the menu: ");
      int choice = int.Parse(Console.ReadLine());
      while(choice > 4 || choice < 1){
         Console.WriteLine("You entered the wrong choice.");
          Console.Write("Select a choice from the menu: ");
          choice = int.Parse(Console.ReadLine());
      }
      return choice;  
    }


}