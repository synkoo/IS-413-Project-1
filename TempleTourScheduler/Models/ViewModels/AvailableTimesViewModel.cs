using System;
using System.Collections.Generic;

namespace TempleTourScheduler.Models.ViewModels
{
    public class AvailableTimesViewModel
    {
        public AvailableTimesViewModel()
        {
        }

        public IEnumerable<TimeBlock> Monday { get; set; }
        public IEnumerable<TimeBlock> Tuesday { get; set; }
        public IEnumerable<TimeBlock> Wednesday { get; set; }
        public IEnumerable<TimeBlock> Thursday { get; set; }
        public IEnumerable<TimeBlock> Friday { get; set; }
        public IEnumerable<TimeBlock> Saturday { get; set; }
        public IEnumerable<TimeBlock> Sunday { get; set; }

        public string TimeSlot { get; set; }
        public string DayOfWeek { get; set; }
    }
}
