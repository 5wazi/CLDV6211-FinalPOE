using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace EventEase.Models
{
    public class BookingViewModel
    {
        public List<Booking>? Bookings { get; set; }
        [DataType(DataType.DateTime)]
        public SelectList? Dates { get; set; }
        public DateTime BookingDates { get; set; }
        public string? searchString { get; set; }

        
        public List<SelectListItem> EventTypes { get; set; }
        public int? SelectedEventTypeId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
