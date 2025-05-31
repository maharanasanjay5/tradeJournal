using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TradeJournalAPI.Models;

namespace TradeJournalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        private readonly TradeJournalDbContext _context;

        public TradesController(TradeJournalDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostTrade([FromBody] TradeJournal trade)
        {
            try
            {
                _context.TradeJournals.Add(trade);
                await _context.SaveChangesAsync();

                return Ok(new { success = true, message = "Trade saved successfully" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { success = false, message = ex.Message });
            }
        }
    }
}