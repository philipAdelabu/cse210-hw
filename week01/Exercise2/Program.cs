using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your percentage grade: ");
        string percentage = Console.ReadLine();
        int p_grade = int.Parse(percentage);
        string message = "Your grade is : ";
        if (p_grade >= 90){
            Console.WriteLine($"{message } A");
        }else if(p_grade >= 80 && p_grade < 90){
            Console.WriteLine($"{message} B");
        }else if(p_grade >= 70 && p_grade < 80){
            Console.WriteLine($"{message} C");
        }else if(p_grade >= 60 && p_grade < 70){
            Console.WriteLine($"{message} D");
        }else{
            Console.WriteLine($"{message} F");
        }
            
    }
}