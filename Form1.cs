using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boat_reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReserve.Enabled = false;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Canoe");
            comboBox1.Items.Add("Kayak");
            comboBox1.Items.Add("Paddleboard");

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckreservation_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("It can't be plank please put some infromation");
                btnReserve.Enabled = true;
                comboBox1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else if (!(comboBox1.SelectedItem.ToString() == "kayak" && Convert.ToInt32(textBox1.Text) == 1 && Convert.ToInt32(textBox2.Text) == 0))
            {
                //textBox1.Text = Convert.ToString(1);
                //textBox2.Text = "0";

                lblNotChecked.Text = "Your Boat:" + comboBox1.Text + "\nYour chilren Number:" + textBox1.Text + "\nYour Adult:" + textBox2.Text;
                MessageBox.Show("Your Boat:" + comboBox1.Text + "\nYour chilren Number:" + textBox1.Text + "\nYour Adult:" + textBox2.Text);
                //delete();
            }
            else
            {
                MessageBox.Show("this boat can only rent one udults and 0 children");
                delete();
            }

            //else
            //{

            //    lblNotChecked.Text = "Your Boat:" + comboBox1.Text + "\nYour chilren Number:" + textBox1.Text + "\nYour Adult:" + textBox2.Text;
            //    MessageBox.Show("Your Boat:" + comboBox1.Text + "\nYour chilren Number:" + textBox1.Text + "\nYour Adult:" + textBox2.Text);
            //}
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            delete();
        }
        public void delete()
        {
            textBox1.Clear();
            textBox2.Clear();
            lblNotChecked.Text = "";
            comboBox1.SelectedIndex = -1;
        }
    }
}
