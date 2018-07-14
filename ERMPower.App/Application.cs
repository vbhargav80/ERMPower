using System;
using ERMPower.BusinessLogic.Interfaces;

namespace ERMPower.App
{
    public class Application : IApplication
    {
        private readonly IMedianVariationService _medianVariationService;
        public Application(IMedianVariationService medianVariationService)
        {
            _medianVariationService = medianVariationService;
        }

        public void Run()
        {
            var medianVarianceRecords = _medianVariationService.GetMedianVariances();
            foreach (var varianceRecord in medianVarianceRecords)
            {
                if (varianceRecord.VariancePercentage > 20)
                {
                    Console.WriteLine($"{varianceRecord.Filename} {varianceRecord.Timestamp} {varianceRecord.Value} {varianceRecord.MedianValue}");
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    public interface IApplication
    {
        void Run();
    }
}
