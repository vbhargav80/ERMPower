using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERMPower.BusinessLogic.Models
{
    public class MedianVariance
    {
        public string Filename { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Value { get; set; }
        public decimal MedianValue { get; set; }
        public decimal VariancePercentage { get; set; }
    }
}
