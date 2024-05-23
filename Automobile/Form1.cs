using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class Automobile : Form
    {
        // Init
        public Automobile()
        {
            InitializeComponent();
        }

        private void Automobile_Load(object sender, EventArgs e)
        {
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFees();
        }

        // Checkbox Changes - not needed
 

        // Buttons
        private void clearAllButton_Click(object sender, EventArgs e)
        {
            clearOilLube();
            clearFlushes();
            clearMisc();
            clearOther();
            clearFees();
        }

        private void getTotalButton_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(partsTextbox.Text) && !Regex.IsMatch(partsTextbox.Text, @"^(-?0*\d+\.?\d{0,2})$")) || (!String.IsNullOrEmpty(laborTextbox.Text) && !Regex.IsMatch(laborTextbox.Text, @"^[0-9]")))
                {
                totalTextbox.Text = "Don't be messin.";
                }
            else
            {
                
                decimal total = TotalCharges();
                decimal tax = TaxCharges();
                taxTextbox.Text = tax.ToString();
                totalTextbox.Text = total.ToString();
            }
        }

        // Methods

        private decimal OilLubeCharges()
        {
            decimal output = 0;
            if(oilCheckbox.Checked == true)
            {
                output = 50;
            }
            if(lubeCheckbox.Checked == true)
            {
                output = output + 20;
            }
            return output;
        }
        private decimal FlushCharges() 
        {
            decimal output = 0;
            if (radCheckbox.Checked == true)
            {
                output = 60;
            }
            if (transCheckbox.Checked == true)
            {
                output = output + 100;
            }
            return output;
        }
        private decimal MiscCharges()
        {
            decimal output = 0;
            if (inspectionCheckbox.Checked == true)
            {
                output = 10;
            }
            if (mufflerCheckbox.Checked == true)
            {
                output = output + 200;
            }
            if (tireCheckbox.Checked == true)
            {
                output = output + 30;
            }
            return output;
        }
        private decimal OtherCharges()
        {
            decimal output = 0;
            if (decimal.TryParse(partsTextbox.Text, out decimal outParts))
            {
                output = outParts;
            }
            if (int.TryParse(laborTextbox.Text, out int outLabor))
            {
                
                output = output + (30 * outLabor);
            }
            return output;
        }
        private decimal TaxCharges()
        {
            decimal output = 0;
            if (decimal.TryParse(partsTextbox.Text, out decimal outParts))
            {
                output = outParts * 0.1m;
            }
            return output;
        }
        private decimal TotalCharges()
        {
            decimal output = OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges() + TaxCharges();
            
            return output;
        }
        private void clearOilLube()
        {
            oilCheckbox.Checked = false;
            lubeCheckbox.Checked = false;
        }
        private void clearFlushes()
        {
            radCheckbox.Checked = false;
            transCheckbox.Checked = false;
        }
        private void clearMisc()
        {
            inspectionCheckbox.Checked = false;
            mufflerCheckbox.Checked = false;
            tireCheckbox.Checked = false;
        }
        private void clearOther() 
        {
            partsTextbox.Text = string.Empty;
            laborTextbox.Text = string.Empty;
        }
        private void clearFees()
        {
            taxTextbox.Text = string.Empty;
            totalTextbox.Text = string.Empty;
        }
    }
}
