using System;
using System.ComponentModel.DataAnnotations;

namespace TempleTourScheduler.Models
{
    public class TimeBlock
    {
        public TimeBlock()
        {
        }

        [Key]
        public int TimeId { get; set; }

        public string DayOfWeek { get; set; }

        public string HourBlock { get; set; }

        public bool IsBooked { get; set; }
    }
}
