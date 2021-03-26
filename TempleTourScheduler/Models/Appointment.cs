using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourScheduler.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public int AppointmentId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        [Range(1,50, ErrorMessage = "Maximum capcity is 50")]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string DayOfWeek { get; set; }

        [Required]
        public string TimeSlot { get; set; }

#nullable enable
        public string? Contact { get; set; }

        public int? TimeId { get; set; }
#nullable disable
    }
}
