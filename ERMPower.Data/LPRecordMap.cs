using CsvHelper.Configuration;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.Data
{
    public sealed class LPRecordMap : CsvClassMap<LPRecord>
    {
        public LPRecordMap()
        {
            Map(m => m.DataType).Name("Data Type");
            Map(m => m.DataValue).Name("Data Value");
            Map(m => m.MeterPointCode).Name("MeterPoint Code");
            Map(m => m.PlantCode).Name("Plant Code");
            Map(m => m.SerialNumber).Name("Serial Number");
            Map(m => m.Status).Name("Status");
            Map(m => m.Timestamp).Name("Date/Time");
            Map(m => m.Units).Name("Units");
        }
    }
}
