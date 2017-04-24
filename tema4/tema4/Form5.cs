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
    public partial class Form5 : Form
    {
        

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            menu1.send += new Menu.customHandler(Browse);

            add1.Visible = false;
        }

        void Browse(object sender)
        {
            ToolStripMenuItem menuButton = (ToolStripMenuItem)sender;
            if (menuButton.Text.Contains("Home"))
            {
                search1.Visible = true;
                results1.Visible = true;
                add1.Visible = false;
            }
            else if(menuButton.Text.Contains("Add"))
            {
                search1.Visible = false;
                results1.Visible = false;
                add1.Visible = true;
            }
        }

        
    }
}
