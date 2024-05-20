namespace ParkingSQL
{
    partial class V_info
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
            pn_textBox = new TextBox();
            type_label = new Label();
            type_comboBox = new ComboBox();
            brand_comboBox = new ComboBox();
            brand_label = new Label();
            ok_button = new Button();
            close_label = new Label();
            pn_label = new Label();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_textBox
            // 
            pn_textBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pn_textBox.Location = new Point(173, 103);
            pn_textBox.Name = "pn_textBox";
            pn_textBox.Size = new Size(219, 33);
            pn_textBox.TabIndex = 16;
            // 
            // type_label
            // 
            type_label.AutoSize = true;
            type_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type_label.ForeColor = Color.Gray;
            type_label.Location = new Point(16, 158);
            type_label.Name = "type_label";
            type_label.Size = new Size(155, 25);
            type_label.TabIndex = 17;
            type_label.Text = "Vehicle Type :";
            // 
            // type_comboBox
            // 
            type_comboBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            type_comboBox.FormattingEnabled = true;
            type_comboBox.Location = new Point(173, 155);
            type_comboBox.Name = "type_comboBox";
            type_comboBox.Size = new Size(219, 32);
            type_comboBox.TabIndex = 18;
            // 
            // brand_comboBox
            // 
            brand_comboBox.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            brand_comboBox.FormattingEnabled = true;
            brand_comboBox.Location = new Point(173, 205);
            brand_comboBox.Name = "brand_comboBox";
            brand_comboBox.Size = new Size(219, 32);
            brand_comboBox.TabIndex = 20;
            brand_comboBox.SelectedIndexChanged += brand_comboBox_SelectedIndexChanged;
            // 
            // brand_label
            // 
            brand_label.AutoSize = true;
            brand_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brand_label.ForeColor = Color.Gray;
            brand_label.Location = new Point(4, 208);
            brand_label.Name = "brand_label";
            brand_label.Size = new Size(167, 25);
            brand_label.TabIndex = 19;
            brand_label.Text = "Vehicle Brand :";
            // 
            // ok_button
            // 
            ok_button.BackColor = Color.FromArgb(64, 64, 64);
            ok_button.Cursor = Cursors.Hand;
            ok_button.FlatAppearance.BorderSize = 0;
            ok_button.FlatStyle = FlatStyle.Flat;
            ok_button.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            ok_button.ForeColor = SystemColors.Control;
            ok_button.Location = new Point(261, 267);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(131, 69);
            ok_button.TabIndex = 23;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = false;
            ok_button.Click += ok_button_Click;
            // 
            // close_label
            // 
            close_label.AutoSize = true;
            close_label.Cursor = Cursors.Hand;
            close_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            close_label.Location = new Point(979, 0);
            close_label.Name = "close_label";
            close_label.Size = new Size(23, 24);
            close_label.TabIndex = 45;
            close_label.Text = "X";
            // 
            // pn_label
            // 
            pn_label.AutoSize = true;
            pn_label.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pn_label.ForeColor = Color.Gray;
            pn_label.Location = new Point(8, 106);
            pn_label.Name = "pn_label";
            pn_label.Size = new Size(163, 25);
            pn_label.TabIndex = 15;
            pn_label.Text = "Plate Number :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(377, -2);
            label1.Name = "label1";
            label1.Size = new Size(23, 24);
            label1.TabIndex = 46;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 15.75F, FontStyle.Italic);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(124, 267);
            button1.Name = "button1";
            button1.Size = new Size(131, 69);
            button1.TabIndex = 47;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 22);
            panel1.TabIndex = 48;
            // 
            // V_info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 400);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(close_label);
            Controls.Add(ok_button);
            Controls.Add(brand_comboBox);
            Controls.Add(brand_label);
            Controls.Add(type_comboBox);
            Controls.Add(type_label);
            Controls.Add(pn_textBox);
            Controls.Add(pn_label);
            FormBorderStyle = FormBorderStyle.None;
            Name = "V_info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_info";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox pn_textBox;
        private Label type_label;
        private ComboBox type_comboBox;
        private ComboBox brand_comboBox;
        private Label brand_label;
        private Button ok_button;
        private Label close_label;
        private Label pn_label;
        private Label label1;
        private Button button1;
        private Panel panel1;
    }
}