using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBooking.Shared.Models
{
    public enum Flexibilty
    {
        OneDay,
        TwoDays, 
        ThreeDays
    }

    public enum VehicleSize
    {
        Small,
        Medium,
        Large,
        Van
    }


    public class Booking
    {
        public int ID { get; set; }

        [Required]
        public string? Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public Flexibilty flexibilty { get; set; }
        [Required]
        public VehicleSize VehicleSize { get; set; }
        [Required]
        public string? Phone { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        public bool Approved { get; set; }
    }
}
