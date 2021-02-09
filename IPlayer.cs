using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface IPlayer
    {
        int PlayerId { get; set; }
        string PlayerTcNo { get; set; }
        string PlayerFirstName { get; set; }
        string PlayerLastName { get; set; }
        int PlayerBirthYear { get; set; }
    }
}
