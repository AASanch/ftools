using formulas;
using System;

namespace fvcalc
{
    /// <summary>
    /// Future Value calculator.
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
                    Console.WriteLine("***** Future Value Calculator *****");

                    Console.Write("Value:  ");
                    var val = double.Parse(Console.ReadLine());
                    Console.Write("Rate (%):  ");
                    var rate = double.Parse(Console.ReadLine()) / 100;
                    Console.Write("Period:  ");
                    var period = int.Parse(Console.ReadLine());

                    var futureVal = Calc.FutureValue(val, rate, period);
                    Console.WriteLine($"Future Value: {(futureVal).ToString("N")}");
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
