namespace ParkingSQL
{
    partial class History
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
            pictureBox1 = new PictureBox();
            logout_button = new Button();
            history_button = new Button();
            slots_button = new Button();
            dashboard_button = new Button();
            listView1 = new ListView();
            PN_search = new TextBox();
            search_button = new Button();
            label1 = new Label();
            panel2 = new Panel();
            close_label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(logout_button);
            panel1.Controls.Add(history_button);
            panel1.Controls.Add(slots_button);
            panel1.Controls.Add(dashboard_button);
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
            history_button.TabIndex = 23;
            history_button.Text = "History";
            history_button.UseVisualStyleBackColor = false;
            history_button.Click += history_button_Click;
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
            dashboard_button.Click += dashboard_button_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(195, 161);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 520);
            listView1.TabIndex = 28;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // PN_search
            // 
            PN_search.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PN_search.Location = new Point(603, 76);
            PN_search.Name = "PN_search";
            PN_search.Size = new Size(164, 35);
            PN_search.TabIndex = 44;
            // 
            // search_button
            // 
            search_button.BackColor = Color.FromArgb(64, 64, 64);
            search_button.FlatAppearance.BorderSize = 0;
            search_button.FlatStyle = FlatStyle.Flat;
            search_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_button.ForeColor = SystemColors.Control;
            search_button.Location = new Point(773, 76);
            search_button.Name = "search_button";
            search_button.Size = new Size(57, 35);
            search_button.TabIndex = 45;
            search_button.Text = "O";
            search_button.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(195, 25);
            label1.Name = "label1";
            label1.Size = new Size(329, 41);
            label1.TabIndex = 46;
            label1.Text = "Transaction History";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(195, 117);
            panel2.Name = "panel2";
            panel2.Size = new Size(635, 38);
            panel2.TabIndex = 47;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(834, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 48;
            close_label.Text = "X";
            close_label.Click += close_label_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(857, 693);
            Controls.Add(close_label);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(search_button);
            Controls.Add(PN_search);
            Controls.Add(listView1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "History";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button logout_button;
        private Button history_button;
        private Button slots_button;
        private Button dashboard_button;
        private ListView listView1;
        private TextBox PN_search;
        private Button search_button;
        private Label label1;
        private Panel panel2;
        private Label close_label;
    }
}