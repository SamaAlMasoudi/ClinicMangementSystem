using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClinicAppointmentSystem.Models
{
    public class Patient
    {
        public int PatientID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Phone { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
