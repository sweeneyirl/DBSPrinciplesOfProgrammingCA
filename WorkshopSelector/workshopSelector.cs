using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace WorkshopSelector
{
    public partial class WorkshopSelector : Form
    {
        public WorkshopSelector()
        {
            InitializeComponent();
        }

        public workshopListBoxHandler()
        {
            ArrayList Workshops = new ArrayList();
            Workshops.Add(new Workshop("A", 1));
            Workshops.Add(new Workshop("B", 2));
            Workshops.Add(new Workshop("C", 3));
            Workshops.Add(new Workshop("D", 4));
            Workshops.Add(new Workshop("E", 5));
            Workshops.DataSource = Workshops;

            workshopListBox.DisplayMember = "WSName";
            workshopListBox.ValueMember = "WSValue";

            // Bind the SelectedValueChanged event to our handler for it.
            workshopListBox.SelectedIndexChanged +=
                new EventHandler(workshopListBox_SelectedIndexChanged);

            // Ensure the form opens with no rows selected.
            workshopListBox.ClearSelected();
        }

        public class Workshop
        {
            private int myValue;
            private string myLongName;

            public Workshop(string WSName, int WSValue)
            {

                this.myValue = WSValue;
                this.myWSName = WSName;
            }

            public int myWSValue
            {
                get
                {
                    return WSValue;
                }
            }

            public string myWSName
            {

                get
                {
                    return WSName;
                }
            }
        }
        private void workshopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void regFeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lodgingFeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {

        }
    }
}
