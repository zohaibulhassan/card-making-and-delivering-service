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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }
        
        public void button2_Click(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "")
            {
                MessageBox.Show("Feilds Requried");
            }
            else
            {               Admin a = new Admin();
                a.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                list b = new list();
                b.dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text);
                a.Show();

                b.Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox5.Text = label5.Text;
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        { 
            textBox5.Text = label8.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
            textBox5.Text = label7.Text;
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
            textBox5.Text = label6.Text;
           
        }
    }
}
