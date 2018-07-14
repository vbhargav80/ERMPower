using System.Collections.Generic;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.BusinessLogic.Interfaces
{
    public interface IMedianVariationService
    {
        List<MedianVariance> GetMedianVariances();
    }
}