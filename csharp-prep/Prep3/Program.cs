using System;

class Program
{
    static void Main(string[] args)
    {
        string response;

        do
        {

            //Console.Write("What is the magic number? ");
            //int MagicNumber = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            int MagicNumber = randomGenerator.Next(1,100);
            Console.WriteLine("A magic number between 1 and 100 has been generator.");

            int guess = 0;

            while (guess != MagicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            
            if (MagicNumber > guess)
            {
                Console.WriteLine ("Higher");

            }
            else if (MagicNumber < guess)
            {
                Console.WriteLine("Lower");

            }
                
            else
            {
                Console.WriteLine("You guessed it!");
            }
            }
        Console.Write("Do you want to continue? ");
        response = Console.ReadLine();


        }   

        while(response == "yes");
         
    }
}