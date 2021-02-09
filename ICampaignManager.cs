using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public interface ICampaignManager
    {
        void Add(Game game, Campaign campaign);
        void Delete(Game game, Campaign campaign);
        void Update(Game game, Campaign campaign);
    }
}
