using WebAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class HeartRate : IHeartRate
    {
        public int Id { get; set; }
        [Column("heart_m_1")]
        public double HeartMeasure_1 { get; set; }
        [Column("heart_m_2")]
        public double HeartMeasure_2 { get; set; }
        [Column("heart_m_3")]
        public double HeartMeasure_3 { get; set; }
        [Column("heart_m_4")]
        public double HeartMeasure_4 { get; set; }
        [Column("heart_m_5")]
        public double HeartMeasure_5 { get; set; }
  
    }
}
