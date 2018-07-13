using formulas;
using System;

namespace stickercalc
{
    /// <summary>
    /// Sticker Price calculator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var shouldContinue = true;
            while (shouldContinue)
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("***** Sticker Price Calculator *****");
                    Console.Write("EPS (TTM):  ");
                    var epsTtm = double.Parse(Console.ReadLine());

                    Console.Write("EPS Growth Rate (%):  ");
                    var epsGR = double.Parse(Console.ReadLine()) / 100;

                    var futureEps = Calc.FutureValue(epsTtm, epsGR, 9);
                    Console.WriteLine($"");
                    Console.WriteLine($"Future EPS (10 yrs) = {futureEps.ToString("N")}");
                    Console.WriteLine($"Default PE Ratio = {(futureEps * 2).ToString("N")}");
                    Console.WriteLine($"");

                    Console.Write("PE Ratio:  ");
                    var peRatio = int.Parse(Console.ReadLine());
                    var futurePrice = futureEps * peRatio;
                    Console.WriteLine($"");
                    Console.WriteLine($"Future Price = {futurePrice.ToString("N")}");
                    Console.WriteLine($"");

                    Console.Write("Acceptable Rate of Return (%):  ");
                    var aror = double.Parse(Console.ReadLine()) / 100;
                    var futureAdjustedPrice = futurePrice * (1 + aror);
                    var presentVal = Calc.PresentValue(futureAdjustedPrice, aror, 9);

                    Console.WriteLine($"");
                    Console.WriteLine($"Sticker Price:  {presentVal.ToString("N")}");
                    Console.WriteLine($"MOS Price (50% off):  {(presentVal / 2).ToString("N")}");
                    Console.WriteLine($"");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
                finally
                {
                    Console.Write("Press Y to try again.  ");
                    var input = Console.ReadKey();
                    shouldContinue = (input.KeyChar == 'y') || (input.KeyChar == 'Y');
                    Console.WriteLine("");
                }
            }
        }
    }
}
