using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame.Game
{
    internal class Dice
    {
        private readonly Random _random;
        private readonly int _sides;

        public Dice(Random random, int sides)
        {
            _random = random;
            _sides = sides;
        }


        public int Roll() => _random.Next(1, _sides + 1);

    }
}
