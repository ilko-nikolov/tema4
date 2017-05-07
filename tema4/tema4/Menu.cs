using System;
using System.Windows.Forms;

namespace tema4
{
    public partial class Menu : UserControl
    {
        public delegate void customHandler(object sender);
        public event customHandler send;

        public Menu()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        protected void MenuItem_Click(object sender, EventArgs e)
        {
            send(sender);
        }
    }
}
