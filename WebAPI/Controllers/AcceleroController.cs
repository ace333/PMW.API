using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers
{
    [Route("acc")]
    public class AcceleroController : Controller
    {
        private readonly IAcceleroRepository _acceleroRepository;

        public AcceleroController(IAcceleroRepository acceleroRepository)
        {
            _acceleroRepository = acceleroRepository;
        }

        [HttpGet("id")]
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
        public void Post([FromBody]IList<double[]> values)
        {
            var acc = _acceleroRepository.CreateNewItem();

            if(values[0].Length == 5)
            {
                acc.XAccelero_1 = values[0][0];
                acc.XAccelero_2 = values[0][1];
                acc.XAccelero_3 = values[0][2];
                acc.XAccelero_4 = values[0][3];
                acc.XAccelero_5 = values[0][4];
            }
            
            if(values[1].Length == 5)
            {
                acc.YAccelero_1 = values[1][0];
                acc.YAccelero_2 = values[1][1];
                acc.YAccelero_3 = values[1][2];
                acc.YAccelero_4 = values[1][3];
                acc.YAccelero_5 = values[1][4];
            }
            
            if(values[2].Length == 5)
            {
                acc.ZAccelero_1 = values[2][0];
                acc.ZAccelero_2 = values[2][1];
                acc.ZAccelero_3 = values[2][2];
                acc.ZAccelero_4 = values[2][3];
                acc.ZAccelero_5 = values[2][4];
            }

            _acceleroRepository.Insert(acc);
        }
    }
}