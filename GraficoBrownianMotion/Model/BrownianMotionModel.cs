﻿using System;
namespace GraficoBrownianMotion.Model
{
    using System;

    namespace BrownianMotionApp.Model
    {
        public class BrownianMotionModel
        {
            public double[] GenerateBrownianMotion(double initialPrice, double volatility, double meanReturn, int numDays)
            {
                Random rand = new();
                double[] prices = new double[numDays];
                prices[0] = initialPrice;

                for (int i = 1; i < numDays; i++)
                {
                    double u1 = 1.0 - rand.NextDouble();
                    double u2 = 1.0 - rand.NextDouble();
                    double z = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

                    double dailyReturn = meanReturn + volatility * z;

                    prices[i] = prices[i - 1] * Math.Exp(dailyReturn);
                }

                return prices;
            }
        }
    }
}

