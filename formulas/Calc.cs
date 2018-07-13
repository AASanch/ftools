using System;

namespace formulas
{
    public static class Calc
    {
        public static double GrowthRate(double beginVal, double endVal, double period)
            => Math.Pow((endVal / beginVal), (1 / period)) - 1;

        public static double FutureValue(double value, double rate, double period)
            => value * Math.Pow(1 + rate, period);

        public static double PresentValue(double futureValue, double rate, double period)
            => futureValue * (Math.Pow((1 + rate), -period));
    }
}
