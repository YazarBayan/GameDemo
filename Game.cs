using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Game:IGame
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public double GameUnitPrice { get; set; }

    }
}
