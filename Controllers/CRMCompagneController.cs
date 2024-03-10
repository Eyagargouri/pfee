using CRM.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM.Controllers
{
    [Route("api/[controller]")]
    [ApiController,Authorize]


    public class CRMCompagneController : Controller
    {
        private readonly EdidynamiqueHbcContext _CRMContext;
       
        public CRMCompagneController(EdidynamiqueHbcContext crmcontext)

        {
            _CRMContext = crmcontext;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crmcampagne>>> Getcrm()
        {
            if (_CRMContext.Crmcampagnes == null)
            {
                return NotFound();
            }
            return await _CRMContext.Crmcampagnes.ToListAsync();
        }

        [HttpGet("{Uniqueid}")]
        public async Task<ActionResult<Crmcampagne>> Getcrmc(int Uniqueid)
        {
            if (_CRMContext.Crmcampagnes == null)
            {
                return NotFound();
            }
            var Crmcampagne = await _CRMContext.Crmcampagnes.FindAsync(Uniqueid);

            if (Crmcampagne == null)
            {
                return NotFound();
            }

            return Crmcampagne;
        }
        [HttpPost]
        public async Task<ActionResult<Crmaction>> Postcrma(Crmcampagne crmcampagne)
        {
            _CRMContext.Crmcampagnes.Add(crmcampagne);
            await _CRMContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Getcrmc), new { uniqueid = crmcampagne.UniqueId }, crmcampagne);


        }
        [HttpPut]
        public async Task<ActionResult> Putcrmc(int uniqueid, Crmcampagne crmcampagne)
        {
            if (uniqueid != crmcampagne.UniqueId)
            {
                return BadRequest();
            }
            _CRMContext.Entry(crmcampagne).State = EntityState.Modified;
            try
            {
                await _CRMContext.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return Ok();
        }
        [HttpDelete("{uniqueid}")]
        public async Task<ActionResult> Deletecrmc(int uniqueid)
        {
            if (_CRMContext.Crmcampagnes == null)
            {
                return NotFound();

            }
            var crmcompagne = await _CRMContext.Crmcampagnes.FindAsync(uniqueid);
            if (crmcompagne == null)
            {
                return NotFound();
            }

            _CRMContext.Crmcampagnes.Remove(crmcompagne);
            await _CRMContext.SaveChangesAsync();
            return Ok();

        }








    }
}
