using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population
{
    public partial class Population : Form
    {
        // Init
        public Population()
        {
            InitializeComponent();
        }
        // Button Handlers
        private void runButton_Click(object sender, EventArgs e)
        {
            bool error = false;
            if (int.TryParse(daysTextbox.Text, out int daysClean)){}
            else 
            { 
                outputListbox.Items.Add("Days Textbox invalid input.");
                outputListbox.Items.Add("Use Numbers");
                outputListbox.Items.Add(" ");
                error = true;
            }
            if (int.TryParse(orgsTextbox.Text, out int orgsClean)){ }
            else 
            { 
                outputListbox.Items.Add("Org Textbox invalid input.");
                outputListbox.Items.Add("Use Numbers");
                outputListbox.Items.Add(" ");
                error = true;
            }
            if (Regex.IsMatch(incTextbox.Text, @"^\d+%?$")){ }
            else 
            {
                outputListbox.Items.Add("Increase Textbox invalid input.");
                outputListbox.Items.Add("Use Numbers as Percentage");
                outputListbox.Items.Add("(With or without %)");
                error = true;
            }   
            if (error == false)
            {
                decimal.TryParse(incTextbox.Text, out decimal incClean);
                String increaseText = Regex.Replace(incTextbox.Text, @"[^.0-9]", "");
                String AddString = "1           " + orgsClean.ToString();
                outputListbox.Items.Add(AddString);
                decimal AddDec = orgsClean;
                incClean = incClean / 100;

                for (int loop = 2; loop < (daysClean + 1); loop++)
                {
                    AddDec = AddDec + (AddDec * incClean);
                    AddString = loop.ToString() + "         " + AddDec.ToString();
                    outputListbox.Items.Add(AddString);
                }
            }
        }

        private void orgsTextbox_TextChanged(object sender, EventArgs e)
        {
            outputListbox.Items.Clear();
        }

        private void incTextbox_TextChanged(object sender, EventArgs e)
        {
            outputListbox.Items.Clear();
        }

        private void daysTextbox_TextChanged(object sender, EventArgs e)
        {
            outputListbox.Items.Clear();
        }
    }
}
