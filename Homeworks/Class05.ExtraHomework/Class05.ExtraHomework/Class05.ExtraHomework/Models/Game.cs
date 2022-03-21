using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Game
    {
        public int Difficulty { get; }
        int[] attempts = { 9, 7, 5 };
        int[] maxNumber = { 100, 500, 1000 };
        public int RandomNumber
        {
            get
            {
                Random rnd = new Random();
                int randomNum = rnd.Next(maxNumber[Difficulty]);
                return randomNum;
            }
        }
        int targetNumber;

        public Game(int difficulty)
        {
            Difficulty = difficulty - 1;
        }

        public int GetAndParseInput()
        {
            int parsedInput = 0;
            string input = Console.ReadLine();
            while (!int.TryParse(input, out parsedInput))
            {
                Console.WriteLine("You entered an invalid integer. Try again!");
                input = Console.ReadLine();
            }
            return parsedInput;
        }

        public void StartGame()
        {
            targetNumber = RandomNumber;
            Console.WriteLine($"You have {attempts[Difficulty]} attempts to guess a number between 0 and {maxNumber[Difficulty]}");

            for (int i = 0; i < attempts[Difficulty]; i++)
            {
                Console.WriteLine($"Attemt number {i + 1}");
                int guessedNumber = GetAndParseInput();
                if (i == 0 && guessedNumber == targetNumber)
                {
                    Console.WriteLine("You lucky bastard! If you want to rety press 1");
                    Retry();
                }
                if (guessedNumber != targetNumber)
                {
                    GiveHints(guessedNumber);
                }
                if (guessedNumber == targetNumber)
                {
                    Console.WriteLine($"Nailed it! Number entered: {10}. If you want to retry press 1");
                    Retry();
                }
            }
            Console.WriteLine("Try again. If you want to start another game press 1");
            Retry();
        }

        public void Retry()
        {
            string retry = Console.ReadLine();
            if (retry == "1")
            {
                StartGame();
            }
            else
            {
                return;
            }
        }


        public void GiveHints(int guessedNumber)
        {
            if(guessedNumber > targetNumber)
            {
                if(guessedNumber - targetNumber <= 10)
                {
                    Console.WriteLine($"Your guess is a little big higher, number entered: {guessedNumber}");
                }
                else if(guessedNumber - targetNumber > 10)
                {
                    Console.WriteLine($"Your guess is a far big higher, number entered: {guessedNumber}");
                }
            }
            else if(guessedNumber < targetNumber)
            {
                if(targetNumber - guessedNumber <= 10)
                {
                    Console.WriteLine($"Your guess is a little big lower, number entered: {guessedNumber}");
                }
                else if(targetNumber - guessedNumber > 10)
                {
                    Console.WriteLine($"Your guess is a far big lower, number entered: {guessedNumber}");
                }
            }
        }
    }
}
