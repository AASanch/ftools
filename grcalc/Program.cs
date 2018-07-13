using formulas;
using System;

namespace grcalc
{
    /// <summary>
    /// Growth rate calculator.
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
                    Console.WriteLine("***** Growth Rate Calculator *****");
                    Console.Write("Beginning Val:  ");
                    var beginVal = double.Parse(Console.ReadLine());
                    Console.Write("EndingVal Val:  ");
                    var endVal = double.Parse(Console.ReadLine());
                    Console.Write("Period:  ");
                    var period = int.Parse(Console.ReadLine());

                    var growthRate = Calc.GrowthRate(beginVal, endVal, period);
                    Console.WriteLine($"Growth Rate: {(growthRate * 100).ToString("N")}%");
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
