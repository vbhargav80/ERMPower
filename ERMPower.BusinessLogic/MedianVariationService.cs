using System;
using System.Collections.Generic;
using System.Linq;
using ERMPower.BusinessLogic.Interfaces;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.BusinessLogic
{
    public class MedianVariationService : IMedianVariationService
    {
        private readonly IRepository _repository;
        private readonly IMedianCalculator _medianCalculator;

        public MedianVariationService(IRepository repository, IMedianCalculator medianCalculator)
        {
            _repository = repository;
            _medianCalculator = medianCalculator;
        }

        /// <summary>
        /// Returns records that represent the variance of the data value as a percentage from the median
        /// </summary>
        public List<MedianVariance> GetMedianVariances()
        {
            var varianceRecords = new List<MedianVariance>();
            var lpRecords = _repository.GetLPRecords()?.ToList();
            var touRecords = _repository.GetTOURecords()?.ToList();

            // group all LP records by Filename
            var lpRecsGroupedByFilename = lpRecords
                ?.GroupBy(u => u.Filename)
                .Select(grp => new { Filename = grp.Key, Records = grp.ToList() })
                .ToList();

            // group all TOU records by Filename
            var touRecsGroupedByFilename = touRecords
                ?.GroupBy(u => u.Filename)
                .Select(grp => new { Filename = grp.Key, Records = grp.ToList() })
                .ToList();

            if (lpRecsGroupedByFilename != null)
            {
                foreach (var group in lpRecsGroupedByFilename)
                {
                    var median = _medianCalculator.CalculateMedian(group.Records.Select(a => a.DataValue).ToList());
                    foreach (var record in group.Records)
                    {
                        var medianVariance = CreateMedianVariance(
                            group.Filename,
                            median,
                            record.Timestamp,
                            record.DataValue
                        );

                        varianceRecords.Add(medianVariance);
                    }
                }
            }

            if (touRecsGroupedByFilename != null)
            {
                foreach (var group in touRecsGroupedByFilename)
                {
                    var median = _medianCalculator.CalculateMedian(group.Records.Select(a => a.Energy).ToList());
                    foreach (var record in group.Records)
                    {
                        var medianVariance = CreateMedianVariance(
                            group.Filename,
                            median,
                            record.Timestamp,
                            record.Energy
                        );

                        varianceRecords.Add(medianVariance);
                    }
                }
            }

            return varianceRecords;
        }

        private MedianVariance CreateMedianVariance(
            string filename, 
            decimal median, 
            DateTime timestamp, 
            decimal dataValue
            )
        {
            var medianVariance = new MedianVariance()
            {
                Filename = filename,
                MedianValue = median,
                Timestamp = timestamp,
                Value = dataValue
            };

            if (median == 0)
            {
                medianVariance.VariancePercentage = 0;
            }
            else
            {
                var variance = dataValue - median;
                var absoluteVariance = Math.Abs(variance);
                medianVariance.VariancePercentage = absoluteVariance / median * 100; ;
            }

            return medianVariance;
        }

    }
}
