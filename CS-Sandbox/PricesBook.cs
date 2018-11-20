using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Sandbox
{
    class PricesBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        List<float> grades = new List<float>();

        public PriceStatistics ComputeStatistics()
        {
            PriceStatistics stats = new PriceStatistics();
            return stats;
        }
    }
}
