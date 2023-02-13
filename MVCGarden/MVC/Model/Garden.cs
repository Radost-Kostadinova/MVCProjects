using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Model
{
    public class Garden
    {
        public Garden(decimal priceVegitables, decimal priceFruits, int kgVegitables, int kgFruits)
        {
            PriceVegitables = priceVegitables;
            PriceFruits = priceFruits;
            KgVegitables = kgVegitables;
            KgFruits = kgFruits;
        }

        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitables { get; set; }
        public int KgFruits { get; set; }

        public decimal CalculateSum()
        {
            return 1.94m * (this.KgFruits * this.PriceFruits + this.KgVegitables * PriceVegitables)/1.94m;

        }


    }
}
