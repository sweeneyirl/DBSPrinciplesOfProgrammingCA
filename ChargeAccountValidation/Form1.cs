using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ChargeAccountValidation
{
    public partial class Form1 : Form
    {
        // Init
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputListbox.Items.Clear();
        }
        // Refresh
        private void entryTextbox_TextChanged(object sender, EventArgs e)
        {
            outputListbox.Items.Clear();
        }
        // Button
        private void runButton_Click(object sender, EventArgs e)
        {
            if (getAccounts().Contains("No File"))
            {
                outputListbox.Items.Add("Error: Missing File");
            }
            else if (getAccounts().Contains(entryTextbox.Text)) 
            {
                outputListbox.Items.Add("Winner Winner");
            }
            else
            {
                outputListbox.Items.Add("Nope");
            }
        }
        // Get Data from file
        private string[] getAccounts()
        {
            try
            {
                using (StreamReader inputFile = new StreamReader("../../Data/charge_account.txt"))
                {
                    String getterString = null;
                    while (inputFile.EndOfStream == false)
                    {
                        getterString = getterString + inputFile.ReadLine() + ";";
                    }
                    String[] outputString = getterString.Split(';');
                    return outputString;
                }
            }
            catch
            {
                string[] errorString = new String[1];
                errorString[0] = "No File";
                return errorString;
            }
            
        }

        
    }
}
