using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class PlayerManager : IPlayerManager
    {
        IAuthentication _authentication;


        public PlayerManager(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public void Add(Player player)
        {
            if (_authentication.Confirmation(player)==true)
            {
                Console.WriteLine("{0} adlı oyuncu eklendi." , player.PlayerFirstName);
            }
            else
            {
                Console.WriteLine("{0} için kimlik doğrulama başarısız. Kayıt yapılamadı.",player.PlayerFirstName);
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("{0} adlı oyuncu kaydı silindi." + player.PlayerFirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("{0} adlı oyuncu bilgileri eklendi." + player.PlayerFirstName);
        }
    }
}
