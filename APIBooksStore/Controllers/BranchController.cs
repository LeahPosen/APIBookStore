using Microsoft.AspNetCore.Mvc;
using Store.Core.Entities;
using Store.Core.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        

        private readonly IBranchService _branchServise;
        public BranchController(IBranchService branchServise)
        {
            this._branchServise = branchServise;
        }

        // GET: api/<BranchController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_branchServise.Get());
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_branchServise.Get(id));
        }

        // POST api/<BranchController>
        [HttpPost]
        public void Post([FromBody] Branch value)
        {
            _branchServise.Post(value);
        }

        // PUT api/<BranchController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Branch value)
        {
            _branchServise.Put(id, value);
        }

        // DELETE api/<BranchController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _branchServise.Delete(id);
        }

        [HttpPut]
        public void putByCity(string city, int toAdd)
        {
         _branchServise.putByCity(city, toAdd);
        }
    }
}
