/*
  For creativity i added the whole bible books in a csv format. The will enable a random selection of the 
  scriptures. 
*/

using System;

class Program
{


    static void Main(string[] args)
    {
       

         Scriptures books = new Scriptures();
         List<Scripture>  scriptures = books.GetSricptures();
         Random rand = new Random();
         int rd = rand.Next(0, scriptures.Count -1);
         Scripture scripture = scriptures[rd];
    
        Console.WriteLine(scripture.GetDisplayText());
         string prompt = Console.ReadLine();
         while(prompt != "quit" || scripture.IsCompletelyHidden() != true){
            Console.Clear();
            Console.WriteLine(scripture.HideRandomWords(4));
            prompt = Console.ReadLine();
         }
         if(scripture.IsCompletelyHidden() == true)
             Console.WriteLine(scripture.HideRandomWords());
        return;
    }
}