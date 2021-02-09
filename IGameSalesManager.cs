using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IGameSalesManager
    {
        void Add(Game game,Player player);
        void Delete(Game game, Player player);
        void Update(Game game, Player player);
    }
}
