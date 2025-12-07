using ClinicAppointmentSystem.data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClinicAppointmentSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // تعبئة قائمة الأطباء
            //comboBoxDoctor.Items.Add("-- اختر --");
            //comboBoxDoctor.Items.Add("د. سندس - أطفال");
            //comboBoxDoctor.Items.Add("د. سماء - قلب");
            //comboBoxDoctor.Items.Add("د. شريفة - أسنان");
            comboBoxDoctor.SelectedIndex = 0;
            comboBoxDoctor.SelectedIndexChanged += (s, ev) => UpdateAvailableTimes();
            dateTimePicker1.ValueChanged += (s, ev) => UpdateAvailableTimes();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void writeComment_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void main_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void about_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }


        private void connect_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void next_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();
            string doctor = comboBoxDoctor.SelectedItem?.ToString();
            string date = dateTimePicker1.Value.ToShortDateString();
            string time = comboBoxTime.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(doctor) || doctor == "-- اختر --" ||
                string.IsNullOrEmpty(time) || time == "لا توجد أوقات متاحة")
            {
                MessageBox.Show("يرجى ملء جميع الحقول واختيار وقت متاح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string key = $"appointments_{doctor}_{date}_{time}";

            string json = Properties.Settings.Default.AppointmentsData;
            var allAppointments = string.IsNullOrWhiteSpace(json)
                ? new Dictionary<string, List<string>>()
                : JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);

            if (allAppointments.ContainsKey(key))
            {
                MessageBox.Show("هذا الموعد محجوز مسبقًا. يرجى اختيار وقت آخر.", "موعد محجوز", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ تخزين البيانات فقط في Settings (بدون حجز الموعد الآن)
            Properties.Settings.Default["user_name"] = name;
            Properties.Settings.Default["user_phone"] = phone;
            Properties.Settings.Default["appointment_doctor"] = doctor;
            Properties.Settings.Default["appointment_date"] = date;
            Properties.Settings.Default["appointment_time"] = time; // مهم جدًا
            Properties.Settings.Default.Save();

            // الانتقال إلى صفحة التأكيد
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // كود عند تغيير النص
        }

        private void commant_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();

        }

        private void reseve_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();

        }

        private void UpdateAvailableTimes()
        {
            comboBoxTime.Items.Clear();

            string doctor = comboBoxDoctor.SelectedItem?.ToString();
            string date = dateTimePicker1.Value.ToShortDateString();

            if (string.IsNullOrEmpty(doctor) || doctor == "-- اختر --")
                return;

            List<string> allTimes = new List<string>
    {
        "09:00 صباحًا", "10:00 صباحًا", "11:00 صباحًا",
        "12:00 ظهرًا", "01:00 مساءً", "02:00 مساءً"
    };

            string json = Properties.Settings.Default.AppointmentsData;
            var allAppointments = string.IsNullOrWhiteSpace(json)
                ? new Dictionary<string, List<string>>()
                : JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);

            foreach (var time in allTimes)
            {
                string key = $"appointments_{doctor}_{date}_{time}";
                if (!allAppointments.ContainsKey(key))
                {
                    comboBoxTime.Items.Add(time);
                }
            }

            if (comboBoxTime.Items.Count > 0)
                comboBoxTime.SelectedIndex = 0;
            else
                comboBoxTime.Items.Add("لا توجد أوقات متاحة");
        }



    }
}