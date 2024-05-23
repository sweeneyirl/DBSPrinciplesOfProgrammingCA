using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Population : Form
    {
        public Population()
        {
            InitializeComponent();
        }
        private void Population_Load(object sender, EventArgs e)
        {

        }
        private class LBOutput
        {
            public LBOutput(int orgs, int increase, int days)
            {
                this.Orgs = orgs;
                this.Increase = increase;
                this.Days = days;
            }
            public int Orgs { get; set; }
            public int Increase { get; set; }
            public int Days { get; set; }

        }
        private void runButton_Click(object sender, EventArgs e)
        {
        
            if (int.TryParse(daysTextbox.Text, out int days))
            {
                if (int.TryParse(orgsTextbox.Text, out int orgs))
                {
                    if (int.TryParse(incTextbox.Text, out int inc))
                    {
                        
                        
                        outputListbox.Items.Add("Yiss");

                    }
                    else { outputListbox.Items.Add("Increase Textbox invalid input. Use Numbers"); }
                } else { outputListbox.Items.Add("Org Textbox invalid input. Use numbers."); }
            } else { outputListbox.Items.Add("Days Textbox invalid input. Use Numbers"); }
        }

        private void orgsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void incTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void daysTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
