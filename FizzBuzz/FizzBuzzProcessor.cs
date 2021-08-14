using System;

namespace FizzBuzz
{
    /// <summary>
    ///     1. Sends FizzBuzz results to Console.WriteLine
    ///     2. Sets the string property StringSentToConsole in case a developer would like to utilze the string for other purpose
    /// </summary>
    public class FizzBuzzProcessor
    {
        public FizzBuzzProcessor()
        {
            ProcessErrorType();
        }
        public string StringSentToConsole { get; set; }


        public FizzBuzzProcessor(string input)
        {
            double value;

            if (double.TryParse(input, out value))
            {
                DoTheFizzBuzz(value);
                return;
            }

            ProcessErrorType();
        }
        private void ProcessErrorType()
        {
            StringSentToConsole = "Invalid Item";
            ConsoleLogger(isError: true);
        }

        private void DoTheFizzBuzz(double i)
        {
            bool fizz = i % 3.0 == 0;
            bool buzz = i % 5.0 == 0;
            if (fizz && buzz)
                StringSentToConsole = "FizzBuzz";
            else if (fizz)
                StringSentToConsole = "Fizz";
            else if (buzz)
                StringSentToConsole = "Buzz";
            else
            {
                double fizzdub = i / (double)3;
                double buzzdub = i / (double)5;

                StringSentToConsole = string.Format("Divided {0} by 3: {1}", i.ToString(), fizzdub.ToString());
                StringSentToConsole += Environment.NewLine + string.Format("Divided {0} by 5: {1}", i.ToString(), buzzdub.ToString());
            }
            ConsoleLogger();
        }
        private void ConsoleLogger(bool isError = false)
        {
            var text = String.Format("Fizz Buzz Result: {0}", StringSentToConsole);
            if (isError || StringSentToConsole.Trim() == "")
            {
                // if there is an error, include the Geek Squad phone number.
                text += Environment.NewLine + "For Help please call 1 (800) 433-5778";
            }
            Console.WriteLine(text);
        }
    }
}