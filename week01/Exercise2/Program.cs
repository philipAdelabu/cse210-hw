using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your percentage grade: ");
        string percentage = Console.ReadLine();
        int p_grade = int.Parse(percentage);
        string message = "Your grade is : ";
        char letter;
        if (p_grade >= 90){
            letter = 'A';
        }else if(p_grade >= 80 && p_grade < 90){
             letter = 'B';
        }else if(p_grade >= 70 && p_grade < 80){
             letter = 'C';
        }else if(p_grade >= 60 && p_grade < 70){
             letter = 'D';
        }else{
             letter = 'F';
        }
        
         int last_digit = p_grade % 10;
         string sign = "";
         if(last_digit >= 7 && (letter != 'A' || letter != 'F')){
            sign = "+";
         }
         if(last_digit <= 3 && letter != 'F'){
            sign = "-";
         }

        Console.WriteLine($"{message} {letter}{sign}");
        if(p_grade >= 70){
            Console.WriteLine("Congratulation you pass the course.");
        }else{
            Console.WriteLine("Sorry, you couldn't make it. But, try hard next time.");
        }
    }
}