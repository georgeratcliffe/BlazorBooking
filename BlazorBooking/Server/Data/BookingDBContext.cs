using BlazorBooking.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorBooking.Server.Data
{
    public class BookingDBContext : DbContext
    {
        public BookingDBContext(DbContextOptions<BookingDBContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
