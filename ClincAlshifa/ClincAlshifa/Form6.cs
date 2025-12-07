using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;


namespace ClinicAppointmentSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            textBoxName.Text = Properties.Settings.Default["user_name"]?.ToString();
            textBoxPhone.Text = Properties.Settings.Default["user_phone"]?.ToString();
            textBoxCombo.Text = Properties.Settings.Default["appointment_doctor"]?.ToString();
            textBoxDate.Text = Properties.Settings.Default["appointment_date"]?.ToString();

            // ✅ عرض الوقت مباشرة من Settings
            textBoxTime.Text = Properties.Settings.Default["appointment_time"]?.ToString() ?? "غير محدد";
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


            private void connect_Click(object sender, EventArgs e)
            {
                Form9 f9 = new Form9();
                f9.Show();
                this.Hide();
            }

            private void confirmation_Click(object sender, EventArgs e)
            {
            Form7 f7 = new Form7();
            f7.Show();
            this.Close();

        }

            private void modification_Click(object sender, EventArgs e)
            {
                Form5 f5 = new Form5();
                f5.Show();
                this.Close();
            }

            private void cancel_Click(object sender, EventArgs e)
            {
                string name = Properties.Settings.Default["user_name"]?.ToString();
                string doctor = Properties.Settings.Default["appointment_doctor"]?.ToString();
                string date = Properties.Settings.Default["appointment_date"]?.ToString();

                // استخراج AppointmentsData
                string json = Properties.Settings.Default.AppointmentsData;
                var allAppointments = string.IsNullOrWhiteSpace(json)
                    ? new Dictionary<string, List<string>>()
                    : JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);

                // البحث عن الموعد المحجوز لهذا المستخدم
                string keyToRemove = allAppointments
                    .FirstOrDefault(kvp => kvp.Key.StartsWith($"appointments_{doctor}_{date}") &&
                                           kvp.Value.Contains(name)).Key;

                if (!string.IsNullOrEmpty(keyToRemove))
                {
                    allAppointments.Remove(keyToRemove);
                    Properties.Settings.Default.AppointmentsData = JsonConvert.SerializeObject(allAppointments);
                }

                // مسح بيانات المستخدم
                Properties.Settings.Default["user_name"] = "";
                Properties.Settings.Default["user_phone"] = "";
                Properties.Settings.Default["appointment_doctor"] = "";
                Properties.Settings.Default["appointment_date"] = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("تم إلغاء الحجز بنجاح. يمكنك الحجز مرة أخرى في أي وقت.", "إلغاء", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 f1 = new Form1();
                f1.Show();
                this.Close();
            }

        private void time_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBoxName_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }
