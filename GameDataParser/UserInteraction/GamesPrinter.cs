using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameDataParser.Model;

namespace GameDataParser.UserInteraction
{
    internal class GamesPrinter : IGamesPrinter
    {
        private readonly IUserInteractor _userInteractor;

        public GamesPrinter(IUserInteractor userInteractor)
        {
            _userInteractor = userInteractor;
        }

        public void Print(List<VideoGame> videoGames)
        {
            if (videoGames.Count > 0)
            {
                _userInteractor.PrintMessage("");
                _userInteractor.PrintMessage("Loaded Games are:");
                foreach (var game in videoGames)
                {
                    _userInteractor.PrintMessage(game.ToString());
                }
            }
            else
            {
                _userInteractor.PrintMessage("No games found in the file.");
            }
        }
    }
}
