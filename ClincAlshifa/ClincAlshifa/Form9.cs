using ClinicAppointmentSystem.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClinicAppointmentSystem
{
    public partial class Form9 : Form
    {
        string placeholder = "الإسم الكامل";
        bool isPlaceholder = true;
        string placeholder2 = "البريد الإلكنروني";
        bool isPlaceholder2 = true;
        string placeholder3 = "اكتب رسالتك هنا";
        bool isPlaceholder3 = true;
        public Form9()
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

            private void name_TextChanged(object sender, EventArgs e)
            {
            if (isPlaceholder)
            {
                if (name.Text != placeholder)
                {
                    name.Text = name.Text.Replace(placeholder, "");
                    name.ForeColor = Color.Black;
                    isPlaceholder = false;
                    name.SelectionStart = name.Text.Length;
                }
            }
        }

            private void email_TextChanged(object sender, EventArgs e)
            {
            if (isPlaceholder2)
            {
                if (email.Text != placeholder2)
                {
                    email.Text = email.Text.Replace(placeholder2, "");
                    email.ForeColor = Color.Black;
                    isPlaceholder2 = false;
                    email.SelectionStart = email.Text.Length;
                }
            }

        }

            private void message_TextChanged(object sender, EventArgs e)
            {
            if (isPlaceholder3)
            {
                if (message.Text != placeholder3)
                {
                    message.Text = message.Text.Replace(placeholder3, "");
                    message.ForeColor = Color.Black;
                    isPlaceholder3 = false;
                    message.SelectionStart = message.Text.Length;
                }
            }
        }

            private void Form9_Load(object sender, EventArgs e)
            {
            name.Text = placeholder;
            name.ForeColor = Color.Gray;
            email.Text = placeholder2;
            email.ForeColor = Color.Gray;
            message.Text = placeholder3;
            message.ForeColor = Color.Gray;
        }

            private void send_Click(object sender, EventArgs e)
            {
            string userName = name.Text.Trim();
            string userEmail = email.Text.Trim();
            string userMessage = message.Text.Trim();

            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userMessage))
            {
                MessageBox.Show("يرجى ملء جميع الحقول قبل إرسال الرسالة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // عرض رسالة تأكيد
            MessageBox.Show("تم إرسال رسالتك بنجاح! سنقوم بالرد عليك في أقرب وقت ممكن عبر البريد الإلكتروني.", "تم الإرسال", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // إعادة التوجيه إلى الصفحة الرئيسية
            Form1 firstForm = new Form1();
            firstForm.Show();
            this.Hide();
        }

    }
}

