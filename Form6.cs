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
    public partial class Form6 : Form
    {
        // Static variable to track payment status
        public static bool IsPaymentSuccessful = false;


        public Form6()
        {
            InitializeComponent();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();

            form3.Show();

            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open the Payment form as a modal dialog
            Form8 paymentForm = new Form8();
            paymentForm.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
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

        private void roomsbtn_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();

            form4.Show();

            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

            
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = numericUpDown1.Minimum;
            numericUpDown2.Value = numericUpDown2.Minimum;
            textBox2.Clear(); 



            MessageBox.Show("All room and reservation details have been cleared.",
                            "Reset Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsPaymentSuccessful)
            {
                MessageBox.Show("Without payment, you can't confirm the reservation.",
                                "Reservation Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Reservation confirmed!",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string customerName = textBox2.Text; 
            string roomType = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : "Not selected";
            int numberOfRooms = (int)numericUpDown1.Value;
            int numberOfNights = (int)numericUpDown2.Value;



            string reservationDetails = $"Customer Name: {customerName}\n" +
                                        $"Room Type: {roomType}\n" +
                                        $"Number of Rooms: {numberOfRooms}\n"+
                                        $"Number of Nights: {numberOfNights}";

            // Show the details in a message box
            MessageBox.Show(reservationDetails,
                            "Reservation Details",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();

            form5.Show();

            this.Hide();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
