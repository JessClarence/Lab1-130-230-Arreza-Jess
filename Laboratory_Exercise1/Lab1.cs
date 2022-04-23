
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Project: VB University - Student Information 
// Jess Clarence I. Arreza
// April 22 , 2022



namespace Laboratory_Exercise1
{


    public partial class Lab1 : Form
    {

        

        public Lab1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            part_desc.Text = "Ford Brake Shows and Calipers";
            price.Text = "$130.00";
            qty_stock.Text = "15";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            part_desc.Text = "Discounted Oil Filters for Toyotas";
            price.Text = "$20.00";
            qty_stock.Text = "20";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            part_desc.Text = "Jaguar Wiper Blades";
            price.Text = "$49.95";
            qty_stock.Text = "10";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            part_desc.Text = "";
            price.Text = "";
            qty_stock.Text = "";
        }

        private void print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printed:\n\npart description: " + part_desc.Text + "\nprice: " + price.Text + "\nquantity stocks: " + qty_stock.Text);
        }
    }
}
