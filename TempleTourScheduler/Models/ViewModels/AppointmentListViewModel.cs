using System;
using System.Collections;
using System.Collections.Generic;

namespace TempleTourScheduler.Models.ViewModels
{
    public class AppointmentListViewModel
    {
        public AppointmentListViewModel()
        {
        }
        public IEnumerable<Appointment> Monday { get; set; }
        public IEnumerable<Appointment> Tuesday { get; set; }
        public IEnumerable<Appointment> Wednesday { get; set; }
        public IEnumerable<Appointment> Thursday { get; set; }
        public IEnumerable<Appointment> Friday { get; set; }
        public IEnumerable<Appointment> Saturday { get; set; }
        public IEnumerable<Appointment> Sunday { get; set; }
    }
}
