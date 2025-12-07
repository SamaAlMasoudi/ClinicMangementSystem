using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
namespace ClinicAppointmentSystem.Models
{
   public class Payment
    {
        public int PaymentID { get; set; }

        [Required]
        public int AppointmentID { get; set; }

        [Required]
        public string AccountNumber { get; set; }

        public Appointment Appointment { get; set; }
    }
}
