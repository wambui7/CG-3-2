using System;

namespace number_guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("make a guess of number between 1 -20");
            string guesser = Console.ReadLine();

            string winloose = (guesser == "8") ? "win" : "loose";
            Console.WriteLine(guesser + winloose + ".");
            Console.ReadLine();
        }
    }
}
