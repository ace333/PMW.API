using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers
{
    [Route("Accelero")]
    public class AcceleroController : Controller
    {
        private readonly IAcceleroRepository _acceleroRepository;

        public AcceleroController(IAcceleroRepository acceleroRepository)
        {
            _acceleroRepository = acceleroRepository;
        }

        [HttpGet("Id")]
        public int GetAcceleroLastId()
        {
            return _acceleroRepository.GetLastId();
        }

        [HttpGet]
        public IList<double[]> GetLastRow()
        {
            return _acceleroRepository.GetLastRow();
        }

        [HttpPost]
        public void Post([FromBody]double[] values)
        {
            var acc = _acceleroRepository.CreateNewItem();

            if(values.Length == 15)
            {
                acc.XAccelero_1 = values[0];
                acc.XAccelero_2 = values[1];
                acc.XAccelero_3 = values[2];
                acc.XAccelero_4 = values[3];
                acc.XAccelero_5 = values[4];
                acc.YAccelero_1 = values[5];
                acc.YAccelero_2 = values[6];
                acc.YAccelero_3 = values[7];
                acc.YAccelero_4 = values[8];
                acc.YAccelero_5 = values[9];
                acc.ZAccelero_1 = values[10];
                acc.ZAccelero_2 = values[11];
                acc.ZAccelero_3 = values[12];
                acc.ZAccelero_4 = values[13];
                acc.ZAccelero_5 = values[14];


                _acceleroRepository.Insert(acc);
            }
            
        }
    }
}