using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Sandbox
{
    class PricesBook
    {
        public void AddPrice(float price)
        {
            prices.Add(price);
        }

        List<float> prices = new List<float>();

        public PriceStatistics ComputeStatistics()
        {
            PriceStatistics stats = new PriceStatistics();
            float sum = 0;

            foreach(float price in prices)
            {
                sum += price;
                stats.LowestPrice = Math.Min(stats.LowestPrice, price);
                stats.HighestPrice = Math.Max(stats.HighestPrice, price);
            }

            stats.AveragePrice = sum / prices.Count;
            
            return stats;
        }
    }
}
