using CRM.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace CRM.Controllers
{

    [Route("api/[controller]")]
    [ApiController,Authorize]

    public class GRHController : Controller
    {
        private readonly EdidynamiqueHbcContext _grhContext;
       
        public GRHController(EdidynamiqueHbcContext grhcontext)

        {
            _grhContext = grhcontext;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grh>>> GetGrh()
        {
            if (_grhContext.Grhs == null)
            {
                return NotFound();
            }
            return await _grhContext.Grhs.ToListAsync();
        }
        [HttpGet("{Uniqueid}")]
        public async Task<ActionResult<Grh>> GetGrhh(int Uniqueid)
        {
            if (_grhContext.Grhs == null)
            {
                return NotFound();
            }
            var Grh = await _grhContext.Grhs.FindAsync(Uniqueid);

            if (Grh == null)
            {
                return NotFound();
            }

            return Grh;
        }
        [HttpGet("ByType/{typeGrh}")]
        public async Task<ActionResult<IEnumerable<Grh>>> GetGrhByType(string typeGrh)
        {
            if (_grhContext.Grhs == null)
            {
                return NotFound();
            }

            var grhs = await _grhContext.Grhs.Where(grh => grh.TypeGrh == typeGrh).ToListAsync();

            if (grhs == null || grhs.Count == 0)
            {
                return NotFound();
            }

            return Ok(grhs);
        }

        [HttpPost]
        public async Task<ActionResult<Grh>> PostGrh(Grh grh)
        {
            _grhContext.Grhs.Add(grh);
            await _grhContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGrhh), new { uniqueid = grh.Uniqueid }, grh);


        }

        [HttpPut]
        public async Task<ActionResult> PutGrh(int uniqueid, Grh grh)
        {
            if (uniqueid != grh.Uniqueid)
            {
                return BadRequest();
            }
            _grhContext.Entry(grh).State = EntityState.Modified;
            try
            {
                await _grhContext.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok();
        }
        [HttpDelete("{uniqueid}")]
        public async Task<ActionResult> DeleteGrh(int uniqueid)
        {
            if (_grhContext.Grhs == null)
            {
                return NotFound();

            }
            var grh = await _grhContext.Grhs.FindAsync(uniqueid);
            if (grh == null)
            {
                return NotFound();
            }

            _grhContext.Grhs.Remove(grh);
            await _grhContext.SaveChangesAsync();
            return Ok();

        }












    }

}
