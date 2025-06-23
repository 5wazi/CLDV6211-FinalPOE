using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventEase.Models
{
    public class Booking
    {
        [Key] //Primary Key
        public int BookingId { get; set; }
        [ForeignKey("Venue")] //Foreign Key
        public int VenueId { get; set; }
        [ForeignKey("Event")] //Foreign Key
        public int EventId { get; set; }
        public Event? Event { get; set; }
        
        public Venue? Venue { get; set; }
        [DataType(DataType.DateTime)]
        [Display(Name = "Booking Date")]
        public DateTime BookingDate { get; set; }
        
    }
}
