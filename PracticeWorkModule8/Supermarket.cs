using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule8
{
    public class Supermarket
    {
        public double CalculateTotal(List<double> prices, TimeSpan purchaseTime)
        {
            double total = prices.Sum();
            if (purchaseTime >= TimeSpan.FromHours(8) && purchaseTime <= TimeSpan.FromHours(12))
                total *= 0.95; // 5% скидка

            return total;
        }
    }
}
