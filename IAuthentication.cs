using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{

    public interface IAuthentication
    {
        bool Confirmation(Player player);
    }
}
