using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAppPratice.Models;

namespace WebAppPratice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        static List<Movie> list = new List<Movie>()
        {
            new Movie{ Id=1,MName="Salaar",StatCast="Prabhas",Director="Prashanth",Producer="neel",ReleaseDate=new DateTime(day:12,month:1,year:2023)},
            new Movie{ Id=2,MName="leo",StatCast="Vijay",Director="Lokesh",Producer="Kangaraj",ReleaseDate=new DateTime(day:11,month:2,year:2023)},
            new Movie{ Id=3,MName="RRR",StatCast="RamCharan",Director="RajaMouli",Producer="RajaMouli",ReleaseDate=new DateTime(day:10,month:3,year:2022)},

        };
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return list;
        }
        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            Movie mv = list.SingleOrDefault(x => x.Id == id);
            if (mv == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(mv);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult<Movie> Delete(int id)
        {
            Movie emp = list.SingleOrDefault(x => x.Id == id);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(emp);
            }
        }
        [HttpPost]
        public ActionResult<Movie> Post(Movie newMv)
        {
            list.Add(newMv);
            return CreatedAtAction(nameof(Get), newMv);
        }
        [HttpPut("{id}")]
        public ActionResult<Movie> Put(int id, Movie upMv)
        {
            Movie extMv = list.SingleOrDefault(x => x.Id == id);
            if (extMv == null)
            {
                return NotFound();
            }
            else
            {

                return NoContent();
            }
        }
    }
}
