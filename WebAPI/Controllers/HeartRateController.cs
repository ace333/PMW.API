using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Abstraction;

namespace WebAPI.Controllers
{
    [Route("hr")]
    public class HeartRateController : Controller
    {
        private readonly IHeartRateRepository _heartRateRepository;

        public HeartRateController(IHeartRateRepository heartRateRepository)
        {
            _heartRateRepository = heartRateRepository;
        }

        [HttpGet("id")]
        public int GetHeartRateLastId()
        {
            return _heartRateRepository.GetLastId();
        }

        [HttpGet]
        public double[] GetLastRow()
        {
            return _heartRateRepository.GetLastRow();
        }

        [HttpPost]
        public void Post([FromBody]double[] values)
        {
            IHeartRate hr = _heartRateRepository.CreateNewItem();

            if(values.Length == 5)
            {
                hr.HeartMeasure_1 = values[0];
                hr.HeartMeasure_2 = values[1];
                hr.HeartMeasure_3 = values[2];
                hr.HeartMeasure_4 = values[3];
                hr.HeartMeasure_5 = values[4];
            }

            _heartRateRepository.Insert(hr);
        }
    }
}