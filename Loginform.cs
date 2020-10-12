using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace card_making_and_delivering_service
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Admin a = new Admin();
                a.Show();
            }
            else if (textBox1.Text == "client" && textBox2.Text == "client")
            {
                Client b = new Client();

                b.Show();
            }
            else if(textBox1.Text == ""  &&  textBox2.Text == "")
            {
                MessageBox.Show("plz enter in requried feilds");
            }
            else
            {
                MessageBox.Show("try again");
            }
        }
    }
}
