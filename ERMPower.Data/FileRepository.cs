using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using CsvHelper;
using ERMPower.BusinessLogic.Interfaces;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.Data
{
    public class FileRepository : IRepository
    {
        private readonly string _sourceDirectory;

        public FileRepository()
        {
            _sourceDirectory = ConfigurationManager.AppSettings["SourceDirectory"];
        }

        public List<LPRecord> GetLPRecords()
        {
            var lpRecords = new List<LPRecord>();

            foreach (string file in Directory.EnumerateFiles(_sourceDirectory, "LP_*.csv", SearchOption.AllDirectories))
            {
                using (TextReader reader = File.OpenText(file))
                {
                    var csv = new CsvReader(reader);
                    csv.Configuration.RegisterClassMap<LPRecordMap>();

                    var parsedRecords = csv.GetRecords<LPRecord>().ToList();
                    parsedRecords.ForEach(a => a.Filename = Path.GetFileName(file));
                    
                    lpRecords.AddRange(parsedRecords);
                }
            }

            return lpRecords;
        }

        public List<TOURecord> GetTOURecords()
        {
            var touRecords = new List<TOURecord>();

            foreach (string file in Directory.EnumerateFiles(_sourceDirectory, "TOU_*.csv", SearchOption.AllDirectories))
            {
                using (TextReader reader = File.OpenText(file))
                {
                    var csv = new CsvReader(reader);
                    csv.Configuration.RegisterClassMap<TOURecordMap>();

                    var parsedRecords = csv.GetRecords<TOURecord>().ToList();
                    parsedRecords.ForEach(a => a.Filename = Path.GetFileName(file));

                    touRecords.AddRange(parsedRecords);
                }
            }

            return touRecords;
        }
    }
}
