using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Abstraction
{
    public interface IHeartRate
    {
        int Id { get; set; }
        double HeartMeasure_1 { get; set; }
        double HeartMeasure_2 { get; set; }
        double HeartMeasure_3 { get; set; }        
        double HeartMeasure_4 { get; set; }
        double HeartMeasure_5 { get; set; }
    }
}
