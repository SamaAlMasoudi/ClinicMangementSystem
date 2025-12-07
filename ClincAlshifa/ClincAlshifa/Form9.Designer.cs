namespace ClinicAppointmentSystem
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.message = new System.Windows.Forms.TextBox();
                this.panel2 = new System.Windows.Forms.Panel();
                this.button12 = new System.Windows.Forms.Button();
                this.label2 = new System.Windows.Forms.Label();
                this.panel1 = new System.Windows.Forms.Panel();
                this.main = new System.Windows.Forms.Button();
                this.connect = new System.Windows.Forms.Button();
                this.reseve = new System.Windows.Forms.Button();
                this.commant = new System.Windows.Forms.Button();
                this.about = new System.Windows.Forms.Button();
                this.button1 = new System.Windows.Forms.Button();
                this.label1 = new System.Windows.Forms.Label();
                this.panel4 = new System.Windows.Forms.Panel();
                this.name = new System.Windows.Forms.TextBox();
                this.email = new System.Windows.Forms.TextBox();
                this.label4 = new System.Windows.Forms.Label();
                this.send = new System.Windows.Forms.Button();
                this.panel2.SuspendLayout();
                this.panel1.SuspendLayout();
                this.panel4.SuspendLayout();
                this.SuspendLayout();
                // 
                // message
                // 
                this.message.ForeColor = System.Drawing.SystemColors.GrayText;
                this.message.Location = new System.Drawing.Point(109, 302);
                this.message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.message.Multiline = true;
                this.message.Name = "message";
                this.message.Size = new System.Drawing.Size(788, 117);
                this.message.TabIndex = 20;
                this.message.Text = "اكتب رسالتك هنا";
                this.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.message.TextChanged += new System.EventHandler(this.message_TextChanged);
                // 
                // panel2
                // 
                this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.panel2.Controls.Add(this.button12);
                this.panel2.Controls.Add(this.label2);
                this.panel2.Location = new System.Drawing.Point(10, 284);
                this.panel2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(1729, 101);
                this.panel2.TabIndex = 9;
                // 
                // button12
                // 
                this.button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.button12.Location = new System.Drawing.Point(2129, 176);
                this.button12.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.button12.Name = "button12";
                this.button12.Size = new System.Drawing.Size(231, 89);
                this.button12.TabIndex = 1;
                this.button12.Text = "الصفحة الرئيسية";
                this.button12.UseVisualStyleBackColor = true;
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                this.label2.Location = new System.Drawing.Point(836, 51);
                this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(151, 37);
                this.label2.TabIndex = 0;
                this.label2.Text = "عيادة الشفاء";
                // 
                // panel1
                // 
                this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.panel1.Controls.Add(this.panel2);
                this.panel1.Controls.Add(this.main);
                this.panel1.Controls.Add(this.connect);
                this.panel1.Controls.Add(this.reseve);
                this.panel1.Controls.Add(this.commant);
                this.panel1.Controls.Add(this.about);
                this.panel1.Controls.Add(this.button1);
                this.panel1.Controls.Add(this.label1);
                this.panel1.Location = new System.Drawing.Point(0, 2);
                this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(1729, 240);
                this.panel1.TabIndex = 18;
                // 
                // main
                // 
                this.main.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                this.main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.main.Location = new System.Drawing.Point(1331, 159);
                this.main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.main.Name = "main";
                this.main.Size = new System.Drawing.Size(162, 51);
                this.main.TabIndex = 6;
                this.main.Text = "الصفحة الرئيسية";
                this.main.UseVisualStyleBackColor = true;
                this.main.Click += new System.EventHandler(this.main_Click);
                // 
                // connect
                // 
                this.connect.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                this.connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.connect.Location = new System.Drawing.Point(328, 159);
                this.connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.connect.Name = "connect";
                this.connect.Size = new System.Drawing.Size(162, 51);
                this.connect.TabIndex = 5;
                this.connect.Text = "تواصل معنا";
                this.connect.UseVisualStyleBackColor = true;
                this.connect.Click += new System.EventHandler(this.connect_Click);
                // 
                // reseve
                // 
                this.reseve.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                this.reseve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.reseve.Location = new System.Drawing.Point(586, 159);
                this.reseve.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.reseve.Name = "reseve";
                this.reseve.Size = new System.Drawing.Size(162, 51);
                this.reseve.TabIndex = 4;
                this.reseve.Text = "لحجز موعد";
                this.reseve.UseVisualStyleBackColor = true;
                this.reseve.Click += new System.EventHandler(this.reseve_Click);
                // 
                // commant
                // 
                this.commant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                this.commant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.commant.Location = new System.Drawing.Point(842, 159);
                this.commant.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.commant.Name = "commant";
                this.commant.Size = new System.Drawing.Size(162, 51);
                this.commant.TabIndex = 3;
                this.commant.Text = "التعليقات";
                this.commant.UseVisualStyleBackColor = true;
                this.commant.Click += new System.EventHandler(this.commant_Click);
                // 
                // about
                // 
                this.about.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
                this.about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.about.Location = new System.Drawing.Point(1075, 159);
                this.about.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.about.Name = "about";
                this.about.Size = new System.Drawing.Size(162, 51);
                this.about.TabIndex = 2;
                this.about.Text = "عن الموقع";
                this.about.UseVisualStyleBackColor = true;
                this.about.Click += new System.EventHandler(this.about_Click);
                // 
                // button1
                // 
                this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.button1.Location = new System.Drawing.Point(2129, 176);
                this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(231, 89);
                this.button1.TabIndex = 1;
                this.button1.Text = "الصفحة الرئيسية";
                this.button1.UseVisualStyleBackColor = true;
                // 
                // label1
                // 
                this.label1.AutoSize = true;
                this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
                this.label1.Location = new System.Drawing.Point(836, 51);
                this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(151, 37);
                this.label1.TabIndex = 0;
                this.label1.Text = "عيادة الشفاء";
                // 
                // panel4
                // 
                this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                this.panel4.Controls.Add(this.name);
                this.panel4.Controls.Add(this.email);
                this.panel4.Controls.Add(this.label4);
                this.panel4.Controls.Add(this.send);
                this.panel4.Controls.Add(this.message);
                this.panel4.Cursor = System.Windows.Forms.Cursors.Arrow;
                this.panel4.Location = new System.Drawing.Point(387, 251);
                this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.panel4.Name = "panel4";
                this.panel4.Size = new System.Drawing.Size(985, 571);
                this.panel4.TabIndex = 20;
                // 
                // name
                // 
                this.name.Font = new System.Drawing.Font("Times New Roman", 10.2F);
                this.name.ForeColor = System.Drawing.SystemColors.GrayText;
                this.name.Location = new System.Drawing.Point(109, 128);
                this.name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.name.Name = "name";
                this.name.Size = new System.Drawing.Size(788, 31);
                this.name.TabIndex = 36;
                this.name.Text = "الإسم الكامل";
                this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
                // 
                // email
                // 
                this.email.Font = new System.Drawing.Font("Times New Roman", 10.2F);
                this.email.ForeColor = System.Drawing.SystemColors.GrayText;
                this.email.Location = new System.Drawing.Point(109, 210);
                this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.email.Name = "email";
                this.email.Size = new System.Drawing.Size(788, 31);
                this.email.TabIndex = 35;
                this.email.Text = "البريد الإلكتروني";
                this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
                // 
                // label4
                // 
                this.label4.AutoSize = true;
                this.label4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
                this.label4.Location = new System.Drawing.Point(444, 36);
                this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(139, 37);
                this.label4.TabIndex = 23;
                this.label4.Text = "تواصل معنا";
                // 
                // send
                // 
                this.send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(157)))), ((int)(((byte)(143)))));
                this.send.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.send.ForeColor = System.Drawing.SystemColors.ControlLightLight;
                this.send.Location = new System.Drawing.Point(109, 476);
                this.send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.send.Name = "send";
                this.send.Size = new System.Drawing.Size(789, 53);
                this.send.TabIndex = 18;
                this.send.Text = "إرسال";
                this.send.UseVisualStyleBackColor = false;
                this.send.Click += new System.EventHandler(this.send_Click);
                // 
                // Form9
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(1734, 872);
                this.Controls.Add(this.panel1);
                this.Controls.Add(this.panel4);
                this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
                this.Name = "Form9";
                this.Text = "Form9";
                this.Load += new System.EventHandler(this.Form9_Load);
                this.panel2.ResumeLayout(false);
                this.panel2.PerformLayout();
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.panel4.ResumeLayout(false);
                this.panel4.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.TextBox message;
            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.Button button12;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Button main;
            private System.Windows.Forms.Button connect;
            private System.Windows.Forms.Button reseve;
            private System.Windows.Forms.Button commant;
            private System.Windows.Forms.Button about;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.Panel panel4;
            private System.Windows.Forms.Button send;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.TextBox name;
            private System.Windows.Forms.TextBox email;
        }
    }