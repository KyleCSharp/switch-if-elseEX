using System;

namespace SelectionStatementsEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1 if else
           var r = new Random();
            var favNumber = r.Next(1,1000);
            Console.WriteLine("Try and guess my favorite number");
            var userInput = int.Parse(Console.ReadLine());

            
            if (userInput < favNumber) Console.WriteLine("too low");

            else if (userInput > favNumber) Console.WriteLine("too high");

            else Console.WriteLine("nevermind");

            //Ex 2 switch/case
            Console.WriteLine("what is your favorite school subject" +
                "Math, science, Computer science, gym, computer repair class");

            var userAnswer = (Console.ReadLine());

            switch (userAnswer)
            {
                case "math":
                    Console.WriteLine("Math is cool, so many numbers though!");
                    break;

               case "science":
                    Console.WriteLine("science is fun i like doing dry ice bombs.");
                    break ;

                    case "computer science":
                    Console.WriteLine("computer science is fun...that's why im learning code, I like computers!");
                    break;

                case "gym":
                    Console.WriteLine("Gym sucks I hated the pacer test but gotta burn those calories though.");
                    break;

                case "computer repair class":
                    Console.WriteLine("computer repair is fun as well, gotta know all ins and outs. ");
                    break;


                    default: Console.WriteLine("Never heard of that subject");
                    break;

            }

            







        }
        
       
    }
}
