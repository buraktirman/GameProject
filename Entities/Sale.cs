using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    class Sale : IEntity
    {
        public int Id { get; set; }
        public double TotalPrice { get; set; }
    }
}
