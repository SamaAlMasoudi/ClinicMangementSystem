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
using System.Windows.Forms.VisualStyles;

namespace ClinicAppointmentSystem
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
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

            private void textBoxName_TextChanged(object sender, EventArgs e)
            {

            }
        private void Form8_Load(object sender, EventArgs e)
        {
                textBoxName.Text = Properties.Settings.Default["user_name"]?.ToString();
                textBoxPhone.Text = Properties.Settings.Default["user_phone"]?.ToString();
                textBoxCombo.Text = Properties.Settings.Default["appointment_doctor"]?.ToString();
                textBoxDate.Text = Properties.Settings.Default["appointment_date"]?.ToString();
                textBoxTime.Text = Properties.Settings.Default["appointment_time"]?.ToString() ?? "غير محدد";
                textBoxAccount.Text = Properties.Settings.Default["account_number"]?.ToString() ?? "غير محدد";
        }
        }
    }
