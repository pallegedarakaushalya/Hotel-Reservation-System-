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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Show();

            this.Hide();
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();
        }
    }
}
