using DiceRollGame.Game;

namespace DiceRollGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dice = new Dice(new Random(), 6);
            var guessingGame = new GuessingGame(dice, 3);
            
            GameResult gameResult = guessingGame.Play();    
            GuessingGame.PrintResult(gameResult);
            Console.ReadKey();
        }
    }
}
