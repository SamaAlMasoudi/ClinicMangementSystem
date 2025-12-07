using ClinicAppointmentSystem.data;
using ClinicAppointmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace ClinicAppointmentSystem
{
    public partial class Form4 : Form
    {
            string placeholder = "اكتب تعليقك...";
            bool isPlaceholder = true;

            public Form4()
            {
                InitializeComponent();
            }


            private void panel4_Paint(object sender, PaintEventArgs e)
            {

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

            private void sendComment_Click(object sender, EventArgs e)
            {
                // التحقق من اختيار الطبيبة
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("الرجاء اختيار اسم الطبيبة من القائمة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // التحقق من كتابة تعليق فعلي
                string commentText = textBox1.Text.Trim();
                if (string.IsNullOrWhiteSpace(commentText) || commentText == placeholder)
                {
                    MessageBox.Show("الرجاء كتابة تعليق قبل الإرسال.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // تجهيز البيانات
                string selectedDoctor = comboBox1.SelectedItem.ToString();

                try
                {
                    using (var context = new ClinicContext())
                    {
                        var newContact = new Contact
                        {
                            Name = selectedDoctor,
                            Message = commentText,
                            ContactDate = DateTime.Now
                        };

                        context.Contacts.Add(newContact);
                        context.SaveChanges();

                        // ✅ فقط إذا نجح الحفظ، نعرض رسالة النجاح
                        MessageBox.Show("تم حفظ التعليق في قاعدة البيانات بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // إعادة تعيين الحقول
                        comboBox1.SelectedIndex = -1;
                        textBox1.Text = placeholder;
                        textBox1.ForeColor = Color.Gray;
                        isPlaceholder = true;
                    }
                }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("فشل حفظ التعليق. تحقق من صحة البيانات المدخلة.\n" + ex.InnerException?.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حفظ التعليق:\n" + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
            {
                if (isPlaceholder)
                {
                    if (textBox1.Text != placeholder)
                    {
                        textBox1.Text = textBox1.Text.Replace(placeholder, "");
                        textBox1.ForeColor = Color.Black;
                        isPlaceholder = false;
                        textBox1.SelectionStart = textBox1.Text.Length;
                    }
                }
            }

            private void Form4_Load(object sender, EventArgs e)
            {
                textBox1.Text = placeholder;
                textBox1.ForeColor = Color.Gray;
            }

            private void textBox1_Leave(object sender, EventArgs e)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    isPlaceholder = true;
                    textBox1.Text = placeholder;
                    textBox1.ForeColor = Color.Gray;
                }

            }

        }
    }
