using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Authentication : IAuthentication
    {
        public bool Confirmation(Player player)
        {
            if (player.PlayerFirstName=="Banu" && player.PlayerLastName=="Çinar" && player.PlayerTcNo=="18407620110" && player.PlayerBirthYear==1989)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
