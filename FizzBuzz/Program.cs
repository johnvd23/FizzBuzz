using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fizz Buzz Value:");
            string textToDoThingsTo = Console.ReadLine();
            var fbp = new FizzBuzzProcessor(textToDoThingsTo);
        }
    }
}
