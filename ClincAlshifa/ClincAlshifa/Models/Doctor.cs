using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicAppointmentSystem.Models
{
    public class Doctor
    {
        public int DoctorID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Specialty { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
