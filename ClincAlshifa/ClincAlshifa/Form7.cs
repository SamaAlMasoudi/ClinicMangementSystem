using ClinicAppointmentSystem.data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppointmentSystem;
using System.Windows.Forms.VisualStyles;
using Newtonsoft.Json;

namespace ClinicAppointmentSystem
{
    public partial class Form7 : Form
       
    {
        string placeholder = "ادخل رقم الحساب";
        bool isPlaceholder = true;
        public Form7()
        {
            InitializeComponent();
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            textBoxAccount.Text = placeholder;
            textBoxAccount.ForeColor = Color.Gray;
            textBoxName.Text = Properties.Settings.Default["user_name"]?.ToString();
            textBoxPhone.Text = Properties.Settings.Default["user_phone"]?.ToString();
            textBoxCombo.Text = Properties.Settings.Default["appointment_doctor"]?.ToString();
            textBoxDate.Text = Properties.Settings.Default["appointment_date"]?.ToString();

            // ✅ عرض الوقت من الإعدادات مباشرة
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



        private void connect_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        private void ok_Click(object sender, EventArgs e)
        {
                string name = textBoxName.Text.Trim();
                string phone = textBoxPhone.Text.Trim();
                string doctor = textBoxCombo.Text.Trim();
                string date = textBoxDate.Text.Trim();
                string time = textBoxTime.Text.Trim();

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) ||
                    string.IsNullOrEmpty(doctor) || string.IsNullOrEmpty(date) || string.IsNullOrEmpty(time))
                {
                    MessageBox.Show("البيانات غير مكتملة. يرجى التأكد من صحة الحجز.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string key = $"appointments_{doctor}_{date}_{time}";

                string json = Properties.Settings.Default.AppointmentsData;
                var allAppointments = string.IsNullOrWhiteSpace(json)
                    ? new Dictionary<string, List<string>>()
                    : JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);

                // تحقق أن الموعد ما زال متاح
                if (allAppointments.ContainsKey(key))
                {
                    MessageBox.Show("عذرًا، تم حجز هذا الموعد مؤخرًا من قبل مستخدم آخر. يرجى اختيار وقت مختلف.", "موعد غير متاح", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Form5 f5 = new Form5();
                    f5.Show();
                    this.Close();
                    return;
                }

                // خزّن الموعد الآن بعد الدفع
                allAppointments[key] = new List<string> { name };
                Properties.Settings.Default.AppointmentsData = JsonConvert.SerializeObject(allAppointments);
                Properties.Settings.Default["account_number"] = textBoxAccount.Text.Trim();
                Properties.Settings.Default.Save();

                MessageBox.Show("تم إتمام عملية الدفع بنجاح. شكرًا لك!", "تم الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // الانتقال إلى صفحة التأكيد
                Form8 f8 = new Form8();
                f8.Show();
                this.Close();
            }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            if (isPlaceholder)
            {
                if (textBoxAccount.Text != placeholder)
                {
                    textBoxAccount.Text = textBoxAccount.Text.Replace(placeholder, "");
                    textBoxAccount.ForeColor = Color.Black;
                    isPlaceholder = false;
                    textBoxAccount.SelectionStart = textBoxAccount.Text.Length;
                }
            }
        }
        private void textBoxTime_TextChanged(object sender, EventArgs e)
        {

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
    }
}
