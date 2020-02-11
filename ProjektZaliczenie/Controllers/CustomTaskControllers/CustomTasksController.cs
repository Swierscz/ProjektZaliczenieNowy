using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjektZaliczenie.Controllers.CustomTaskControllers.InputValidators;
using ProjektZaliczenie.Database;
using ProjektZaliczenie.Models;

namespace ProjektZaliczenie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomTasksController : ControllerBase
    {
        private readonly CustomTaskContext _context;

        public CustomTasksController(CustomTaskContext context)
        {
            _context = context;
        }

        // GET: api/CustomTasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomTask>>> GetTasks()
        {
            return Ok("Parabambam");
            var x = await _context.Tasks.ToListAsync();
            return Ok(x);
        }

        // GET: api/CustomTasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomTask>> GetCustomTask(int id)
        {
            var customTask = await _context.Tasks.FindAsync(id);

            if (customTask == null)
            {
                return NotFound();
            }

            return customTask;
        }

        // PUT: api/CustomTasks/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomTask(int id, CustomTask customTask)
        {
            if (id != customTask.Id)
            {
                return BadRequest();
            }

            _context.Entry(customTask).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomTaskExists(id))
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

        // POST: api/CustomTasks
        [HttpPost]
        public async Task<ActionResult<CustomTask>> PostCustomTask(CustomTask customTask)
        {

            TaskValidationMessage validationMessage = ValidatorProvider.GetValidationMessageIfInvalidInputProvided(customTask);

            if (validationMessage != null)
            {
                return StatusCode(422, validationMessage.Message);
            }

            _context.Tasks.Add(customTask);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomTask", new { id = customTask.Id }, customTask);
        }

        // DELETE: api/CustomTasks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomTask>> DeleteCustomTask(int id)
        {
            var customTask = await _context.Tasks.FindAsync(id);
            if (customTask == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(customTask);
            await _context.SaveChangesAsync();

            return customTask;
        }

        private bool CustomTaskExists(int id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
    }
}
