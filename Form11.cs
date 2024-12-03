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

namespace Hotel_Reservation_System
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form10 formm10 = new form10();

            formm10.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox5.Text;
            string password = textBox7.Text;
          


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) )
            {
                MessageBox.Show("Please fill in all the fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }


          

            // Display success message
            string message = $"Username: {username}\nSuccessfully signed up!";
            MessageBox.Show(message,
                            "Signup Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Optionally, clear the fields after signup
            textBox5.Clear();
            textBox7.Clear();
          
        }
    }
}
