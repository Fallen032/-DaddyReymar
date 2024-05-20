namespace ParkingSQL
{
    partial class Dashboard
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
            panel1 = new Panel();
            history_button = new Button();
            logout_button = new Button();
            pictureBox1 = new PictureBox();
            slots_button = new Button();
            dashboard_button = new Button();
            close_label = new Label();
            button1 = new Button();
            listView1 = new ListView();
            parkout_button = new Button();
            PN_search = new TextBox();
            search_button = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(history_button);
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(slots_button);
            panel1.Controls.Add(dashboard_button);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(171, 693);
            panel1.TabIndex = 12;
            // 
            // history_button
            // 
            history_button.BackColor = Color.FromArgb(64, 64, 64);
            history_button.Cursor = Cursors.Hand;
            history_button.FlatAppearance.BorderSize = 0;
            history_button.FlatStyle = FlatStyle.Flat;
            history_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            history_button.ForeColor = SystemColors.Control;
            history_button.Location = new Point(0, 251);
            history_button.Name = "history_button";
            history_button.Size = new Size(171, 40);
            history_button.TabIndex = 28;
            history_button.Text = "History";
            history_button.UseVisualStyleBackColor = false;
            history_button.Click += history_button_Click;
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
            logout_button.TabIndex = 27;
            logout_button.Text = "Log Out";
            logout_button.UseVisualStyleBackColor = false;
            logout_button.Click += logout_button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(151, 123);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // slots_button
            // 
            slots_button.BackColor = Color.FromArgb(64, 64, 64);
            slots_button.Cursor = Cursors.Hand;
            slots_button.FlatAppearance.BorderSize = 0;
            slots_button.FlatStyle = FlatStyle.Flat;
            slots_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            slots_button.ForeColor = SystemColors.Control;
            slots_button.Location = new Point(0, 206);
            slots_button.Name = "slots_button";
            slots_button.Size = new Size(171, 40);
            slots_button.TabIndex = 23;
            slots_button.Text = "Parking Slots";
            slots_button.UseVisualStyleBackColor = false;
            slots_button.Click += slots_button_Click;
            // 
            // dashboard_button
            // 
            dashboard_button.BackColor = Color.FromArgb(64, 64, 64);
            dashboard_button.Cursor = Cursors.Hand;
            dashboard_button.FlatAppearance.BorderSize = 0;
            dashboard_button.FlatStyle = FlatStyle.Flat;
            dashboard_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            dashboard_button.ForeColor = SystemColors.Control;
            dashboard_button.Location = new Point(0, 161);
            dashboard_button.Name = "dashboard_button";
            dashboard_button.Size = new Size(171, 40);
            dashboard_button.TabIndex = 22;
            dashboard_button.Text = "Dashboard";
            dashboard_button.UseVisualStyleBackColor = false;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(837, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 25;
            close_label.Text = "X";
            close_label.Click += close_label_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(596, 140);
            button1.Name = "button1";
            button1.Size = new Size(115, 61);
            button1.TabIndex = 26;
            button1.Text = "Park In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(195, 251);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 411);
            listView1.TabIndex = 27;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // parkout_button
            // 
            parkout_button.BackColor = Color.FromArgb(64, 64, 64);
            parkout_button.FlatAppearance.BorderSize = 0;
            parkout_button.FlatStyle = FlatStyle.Flat;
            parkout_button.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkout_button.ForeColor = SystemColors.Control;
            parkout_button.Location = new Point(714, 140);
            parkout_button.Name = "parkout_button";
            parkout_button.Size = new Size(115, 61);
            parkout_button.TabIndex = 28;
            parkout_button.Text = "Park Out";
            parkout_button.UseVisualStyleBackColor = false;
            parkout_button.Click += parkout_button_Click;
            // 
            // PN_search
            // 
            PN_search.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PN_search.Location = new Point(195, 167);
            PN_search.Name = "PN_search";
            PN_search.Size = new Size(164, 35);
            PN_search.TabIndex = 43;
            // 
            // search_button
            // 
            search_button.BackColor = Color.FromArgb(64, 64, 64);
            search_button.FlatAppearance.BorderSize = 0;
            search_button.FlatStyle = FlatStyle.Flat;
            search_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_button.ForeColor = SystemColors.Control;
            search_button.Location = new Point(365, 167);
            search_button.Name = "search_button";
            search_button.Size = new Size(57, 35);
            search_button.TabIndex = 44;
            search_button.Text = "O";
            search_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label2);
            panel2.ForeColor = SystemColors.Control;
            panel2.Location = new Point(313, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(255, 82);
            panel2.TabIndex = 45;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.ForeColor = SystemColors.Control;
            panel4.Location = new Point(93, 37);
            panel4.Name = "panel4";
            panel4.Size = new Size(159, 32);
            panel4.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(93, 11);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 15;
            label2.Text = "Parked Vehicles";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(label1);
            panel3.ForeColor = SystemColors.Control;
            panel3.Location = new Point(574, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(255, 82);
            panel3.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.ForeColor = SystemColors.Control;
            panel5.Location = new Point(105, 37);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 32);
            panel5.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(105, 11);
            label1.Name = "label1";
            label1.Size = new Size(147, 23);
            label1.TabIndex = 15;
            label1.Text = "Available Slots";
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Location = new Point(195, 208);
            panel6.Name = "panel6";
            panel6.Size = new Size(635, 38);
            panel6.TabIndex = 49;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(857, 693);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(search_button);
            Controls.Add(PN_search);
            Controls.Add(parkout_button);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(close_label);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 8.25F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
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
        private Button slots_button;
        private Button dashboard_button;
        private Label close_label;
        private PictureBox pictureBox1;
        private Button button1;
        private ListView listView1;
        private Button parkout_button;
        private TextBox PN_search;
        private Button search_button;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Label label1;
        private Panel panel6;
        private Button logout_button;
        private Button history_button;
    }
}