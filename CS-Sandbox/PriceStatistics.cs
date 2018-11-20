using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Sandbox
{
    class PriceStatistics
    {
        public PriceStatistics()
        {
            LowestPrice = float.MaxValue;
            HighestPrice = 0;
        }

        public float AveragePrice;
        public float LowestPrice;
        public float HighestPrice;
    }
}
