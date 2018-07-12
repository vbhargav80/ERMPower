using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERMPower.Data;

namespace ERMPower.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new FileRepository();
            var rec = repo.GetLPRecords();
            var rec2 = repo.GetTOURecords();
        }
    }
}
