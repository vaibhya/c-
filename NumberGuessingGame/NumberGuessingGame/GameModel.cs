using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGuessingGame
{
    class GameModel
    {
        int winningNumber;
        int chances=3;
        int counter;
        public void SetRandomNumber()
        {
            counter = 0;
            Random r = new Random();
            winningNumber = r.Next(1, 10);
            Console.WriteLine(winningNumber);
            
        }
        public void AskPlayAgain()
        {
            Console.WriteLine("Would you like to play again?(y/n)");
            String response = Console.ReadLine();
            if (response == "y")
            {
                SetRandomNumber();
                GuessNumber();
                return;
            }
            Environment.Exit(0);
                
        }
       
        public void GuessNumber()
        {
            Console.WriteLine("Guess the Number !");
            Console.WriteLine("I am thinking of number from 1 to 10");
            SetRandomNumber();
            while (counter != chances)
            {
                Console.WriteLine("counter " + counter);
                Console.WriteLine("Your Guess:");
                int guessedNumber =  int.Parse(Console.ReadLine());
                if (guessedNumber == winningNumber)
                {
                    counter++;
                    Console.WriteLine("You guessed it in " + counter + " tries");
                    AskPlayAgain();

                }
                if (counter == chances)
                {
                    AskPlayAgain();
                    return;
                }
                if (guessedNumber < winningNumber)
                {
                    Console.WriteLine("Too Low");
                    counter++;
                    
                }
                if (guessedNumber > winningNumber)
                {
                    Console.WriteLine("Too Far");
                    counter++;
                    
                }
                
            }
        }
        
    }
}
