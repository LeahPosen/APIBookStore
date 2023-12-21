using Microsoft.AspNetCore.Mvc;
using Store.Core.Entities;
using Store.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalerController : ControllerBase
    {
        
        private readonly ISalerSrevice _salerSrevice;
        public SalerController(ISalerSrevice salerSrevice)
        {
            _salerSrevice = salerSrevice;
        }


    
        // GET: api/<SalerController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_salerSrevice.Get());
        }

        // GET api/<SalerController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_salerSrevice.Get(id));
        }

        // POST api/<SalerController>
        [HttpPost]
        public void Post([FromBody] Saler value)
        {
          _salerSrevice.Post(value);   
        }

        // PUT api/<SalerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Saler value)
        {
           _salerSrevice.Put(id, value);
        }

        // DELETE api/<SalerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _salerSrevice.Delete(id);
        }

        [HttpDelete]
        public void DeleteBySalary(int minSalary)
        {
            _salerSrevice.DeleteBySalary(minSalary);
        }
    }
}
