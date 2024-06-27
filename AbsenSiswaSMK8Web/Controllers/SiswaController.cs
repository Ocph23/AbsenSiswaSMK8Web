using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AbsenSiswaSMK8Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        // GET: api/<SiswaController>
        [HttpGet]
        public IEnumerable<Siswa> Get()
        {

            var datas = new List<Siswa> {
            new Siswa{ Nama="a", NIS=121212, Id=1},
            new Siswa{ Nama="b", NIS=121212, Id=1},
            new Siswa{ Nama="c", NIS=121212, Id=1},
            new Siswa{ Nama="d", NIS=121212, Id=1},
            new Siswa{ Nama="f", NIS=121212, Id=1},
            new Siswa{ Nama="g", NIS=121212, Id=1},
            new Siswa{ Nama="h", NIS=121212, Id=1},
            };
            ///Database
            return datas;
        }

        // GET api/<SiswaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<SiswaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SiswaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SiswaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
