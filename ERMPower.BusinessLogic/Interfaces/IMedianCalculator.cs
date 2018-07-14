using System.Collections.Generic;

namespace ERMPower.BusinessLogic.Interfaces
{
    public interface IMedianCalculator
    {
        decimal CalculateMedian(List<decimal> input);
    }
}