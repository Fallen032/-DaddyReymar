namespace ParkingSQL
{
    partial class ParkOut
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            logout_button = new Button();
            close_label = new Label();
            panel2 = new Panel();
            vdetails_label = new Label();
            pn_label = new Label();
            panel3 = new Panel();
            hour_label = new Label();
            status_label = new Label();
            change_label = new Label();
            button2 = new Button();
            PN_search = new TextBox();
            label7 = new Label();
            button1 = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(logout_button);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 693);
            panel1.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 123);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // logout_button
            // 
            logout_button.BackColor = Color.FromArgb(64, 64, 64);
            logout_button.Cursor = Cursors.Hand;
            logout_button.FlatAppearance.BorderSize = 0;
            logout_button.FlatStyle = FlatStyle.Flat;
            logout_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            logout_button.ForeColor = SystemColors.Control;
            logout_button.Location = new Point(0, 564);
            logout_button.Name = "logout_button";
            logout_button.Size = new Size(171, 40);
            logout_button.TabIndex = 23;
            logout_button.Text = "Log Out";
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += logout_button_Click;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(835, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 45;
            close_label.Text = "X";
            close_label.Click += close_label_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(vdetails_label);
            panel2.Controls.Add(pn_label);
            panel2.Location = new Point(184, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 587);
            panel2.TabIndex = 46;
            // 
            // vdetails_label
            // 
            vdetails_label.AutoSize = true;
            vdetails_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vdetails_label.ForeColor = Color.Gray;
            vdetails_label.Location = new Point(19, 35);
            vdetails_label.Name = "vdetails_label";
            vdetails_label.Size = new Size(21, 25);
            vdetails_label.TabIndex = 54;
            vdetails_label.Text = "-";
            // 
            // pn_label
            // 
            pn_label.AutoSize = true;
            pn_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pn_label.ForeColor = Color.Gray;
            pn_label.Location = new Point(3, 10);
            pn_label.Name = "pn_label";
            pn_label.Size = new Size(162, 25);
            pn_label.TabIndex = 16;
            pn_label.Text = "Vehicle Details";
            // 
            // panel3
            // 
            panel3.Controls.Add(hour_label);
            panel3.Controls.Add(status_label);
            panel3.Controls.Add(change_label);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(PN_search);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dateTimePicker2);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(439, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 546);
            panel3.TabIndex = 47;
            // 
            // hour_label
            // 
            hour_label.AutoSize = true;
            hour_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            hour_label.ForeColor = Color.Gray;
            hour_label.Location = new Point(147, 151);
            hour_label.Name = "hour_label";
            hour_label.Size = new Size(51, 25);
            hour_label.TabIndex = 55;
            hour_label.Text = "-     ";
            // 
            // status_label
            // 
            status_label.AutoSize = true;
            status_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            status_label.ForeColor = Color.Gray;
            status_label.Location = new Point(147, 105);
            status_label.Name = "status_label";
            status_label.Size = new Size(21, 25);
            status_label.TabIndex = 54;
            status_label.Text = "-";
            // 
            // change_label
            // 
            change_label.AutoSize = true;
            change_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            change_label.ForeColor = Color.Gray;
            change_label.Location = new Point(147, 63);
            change_label.Name = "change_label";
            change_label.Size = new Size(21, 25);
            change_label.TabIndex = 53;
            change_label.Text = "-";
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(145, 325);
            button2.Name = "button2";
            button2.Size = new Size(231, 61);
            button2.TabIndex = 52;
            button2.Text = "Pay";
            button2.UseVisualStyleBackColor = false;
            // 
            // PN_search
            // 
            PN_search.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PN_search.Location = new Point(146, 286);
            PN_search.Name = "PN_search";
            PN_search.Size = new Size(231, 33);
            PN_search.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(8, 296);
            label7.Name = "label7";
            label7.Size = new Size(132, 23);
            label7.TabIndex = 50;
            label7.Text = "Enter Amount";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(320, 248);
            button1.Name = "button1";
            button1.Size = new Size(57, 31);
            button1.TabIndex = 49;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(146, 246);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(168, 31);
            dateTimePicker2.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(147, 202);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 249);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 21;
            label6.Text = "Park Out Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(3, 202);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 20;
            label5.Text = "Park Out Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(63, 151);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 19;
            label4.Text = "Hour/s";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(61, 105);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 18;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(46, 63);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 17;
            label2.Text = "Change";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(146, 25);
            label1.TabIndex = 16;
            label1.Text = "Total Amount";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.ForeColor = Color.White;
            panel4.Location = new Point(184, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(649, 76);
            panel4.TabIndex = 54;
            // 
            // ParkOut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 693);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(close_label);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ParkOut";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParkOut";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button logout_button;
        private Label close_label;
        private Panel panel2;
        private Panel panel3;
        private Label pn_label;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Button button1;
        private Button button2;
        private TextBox PN_search;
        private Panel panel4;
        private Label vdetails_label;
        private Label hour_label;
        private Label status_label;
        private Label change_label;
    }
}