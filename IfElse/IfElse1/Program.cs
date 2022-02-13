using System;

namespace IfElse1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("IfElse");
            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Thanks. Now Enter A Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());
            if (num >= 6)
            {
             Console.WriteLine("\nNumber Exceeds 5");
             //Nested statement to be inserted here (Step 5).
             //i hate spam bots!
            }
            else
            {
             Console.WriteLine("\nNumber is 5 Or Less");
            }
            Console.ReadKey();
            if(letter == 'C')
            {
                Console.WriteLine("Letter Is 'C'");
            }
        }
    }
}
