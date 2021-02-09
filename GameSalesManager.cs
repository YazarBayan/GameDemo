using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class GameSalesManager : IGameSalesManager
    {
        public void Add(Game game,Player player)
        {
            Console.WriteLine("{0} oyununun satışı, {1} adlı kullanıcıya kaydedildi.", game.GameName, player.PlayerFirstName);
        }

        public void Delete(Game game, Player player)
        {
            Console.WriteLine("{0} nolu oyun silindi.", game.GameId);
        }

        public void Update(Game game, Player player)
        {
            Console.WriteLine("{0} nolu oyun güncellendi." + game.GameId);
        }
    }
}
