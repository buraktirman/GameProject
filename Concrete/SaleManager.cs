using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine("Sale is done to " + gamer.FirstName + " using " + campaign.Title + 
                " with %" + campaign.DiscountRate + " discount rate.");
        }
    }
}
