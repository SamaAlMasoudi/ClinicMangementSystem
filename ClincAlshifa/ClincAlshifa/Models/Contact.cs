using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppointmentSystem.Models
{
    public class Contact
    {
        public int ContactID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime ContactDate { get; set; }
    }
}
