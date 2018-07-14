using System.Collections.Generic;
using ERMPower.BusinessLogic.Interfaces;

namespace ERMPower.BusinessLogic
{
    /// <summary>
    /// Calculates the mathematical median of a list of values
    /// </summary>
    public class MedianCalculator : IMedianCalculator
    {
        public decimal CalculateMedian(List<decimal> input)
        {
            if (input == null || input.Count == 0) return 0;

            input.Sort();
            var size = input.Count;
            var mid = size / 2;

            // for 
            var median = size % 2 != 0 
                ? input[mid] 
                : (input[mid] + input[mid - 1]) / 2;
            return median;
        }
    }
}
