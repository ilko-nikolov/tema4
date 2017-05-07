using System;
using System.Collections.Generic;
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
                add1.Visible = false;
                advancedSearch1.Visible = false; 
                results1.Visible = true;
            }
            else if(menuButton.Text.Contains("Add"))
            {
                results1.Visible = false;
                add1.Visible = true;
                advancedSearch1.Visible = false;
            }
            else if(menuButton.Text.Contains("Advanced Search"))
            {
                results1.Visible = false;
                add1.Visible = false;
                advancedSearch1.Visible = true;
            }
            else if (menuButton.Text.Contains("About"))
            {
                AboutBox1 aboutBox = new AboutBox1();
                aboutBox.Show();
            }
        }

        void ShowResults() //изпълнява се само при натискане на бутона searchButton в AdvancedSearch.cs
        {
            results1.Visible = true;
            add1.Visible = false;
            advancedSearch1.Visible = false;
            results1.AdvancedSearch();
        }

        private void Form5_Shown(object sender, EventArgs e)
        { //извежда всички телефони, когато програмата се стартира
            advancedSearch1.Find("searchButton");
        }
    }
}
