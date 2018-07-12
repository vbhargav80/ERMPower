using System;

namespace ERMPower.BusinessLogic.Models
{
    /// <summary>
    /// Represents a record from a TOU file
    /// </summary>
    public class TOURecord
    {
        public string Filename { get; set; }
        public string MeterPointCode { get; set; }
        public string SerialNumber { get; set; }
        public string PlantCode { get; set; }
        public DateTime Timestamp { get; set; }
        public string DataType { get; set; }
        public decimal Energy { get; set; }
        public decimal MaximumDemand { get; set; }
        public DateTime TimeOfMaxDemand { get; set; }
        public string Units { get; set; }
        public string Status { get; set; }
        public bool DLSActive { get; set; }
        public int BillingResetCount { get; set; }
        public DateTime BillingResetTimestamp { get; set; }
        public string Rate { get; set; }
    }
}
