using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema4
{
    public partial class Form3 : Form
    {
        List<CPhone> list1 = new List<CPhone>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) //ADD
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            if(textBox1.Text=="")
            {
                errorProvider1.SetError(textBox1, "Fill the brand");
                return;
            }

            if(textBox2.Text=="")
            {
                errorProvider1.SetError(textBox2, "Fill the model");
                return;
            }

            if (textBox3.Text == "")
            {
                errorProvider1.SetError(textBox3, "Fill the Operating System");
                return;
            }

            if (textBox4.Text == "")
            {
                errorProvider1.SetError(textBox4, "Fill the version of the OS");
                return;
            }

            if (textBox5.Text == "")
            {
                errorProvider1.SetError(textBox5, "Fill the size of the memory");
                return;
            }

            if (textBox6.Text == "")
            {
                errorProvider1.SetError(textBox6, "Fill info about camera");
                return;
            }

            list1[i].brand = textBox1.Text;
            list1[i].model = textBox2.Text;
        }
    }
}
