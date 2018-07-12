using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERMPower.BusinessLogic.Interfaces;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.BusinessLogic
{
    public class MedianService : IMedianService
    {
        private readonly IRepository _repository;

        public MedianService(IRepository repository)
        {
            _repository = repository;
        }

        public void PrintRecordsHavingVariance()
        {
            var lpRecords = _repository.GetLPRecords().ToList();

            // group all LP records by Filename
            var lpRecsGroupedByFilename = lpRecords
                .GroupBy(u => u.Filename)
                .Select(grp => new { Filename = grp.Key, Records = grp.ToList() })
                .ToList();

            foreach (var group in lpRecsGroupedByFilename)
            {
                var median = group.Records.Select(a => a.DataValue).Average();
                if (median != 0)
                {
                    foreach (var record in group.Records)
                    {
                        var variance = record.DataValue - median;
                        var absoluteVariance = Math.Abs(variance);

                        var percentage = absoluteVariance / median * 100;
                        if (percentage > 20)
                        Console.WriteLine($"{group.Filename} {record.Timestamp} {record.DataValue} {median}");
                    }
                }
            }
        }
    }
}
