using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWorkModule8
{
    public class SalesForecast
    {
        public double[] PredictNextThreeMonths(double[] pastSales)
        {
            int n = pastSales.Length;
            double sumX = 0, sumY = 0, sumXx = 0, sumXy = 0;
            for (int i = 0; i < n; i++)
            {
                sumX += i;
                sumY += pastSales[i];
                sumXx += i * i;
                sumXy += i * pastSales[i];
            }

            double slope = (n * sumXy - sumX * sumY) / (n * sumXx - sumX * sumX);
            double intercept = (sumY - slope * sumX) / n;

            return new double[]
            {
            intercept + slope * n,
            intercept + slope * (n + 1),
            intercept + slope * (n + 2)
            };
        }
    }

}
