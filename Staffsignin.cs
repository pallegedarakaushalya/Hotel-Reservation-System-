using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Staffsignin : Form
    {
        public Staffsignin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 staff1 = new Form7();

            staff1.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 staff1 = new Form3();

            staff1.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StaffSignup staff1 = new StaffSignup();

            staff1.Show();

            this.Hide();
        }
    }
}
