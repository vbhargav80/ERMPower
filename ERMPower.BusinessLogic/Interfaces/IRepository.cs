using System.Collections.Generic;
using ERMPower.BusinessLogic.Models;

namespace ERMPower.BusinessLogic.Interfaces
{
    public interface IRepository
    {
        List<LPRecord> GetLPRecords();
        List<TOURecord> GetTOURecords();
    }
}