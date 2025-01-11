using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade? ");
        int grade = int.Parse(Console.ReadLine());
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter ="B";
        }

        else if (grade >= 70)
        {
            letter ="C";
        }

        else if (grade >= 60)
        {
            letter ="D";
        }
        else
        {
            letter = "F";
        }

        //Challenge

        string sign ="";
        int LastDigit = grade % 10;

        if (LastDigit >= 7)
        {
            sign = "+";
        }
        else if (LastDigit <= 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 93)
        {
            sign ="";
        }
        if (letter == "F")
        {
            sign ="";
        }

        //Message

        Console.WriteLine($"Your letter grade is {letter}{sign}");


        if (grade >= 70)
        Console.WriteLine("Congratulations! You passed the class!");
        
        else
        {
            Console.WriteLine("Stay focused and you'll get it next time!");
        }


    }
}