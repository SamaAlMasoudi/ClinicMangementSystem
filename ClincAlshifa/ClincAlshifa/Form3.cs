using ClinicAppointmentSystem.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppointmentSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
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

            private void comment_Click(object sender, EventArgs e)
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }

            private void reserve_Click(object sender, EventArgs e)
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

            private void Form3_Load(object sender, EventArgs e)
            {
                using (var context = new ClinicContext())
                {
                    var comments = context.Contacts
                        .OrderByDescending(c => c.ContactDate)
                        .ToList();

                    StringBuilder sb = new StringBuilder();

                    foreach (var comment in comments)
                    {
                        sb.AppendLine($"{comment.Name}: {comment.Message}");
                    }

                    richTextBox1.Text = sb.ToString();
                }
            }

        }
    }
