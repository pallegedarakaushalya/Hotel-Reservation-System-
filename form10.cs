﻿using System;
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
    public partial class form10 : Form
    {
        public form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string username = textBox5.Text; 
            string email = textBox6.Text;   
            string password = textBox7.Text; 
            string confirmPassword = textBox9.Text; 

          
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all the fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Display success message
            string message = $"Username: {username}\nEmail: {email}\nSuccessfully signed up!";
            MessageBox.Show(message,
                            "Signup Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // Optionally, clear the fields after signup
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox9.Clear();
        }
    }
}
