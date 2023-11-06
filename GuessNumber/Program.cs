

namespace GuessNumber
{


    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lower, higher;
            int triesCount = 5;
            int userInput;
            Random rand = new Random();

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            higher = rand.Next(number + 1, number + 10);

            Console.WriteLine($"You need to guess number from {lower}" +
                $" to {higher} ");
            Console.WriteLine($"You have {triesCount} left to guess");

            while (triesCount-- > 0)
            {
                Console.Write("Your number: ");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number) 
                { 
                    Console.WriteLine("You're right, that's was number " + number);
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong, try one more time");
                }
                  
            }

            if (triesCount < 0)
            {
            Console.WriteLine("You've not more attempts, that's was number: " + number);
            }

        }
    }
}