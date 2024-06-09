using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]
    public class OrganigrammeController : ControllerBase
    {
        private readonly EdidynamiqueHbcContext _organigrammeContext;

        public OrganigrammeController(EdidynamiqueHbcContext organigrammeContext)

        {
            _organigrammeContext = organigrammeContext;

         }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organigramme>>> GetOrganigramme()
        {
            if (_organigrammeContext.Organigrammes == null)
            {
                return NotFound();
            }
            return await _organigrammeContext.Organigrammes.ToListAsync();
        }
        [HttpPost]
        public async Task<ActionResult<Organigramme>> PostOrganigramme(Organigramme organigramme)
        {
            _organigrammeContext.Organigrammes.Add(organigramme);
            await _organigrammeContext.SaveChangesAsync();
            return CreatedAtAction(nameof(GetOrganigramme), new { id = organigramme.Id }, organigramme);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(string id)
        {
            if (_organigrammeContext.Organigrammes == null)
            {
                return NotFound();

            }
            var organigramme= await _organigrammeContext.Organigrammes.FindAsync(id);
            if ( organigramme == null)
            {
                return NotFound();
            }

            _organigrammeContext.Organigrammes.Remove(organigramme);
            await _organigrammeContext.SaveChangesAsync();
            return Ok();

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Organigramme>> GetOrganigrammeById(string id)
        {
            var organigramme = await _organigrammeContext.Organigrammes.FindAsync(id);

            if (organigramme == null)
            {
                return NotFound();
            }

            return organigramme;
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganigramme(string id, Organigramme organigramme)
        {
            if (id != organigramme.Id)
            {
                return BadRequest();
            }

            _organigrammeContext.Entry(organigramme).State = EntityState.Modified;

            try
            {
                await _organigrammeContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganigrammeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();

        }
        private bool OrganigrammeExists(string id)
        {
            return _organigrammeContext.Organigrammes.Any(e => e.Id == id);
        }




    }
}
