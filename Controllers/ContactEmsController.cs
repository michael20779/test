using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using corewebapioracle.Data;
using Microsoft.AspNet.OData;


namespace corewebapioracle.Controllers
{
    
    [ApiController]
    public class ContactEmsController : ControllerBase
    {
        private readonly DataContext _context;

        public ContactEmsController(DataContext context)
        {
            _context = context;
        }
        


        // GET: api/ContactEms
        [HttpGet("GetContact")]
        
        public async Task<ActionResult<IEnumerable<ContactEm>>> GetContactEms()
        {
            return await _context.ContactEms.ToListAsync();
        }

        // GET: api/ContactEms/5
        [HttpGet("ContactEms({id})")]
        [EnableQuery(AllowedQueryOptions = Microsoft.AspNet.OData.Query.AllowedQueryOptions.All)]
        public async Task<ActionResult<ContactEm>> GetContactEm(string id)
        {
            var contactEm = await _context.ContactEms.FindAsync(id);

            if (contactEm == null)
            {
                return NotFound();
            }

            return contactEm;
        }

        // PUT: api/ContactEms/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("({id})")]
        public async Task<IActionResult> PutContactEm(string id, ContactEm contactEm)
        {
            if (id != contactEm.ContactId)
            {
                return BadRequest();
            }

            _context.Entry(contactEm).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactEmExists(id))
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

        // POST: api/ContactEms
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("PostContact")]
        public async Task<ActionResult<ContactEm>> PostContactEm(ContactEm contactEm)
        {
            _context.ContactEms.Add(contactEm);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactEm", new { id = contactEm.ContactId }, contactEm);
        }

        // DELETE: api/ContactEms/5
        [HttpDelete("({id})")]
        public async Task<IActionResult> DeleteContactEm(string id)
        {
            var contactEm = await _context.ContactEms.FindAsync(id);
            if (contactEm == null)
            {
                return NotFound();
            }

            _context.ContactEms.Remove(contactEm);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactEmExists(string id)
        {
            return _context.ContactEms.Any(e => e.ContactId == id);
        }
    }
}
