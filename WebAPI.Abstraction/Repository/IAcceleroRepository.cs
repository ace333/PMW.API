using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Abstraction
{
    public interface IAcceleroRepository : IBaseRepository<IAccelero>
    {
        IList<double[]> GetLastRow();
    }
}
