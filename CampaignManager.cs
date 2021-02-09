using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo
{
    public class CampaignManager : ICampaignManager
    {
       
        public void Discount(Game game,Campaign campaign)
        {
            double discount= game.GameUnitPrice - game.GameUnitPrice * (campaign.CampaignDiscount / 100);
            Console.WriteLine("Önceki fiyat: {0} TL - İndirimli fiyat: {1} TL dir.",game.GameUnitPrice ,discount);
        }
        public void Add(Game game, Campaign campaign)
        {
            Console.WriteLine("{0} adlı oyunda, {1} !!!" ,game.GameName, campaign.CampaignName);
        }

        public void Delete(Game game, Campaign campaign)
        {
            Console.WriteLine("{0} adlı kampanya eklendi." + campaign.CampaignName);
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("{0} adlı kampanya eklendi." + campaign.CampaignName);
        }
    }
}
