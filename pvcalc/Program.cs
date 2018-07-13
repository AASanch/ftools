using formulas;
using System;

namespace pvcalc
{
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
                    Console.WriteLine("***** Present Value Calculator *****");

                    Console.Write("Future Value:  ");
                    var val = double.Parse(Console.ReadLine());
                    Console.Write("Rate (%):  ");
                    var rate = double.Parse(Console.ReadLine()) / 100;
                    Console.Write("Period:  ");
                    var period = int.Parse(Console.ReadLine());

                    var presentVal = Calc.PresentValue(val, rate, period);
                    Console.WriteLine($"Present Value: {(presentVal).ToString("N")}");
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
