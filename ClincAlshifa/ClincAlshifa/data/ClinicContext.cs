using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicAppointmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentSystem.data
{
    public class ClinicContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // تأكد من أن اسم السيرفر وقاعدة البيانات صحيحين حسب جهازك
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=MyNewClinicDB;Trusted_Connection=True;");
        }
    }
}
