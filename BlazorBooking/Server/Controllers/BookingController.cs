using BlazorBooking.Server.Data;
using BlazorBooking.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorBooking.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")] 
    public class BookingController : ControllerBase
    {
        private readonly BookingDBContext _context;
        public BookingController(BookingDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var bookings = await _context.Bookings.OrderBy(b => b.Date).ToListAsync();
            return Ok(bookings);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var booking = await _context.Bookings.FirstOrDefaultAsync(a => a.ID == id);
            return Ok(booking);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Post(Booking booking)
        {
            _context.Add(booking);
            await _context.SaveChangesAsync();
            return Ok(booking.ID);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Booking booking)
        {
            _context.Entry(booking).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var booking = new Booking { ID = id };
            _context.Remove(booking);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
