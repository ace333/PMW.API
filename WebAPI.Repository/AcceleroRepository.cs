using WebAPI.Abstraction;
using WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class AcceleroRepository : IAcceleroRepository
    {
        public IEFDbContext _context;
        public DbSet<Accelero> _accelero;

        public AcceleroRepository(IEFDbContext context)
        {
            _context = context;
            _accelero = context.Accelero;
        }

        public IAccelero CreateNewItem()
        {
            return new Accelero();
        }

        public int GetLastId()
        {
            return _accelero.Last().Id;
        }

        public IList<double[]> GetLastRow()
        {
            var acc = _accelero.Last();

            return new List<double[]>()
            {
                new double[] { acc.XAccelero_1, acc.XAccelero_2, acc.XAccelero_3, acc.XAccelero_4, acc.XAccelero_5 },
                new double[] { acc.YAccelero_1, acc.YAccelero_2, acc.YAccelero_3, acc.YAccelero_4, acc.YAccelero_5 },
                new double[] { acc.ZAccelero_1, acc.ZAccelero_2, acc.ZAccelero_3, acc.ZAccelero_4, acc.ZAccelero_5 },
            };
        }

        public void Insert(IAccelero item)
        {
            _accelero.Add(item as Accelero);
            _context.SaveDbChanges();
        }
    }
}
