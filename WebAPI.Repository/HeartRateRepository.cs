using WebAPI.Abstraction;
using WebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Repositories
{
    public class HeartRateRepository : IHeartRateRepository
    {
        public IEFDbContext _context;
        public DbSet<HeartRate> _heartrate;

        public HeartRateRepository(IEFDbContext context)
        {
            _context = context;
            _heartrate = context.HeartRate;
        }

        public IHeartRate CreateNewItem()
        {
            return new HeartRate();
        }

        public int GetLastId()
        {
            return _heartrate.Last().Id;
        }

        public double[] GetLastRow()
        {
            var hr = _heartrate.Last();
            return new double[] { hr.HeartMeasure_1, hr.HeartMeasure_2, hr.HeartMeasure_3, hr.HeartMeasure_4, hr.HeartMeasure_5 };
        }

        public void Insert(IHeartRate item)
        {
            _heartrate.Add(item as HeartRate);
            _context.SaveDbChanges();
        }
    }
}
