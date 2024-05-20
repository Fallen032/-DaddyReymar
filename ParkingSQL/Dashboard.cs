using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSQL
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void slots_button_Click(object sender, EventArgs e)
        {
            ParkingSlots slots = new ParkingSlots();
            slots.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            V_info info = new V_info();
            info.Show();
            this.Hide();
        }

        private void close_label_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parkout_button_Click(object sender, EventArgs e)
        {
            ParkOut parkout = new ParkOut();
            parkout.Show();
            this.Hide();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void history_button_Click(object sender, EventArgs e)
        {
            History history = new History();
            history.Show();
            this.Hide();
        }
    }
}
