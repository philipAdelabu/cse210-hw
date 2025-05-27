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
    List<Scripture> scriptures = books.GetSricptures();
    Random rand = new Random();
    int rd = rand.Next(0, scriptures.Count - 1);
    Scripture scripture = scriptures[rd];

    Random rnd = new Random();
    int rdn = rnd.Next(2, 4);

    MultipleScripture multiple = new MultipleScripture(scripture.GetReference(), scripture.GetReference().GetStartVerse() + rdn);

    Random rad = new Random();
    int r = rad.Next(1, 3);
    if (r == 1)
    {
      Console.WriteLine(scripture.GetDisplayText());
      string prompt = Console.ReadLine();
      while (prompt != "quit")
      {
        Console.Clear();
        Console.WriteLine(scripture.HideRandomWords(4));
        if (scripture.IsCompletelyHidden() == true) break;
        prompt = Console.ReadLine();
      }
    }
    else
    {

      Console.WriteLine(multiple.GetDisplayText());
      string prompt = Console.ReadLine();
      while (prompt != "quit")
      {
        Console.Clear();
        Console.WriteLine(multiple.HideRandomWords(4));
        if(multiple.IsCompletelyHidden() == true) break;
        prompt = Console.ReadLine();
      }

    }

    return;
  }

}