using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class Player:IPlayer
    {
        public int PlayerId { get; set; }
        public string PlayerTcNo { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int PlayerBirthYear { get; set; }
    }
}
