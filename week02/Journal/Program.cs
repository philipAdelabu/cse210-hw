using System;
using System.IO;

class Program
{

   
    static void Main(string[] args)
    {

       PromptGenerator getPrompt = new PromptGenerator();
       DateTime theCurrentTime;
       Journal journal = new Journal();
       Files files = new Files();
       string promptText;
       string @entryText;

       string option = Menu();
       while(option != "8"){
       
       if(option == "1"){
       do{
        promptText = getPrompt.GetRandomPrompt();
        Console.WriteLine("To quit to stop entry (q|Q) ");
        Console.WriteLine(promptText);
        Console.Write(" >> ");
        entryText = Console.ReadLine();
        if(entryText == "q" || entryText == "Q") break;
        theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        Entry entry = new Entry(promptText, entryText, date);
        journal.AddEntry(entry);
       }while(entryText != "q" && entryText != "Q");
       }else if(option == "2"){
          journal.DisplayAll();
        }else if(option == "3"){
          files.ShowAllFiles();
        }else if(option == "4"){
            Console.Write("Enter the new file name to create: ");
            string filename_ = Console.ReadLine();
            if(filename_.Trim() != ""){
                if(files.CreateFile(filename_)) Console.WriteLine("File successfull created");
                else Console.WriteLine("File could not be created at the moment, possibly created before.");
            }else Console.WriteLine("Invalid filename.");
        }
        else if(option == "5"){
          Console.Write("Enter the file name to load: ");
          string filename = Console.ReadLine();
          if(filename.Trim() != "" ){
            journal.LoadFromFile(filename);
            Console.WriteLine($"File {filename} loaded successfully");
           }
          else Console.WriteLine("Invalid filename");
        }
       else if(option == "6"){
          Console.WriteLine("Enter the file name to save journal entry: ");
          string filename = Console.ReadLine();
          if(filename.Trim() != ""){
          journal.SaveToFile(filename);
          Console.WriteLine($"Journal entries successfully safe to {filename} ");
          }else{
            Console.WriteLine("Invalid filename.");
          }
        }else if(option == "7"){
            Console.Write("Enter file name to delete: ");
            string filename_ = Console.ReadLine();
           if(files.DeleteFile(filename_))
              Console.WriteLine($"{filename_} successfully deleted.");
           else Console.WriteLine($"{filename_} does not exist.");
        } 
       option = Menu();
       }

    }
 
    static public string Menu(){
        Console.WriteLine("\n *** Menu **** ");
        Console.WriteLine("1 - Add an Entry");
        Console.WriteLine("2 - Display all Entries");
        Console.WriteLine("3 - Show All Files Name Created ");
        Console.WriteLine("4 - Create New File ");
        Console.WriteLine("5 - Load File Content");
        Console.WriteLine("6 - Save Journal To File ");
        Console.WriteLine("7 - Delete File ");
        Console.WriteLine("8 - Exit Program ");
        string option = Console.ReadLine();
        return option;
    }

 
  
}