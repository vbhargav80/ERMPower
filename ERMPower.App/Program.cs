using ERMPower.BusinessLogic;
using ERMPower.Data;

namespace ERMPower.App
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repo = new FileRepository();
            var medianService = new MedianService(repo);

            medianService.PrintRecordsHavingVariance();
        }
    }
}