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
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Client a = new Client();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
