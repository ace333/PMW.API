using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Abstraction
{
    public interface IHeartRateRepository : IBaseRepository<IHeartRate>
    {
        double[] GetLastRow();
    }
}
