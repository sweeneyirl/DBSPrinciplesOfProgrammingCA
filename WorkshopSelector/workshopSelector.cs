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

        internal class Workshop
        {
            public Workshop(string name, int days, int value)
            {
                this.Name = name;
                this.Days = days;
                this.Value = value;
            }

            public string Name { get; set; }
            public int Value { get; set; }
            public int Days { get; set; }

        }
        internal class WorkshopLocation
        {
            public WorkshopLocation(string name, int value)
            {
                this.Name = name;
                this.Value = value;
            }

            public string Name { get; set; }
            public int Value { get; set; }
        }
        public void workshopListBoxHandler()
        {
            Workshop[] workshops = {
                                    new Workshop("Handling Stress", 3, 1000),
                                    new Workshop("Time Management", 3, 500),
                                    new Workshop("Supervision Skills", 3, 1500),
                                    new Workshop("Negotiation Skills", 5, 1300),
                                    new Workshop("How to Interview", 1, 500)
                                    };

            this.workshopListBox.DataSource = workshops;
            this.workshopListBox.DisplayMember = "Name";
        }
        public void locationListBoxHandler()
        {
            WorkshopLocation[] locations = {
                                            new WorkshopLocation("Dublin", 300),
                                            new WorkshopLocation("Limerick", 200),
                                            new WorkshopLocation("Cork", 300),
                                            new WorkshopLocation("Kerry", 200),
                                            new WorkshopLocation("Belfast", 400),
                                            new WorkshopLocation("Sligo", 150)
                                            };

            this.locationListBox.DataSource = locations;
            this.locationListBox.DisplayMember = "Name";
        }

        private void workshopListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            regFeeTextBox.Text = (((Workshop)this.workshopListBox.SelectedItem).Value).ToString();
            daysTextBox.Text = (((Workshop)this.workshopListBox.SelectedItem).Days).ToString();    
        }

        private void locationListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lodgingFeeTextBox.Text = (((WorkshopLocation)this.locationListBox.SelectedItem).Value).ToString();
        }

        private void regFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }

        private void lodgingFeeTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = 
                (
                    (
                        (((WorkshopLocation)this.locationListBox.SelectedItem).Value) 
                        * 
                        (((Workshop)this.workshopListBox.SelectedItem).Days)
                    ) 
                    + 
                    (((Workshop)this.workshopListBox.SelectedItem).Value)
                ).ToString();
        }

        private void WorkshopSelector_Load(object sender, EventArgs e)
        {
            this.workshopListBoxHandler();
            this.locationListBoxHandler();
        }

        private void daysTextBox_TextChanged(object sender, EventArgs e)
        {
            outputTextBox.Clear();
        }
    }
}
