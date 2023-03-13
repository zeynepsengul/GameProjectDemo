using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Sale : ISale
    {
        Game _game;
        Customer _customer;
        bool Validate = true;
        public Sale(Game game, Customer customer)
        {
            _game = game;
            _customer = customer;
        }
        public void ValidationService(Customer customer)
        {
            
        }
        public void Sales(Campaign campaign)
        {
            if (Validate==true)
            {
                int fiyat = _game.GamePrice-(_game.GamePrice * campaign.CampaignDiscount / 100);
                Console.WriteLine(_game.GameName + " Adlı oyunun asıl fiyatı:" + _game.GamePrice);
                Console.WriteLine(_game.GameName + " başarıyla " + _customer.CustomerName + " adlı kişiye " + fiyat + " fiyatıyla satılmıştır.");
            }
            else
            {
                Console.WriteLine("Kullanici dogrulanamadi");
            }
           
        }

       
    }
}
