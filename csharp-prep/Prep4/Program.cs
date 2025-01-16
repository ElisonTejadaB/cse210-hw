using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Elison Tejada Prep4");
        Console.WriteLine("Enter a list of numbers, Type 0 when finished.");

        List<int> numbers = new List<int>();
        int NewNumbers = -1;
        while(NewNumbers !=0)
        {
            
            Console.Write("Enter Number ");
            string InputNumbers = Console.ReadLine();
            NewNumbers = int.Parse(InputNumbers);

            if (NewNumbers !=0)
            {
                numbers.Add(NewNumbers);
            }
        } 
        int sum =0;
        int number = numbers.Sum();
        {
            sum +=number;
        }
        Console.WriteLine($"The sum is: {sum}"); 

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}"); 

        int LargestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {LargestNumber}");

        numbers.Sort();

        foreach(int NumSort in numbers)
        Console.WriteLine($"The sorted list is: {NumSort}");
        
    }
}