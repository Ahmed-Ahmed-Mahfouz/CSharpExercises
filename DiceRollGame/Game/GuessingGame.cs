using DiceRollGame.UserCommunication;

namespace DiceRollGame.Game
{
    internal class GuessingGame
    {
        private readonly Dice _dice;
        private readonly int _guesses;

        public GuessingGame(Dice dice, int guesses)
        {
            _dice = dice;
            _guesses = guesses;
        }

        int RollDice() => _dice.Roll();

        public GameResult Play()
        {
            int roleDiceResult = RollDice();
            Console.WriteLine($"Dice rolled. Guess what number it shows in {_guesses} tries");
            for (int i = 0; i < _guesses; i++)
            {
                int guess = ConsoleReader.ReadNumber("Enter a number: ");
                if (guess == roleDiceResult)
                {

                    return GameResult.Win;
                }
                if (i < _guesses - 1)
                    ConsoleWriter.WriteMessage("Try again!");
            }
            return GameResult.Loose;
        }

        public static void PrintResult(GameResult gameResult)
        {
            string message = gameResult == GameResult.Win ? "You win!" : "You loose ):";
            ConsoleWriter.WriteMessage(message);

        }

    }
}