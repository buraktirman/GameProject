using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Campaign added.");
        }

        public void Delete()
        {
            Console.WriteLine("Campaign deleted.");
        }

        public void Update()
        {
            Console.WriteLine("Campaign updated.");
        }
    }
}
