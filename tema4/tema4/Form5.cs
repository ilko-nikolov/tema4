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
            advancedSearch1.ShowResults += new AdvancedSearch.customHandler(ShowResults);

            search1.Visible = true;
            results1.Visible = true;
            add1.Visible = false;
            advancedSearch1.Visible = false;

            try { CPhone.phonesList = XmlSerialization.ReadFromXmlFile<List<CPhone>>("data.xml"); }
            catch { MessageBox.Show("Error when reading data file"); }
        }

        void Browse(object sender)
        {
            ToolStripMenuItem menuButton = (ToolStripMenuItem)sender;
            if (menuButton.Text.Contains("Home"))
            {
                search1.Visible = true;
                add1.Visible = false;
                advancedSearch1.Visible = false;
                results1.Location = new Point(9, 98);
                results1.Size = new Size(results1.Size.Width, ClientRectangle.Height - menu1.Size.Height - search1.Size.Height - 9*3 + 2);
                    
                results1.Visible = true;
                add1.Visible = false;
                advancedSearch1.Visible = false;
            }
            else if(menuButton.Text.Contains("Add"))
            {
                search1.Visible = false;
                results1.Visible = false;
                add1.Visible = true;
                advancedSearch1.Visible = false;
            }
            else if(menuButton.Text.Contains("Advanced Search"))
            {
                search1.Visible = false;
                results1.Visible = false;
                add1.Visible = false;
                advancedSearch1.Visible = true;
            }
        }

        void ShowResults()
        {
            results1.Location = advancedSearch1.Location;
            results1.Size = advancedSearch1.Size;
            search1.Visible = false;
            results1.Visible = true;
            add1.Visible = false;
            advancedSearch1.Visible = false;
            results1.AdvancedSearch();
        }
    }
}
