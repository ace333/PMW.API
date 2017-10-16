using WebAPI.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Model
{
    public class Accelero : IAccelero
    {
        public int Id { get; set; }

        [Column("x_m_1")]
        public double XAccelero_1 { get; set; }
        [Column("x_m_2")]
        public double XAccelero_2 { get; set; }
        [Column("x_m_3")]
        public double XAccelero_3 { get; set; }
        [Column("x_m_4")]
        public double XAccelero_4 { get; set; }
        [Column("x_m_5")]
        public double XAccelero_5 { get; set; }

        [Column("y_m_1")]
        public double YAccelero_1 { get; set; }
        [Column("y_m_2")]
        public double YAccelero_2 { get; set; }
        [Column("y_m_3")]
        public double YAccelero_3 { get; set; }
        [Column("y_m_4")]
        public double YAccelero_4 { get; set; }
        [Column("y_m_5")]
        public double YAccelero_5 { get; set; }

        [Column("z_m_1")]
        public double ZAccelero_1 { get; set; }
        [Column("z_m_2")]
        public double ZAccelero_2 { get; set; }
        [Column("z_m_3")]
        public double ZAccelero_3 { get; set; }
        [Column("z_m_4")]
        public double ZAccelero_4 { get; set; }
        [Column("z_m_5")]
        public double ZAccelero_5 { get; set; }
    }
}
