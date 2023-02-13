using MVC.Model;
using MVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Controllers
{
     public class GardenController
    {
        private Dispaly display;
        private Garden garden;

        public GardenController()
        {
            display = new Dispaly();
            garden = new Garden(display.PriceVegitables,display.PriceFruits,display.KgVegitables,display.KgFruits);
            display.Total = garden.CalculateSum();
            display.ShowResult();
        }



    }
}
