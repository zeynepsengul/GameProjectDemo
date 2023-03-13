
//musteri olusturma 
using Business;
using Entities;

Customer customer1 = new Customer(); 
customer1.CustomerId = 1;
customer1.CustomerTC = "12345678910";
customer1.CustomerSurname = "Şengül";
customer1.CustomerName = "Zeynep";
customer1.BirthYear = 2001;


//oyun olustur
Game game1 = new Game();
game1.GameId = 1;
game1.GameName = "GTA5";
game1.GamePrice = 100;

//kampanya oluştur 

Campaign campaign1 = new Campaign();
campaign1.CampaignId = 1;
campaign1.CampaignName = "Gel Al";
campaign1.CampaignDiscount = 20;

//satıs denemesi yap 

Sale sale1 = new Sale(game1,customer1);
sale1.Sales(campaign1);

Console.ReadLine();