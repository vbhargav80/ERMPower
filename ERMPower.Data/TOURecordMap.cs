using CsvHelper.Configuration;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.Data
{
    public class TOURecordMap : CsvClassMap<TOURecord>
    {
        public TOURecordMap()
        {
            Map(m => m.BillingResetCount).Name("Billing Reset Count");
            Map(m => m.BillingResetTimestamp).Name("Billing Reset Date/Time");
            Map(m => m.DataType).Name("Data Type");
            Map(m => m.DLSActive).Name("DLS Active");
            Map(m => m.Energy).Name("Energy");
            Map(m => m.MaximumDemand).Name("Maximum Demand");
            Map(m => m.MeterPointCode).Name("MeterPoint Code");
            Map(m => m.PlantCode).Name("Plant Code");
            Map(m => m.Rate).Name("Rate");
            Map(m => m.SerialNumber).Name("Serial Number");
            Map(m => m.Status).Name("Status");
            Map(m => m.Timestamp).Name("Date/Time");
            Map(m => m.TimeOfMaxDemand).Name("Time of Max Demand");
            Map(m => m.Units).Name("Units");
        }
    }
}