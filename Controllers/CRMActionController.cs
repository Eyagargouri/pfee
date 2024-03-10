using CRM.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CRMActionController : Controller
    {
        private readonly EdidynamiqueHbcContext _CRMContext;
       
        public CRMActionController(EdidynamiqueHbcContext crmcontext)

        {
            _CRMContext = crmcontext;


        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Crmaction>>> Getcrm()
        {
            if (_CRMContext.Crmactions == null)
            {
                return NotFound();
            }
            return await _CRMContext.Crmactions.ToListAsync();
        }

        [HttpGet("{Uniqueid}")]
        public async Task<ActionResult<Crmaction>> Getcrma(int Uniqueid)
        {
            if (_CRMContext.Crmactions == null)
            {
                return NotFound();
            }
            var Crmaction = await _CRMContext.Crmactions.FindAsync(Uniqueid);

            if (Crmaction == null)
            {
                return NotFound();
            }

            return Crmaction;
        }
        [HttpPost]
        public async Task<ActionResult<Crmaction>> Postcrma(Crmaction crmaction)
        {
            _CRMContext.Crmactions.Add(crmaction);
            await _CRMContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Getcrma), new { uniqueid = crmaction.UniqueId }, crmaction);


        }
        [HttpPut]
        public async Task<ActionResult> Putcrma(int uniqueid, Crmaction crmaction)
        {
            if (uniqueid != crmaction.UniqueId)
            {
                return BadRequest();
            }
            _CRMContext.Entry(crmaction).State = EntityState.Modified;
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
        public async Task<ActionResult> Deletecrma(int uniqueid)
        {
            if (_CRMContext.Crmactions == null)
            {
                return NotFound();

            }
            var crmaction = await _CRMContext.Crmactions.FindAsync(uniqueid);
            if (crmaction == null)
            {
                return NotFound();
            }

            _CRMContext.Crmactions.Remove(crmaction);
            await _CRMContext.SaveChangesAsync();
            return Ok();

        }













    }
}
