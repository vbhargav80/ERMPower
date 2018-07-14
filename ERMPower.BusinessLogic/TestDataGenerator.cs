using System;
using System.Collections.Generic;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.BusinessLogic
{
    public class TestDataGenerator
    {
        private const string LPFile1 = "LPFile1.csv";
        private const string TOUFile1 = "TOUFile1.csv";

        public static List<LPRecord> GenerateLPRecords()
        {
            var testRecords = new List<LPRecord>
            {
                new LPRecord()
                {
                    DataValue = 20,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 25,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 15,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 18,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 12,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 27,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new LPRecord()
                {
                    DataValue = 24,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                }
            };

            return testRecords;
        }

        public static List<TOURecord> GenerateTOURecords()
        {
            var testRecords = new List<TOURecord>
            {
                new TOURecord()
                {
                    Energy = 5.7m,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 8.2m,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 15.03m,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 6,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 12.26m,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 21,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                },
                new TOURecord()
                {
                    Energy = 15.4m,
                    Filename = LPFile1,
                    Timestamp = DateTime.Today.AddDays(-7),
                }
            };

            return testRecords;
        }
    }
}
