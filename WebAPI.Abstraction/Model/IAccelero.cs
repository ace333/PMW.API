using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Abstraction
{
    public interface IAccelero : XAccelero, YAccelero, ZAccelero
    {
        int Id { get; set; }             
    }

    public interface XAccelero
    {
        double XAccelero_1 { get; set; }
        double XAccelero_2 { get; set; }
        double XAccelero_3 { get; set; }
        double XAccelero_4 { get; set; }
        double XAccelero_5 { get; set; }
    }

    public interface YAccelero
    {
        double YAccelero_1 { get; set; }
        double YAccelero_2 { get; set; }
        double YAccelero_3 { get; set; }
        double YAccelero_4 { get; set; }
        double YAccelero_5 { get; set; }
    }

    public interface ZAccelero
    {
        double ZAccelero_1 { get; set; }
        double ZAccelero_2 { get; set; }
        double ZAccelero_3 { get; set; }
        double ZAccelero_4 { get; set; }
        double ZAccelero_5 { get; set; }
    }
}
