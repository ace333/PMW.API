using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Model;

namespace WebAPI.Abstraction
{
    public interface IEFDbContext
    {
        DbSet<HeartRate> HeartRate { get; set; }
        DbSet<Accelero> Accelero { get; set; }

        void SaveDbChanges();
    }
}
