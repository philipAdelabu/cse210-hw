using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
    }


      static int Menu(){
      Console.Clear();
      Console.WriteLine("Menu Options:");
      Console.WriteLine("\t 1. Create New Goal");
      Console.WriteLine("\t 2. List Goals");
      Console.WriteLine("\t 3. Save Goals");
      Console.WriteLine("\t 4. Load Goals");
      Console.WriteLine("\t 5. Record Event");
      Console.WriteLine("\t 6. Quit");
      Console.Write("Select an option from the menu: ");
      int option = int.Parse(Console.ReadLine());
      while(option > 6 || option < 1){
         Console.WriteLine("You entered the wrong option.");
          Console.Write("Select an option from the menu: ");
          option = int.Parse(Console.ReadLine());
      }
      return option;  
    }
}