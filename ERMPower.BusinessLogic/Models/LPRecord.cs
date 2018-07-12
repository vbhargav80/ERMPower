using System;

namespace ERMPower.BusinessLogic.Models
{
    /// <summary>
    /// Represents a record from a LP file
    /// </summary>
    public class LPRecord
    {
        public string Filename { get; set; }
        public string MeterPointCode { get; set; }
        public string SerialNumber { get; set; }
        public string PlantCode { get; set; }
        public DateTime Timestamp { get; set; }
        public string DataType { get; set; }
        public decimal DataValue { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }
    }
}
