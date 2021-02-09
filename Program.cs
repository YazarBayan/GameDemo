using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oyuncu Kaydı:");
            PlayerManager playerManager = new PlayerManager(new Authentication());
            List<PlayerManager> players = new List<PlayerManager>();
            Player player1 = new Player();    
            player1.PlayerId = 1;
            player1.PlayerTcNo = "18407620110";
            player1.PlayerFirstName = "Banu";
            player1.PlayerLastName = "Çinar";
            player1.PlayerBirthYear  = 1989;
            playerManager.Add(player1);

            Player player2 = new Player();
            player2.PlayerId = 2;
            player2.PlayerTcNo = "15896237465";
            player2.PlayerFirstName = "Sema";
            player2.PlayerLastName = "Yaşar";
            player2.PlayerBirthYear = 2020;
            playerManager.Add(player2);

            foreach (var player in players)
            {
                Console.WriteLine(player);
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Kayıtlı oyunları ve bilgilerini görmek için Tıklayınız...");
            Console.ReadKey();
            GameSalesManager gameSalesManager = new GameSalesManager();
            List<Game> games = new List<Game>();
            Game game1 = new Game();
            game1.GameId = 1000 ;
            game1.GameName = "Cyberpunk";
            game1.GameType = "Aksiyon / Macera";
            game1.GameUnitPrice = 400;
            gameSalesManager.Add(game1,player1);

            Game game2 = new Game();
            game2.GameId = 2000;
            game2.GameName = "Assassins Creed Odyssey";
            game2.GameType = "Strateji";
            game2.GameUnitPrice = 150;
            gameSalesManager.Add(game2,player2);

            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Kampanyaları görmek için Tıklayınız...");
            Console.ReadKey();
            CampaignManager campaignManager = new CampaignManager();
            List<Campaign> campaigns = new List<Campaign>();
            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 9;
            campaign1.CampaignName = "%20 İndirim";
            campaign1.CampaignDiscount = 20;
            campaignManager.Add(game1 ,campaign1);
            campaignManager.Discount(game1, campaign1);

            Campaign campaign2 = new Campaign();
            campaign2.CampaignId = 10;
            campaign2.CampaignName = "%50 İndirim";
            campaign2.CampaignDiscount = 50;
            campaignManager.Add(game2 ,campaign2);
            campaignManager.Discount(game2, campaign2);

            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.CampaignName);
            }





            Console.ReadLine();
        }
    }
}
