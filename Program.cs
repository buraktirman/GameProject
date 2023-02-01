using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new MernisServiceAdapter());
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());

            Gamer gamer1 = new Gamer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                BirthDate = new DateTime(1985, 1, 6),
                IdentityNumber = "28861499108",
                Rank = "Silver"
            };

            gamerManager1.Add(gamer1);
            gamerManager2.Add(gamer1);

            Campaign campaign = new Campaign 
            {
                Id = 1,
                Title = "Winter Campaign",
                DiscountRate = 30
            };

            SaleManager saleManager = new SaleManager();
            saleManager.Sell(gamer1, campaign);
        }
    }
}
