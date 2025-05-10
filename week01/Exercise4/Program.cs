using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        while(number != 0){
            numbers.Add(number);
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
        }

       int sum = 0, largest = numbers[0];
       int smallest = largest;
        sum += numbers[0];
        for(int index = 1; index < numbers.Count; index++){
            int num = numbers[index];
            if(largest < num) 
                 largest = num;
            if(smallest > num && num > 0)
                smallest = num;
         sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbers.Count}");
        Console.WriteLine($"The largest is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        Console.WriteLine($"The sorted list is: ");
        numbers.Sort();
        foreach(int num in numbers)
                 Console.WriteLine(num);
    }
}