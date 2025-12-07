using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicAppointmentSystem.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        [Required]
        public int PatientID { get; set; }

        [Required]
        public int DoctorID { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}