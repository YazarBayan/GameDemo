using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IGame
    {
        int GameId { get; set; }
        string GameName { get; set; }
        string GameType { get; set; }
        double GameUnitPrice { get; set; }
    }
}
