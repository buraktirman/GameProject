using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        void Sell(Gamer gamer, Campaign campaign);
    }
}
