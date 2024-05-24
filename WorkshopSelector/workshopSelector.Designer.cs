namespace WorkshopSelector
{
    partial class WorkshopSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.workshopListBox = new System.Windows.Forms.ListBox();
            this.locationListBox = new System.Windows.Forms.ListBox();
            this.regFeeTextBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.lodgingFeeTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.regFeeLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.daysTextBox = new System.Windows.Forms.TextBox();
            this.DaysLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // workshopListBox
            // 
            this.workshopListBox.FormattingEnabled = true;
            this.workshopListBox.ItemHeight = 16;
            this.workshopListBox.Location = new System.Drawing.Point(12, 12);
            this.workshopListBox.Name = "workshopListBox";
            this.workshopListBox.Size = new System.Drawing.Size(160, 180);
            this.workshopListBox.TabIndex = 0;
            this.workshopListBox.SelectedIndexChanged += new System.EventHandler(this.workshopListBox_SelectedIndexChanged);
            // 
            // locationListBox
            // 
            this.locationListBox.FormattingEnabled = true;
            this.locationListBox.ItemHeight = 16;
            this.locationListBox.Location = new System.Drawing.Point(178, 12);
            this.locationListBox.Name = "locationListBox";
            this.locationListBox.Size = new System.Drawing.Size(160, 180);
            this.locationListBox.TabIndex = 1;
            this.locationListBox.SelectedIndexChanged += new System.EventHandler(this.locationListBox_SelectedIndexChanged);
            // 
            // regFeeTextBox
            // 
            this.regFeeTextBox.Location = new System.Drawing.Point(475, 13);
            this.regFeeTextBox.Name = "regFeeTextBox";
            this.regFeeTextBox.ReadOnly = true;
            this.regFeeTextBox.Size = new System.Drawing.Size(102, 22);
            this.regFeeTextBox.TabIndex = 2;
            
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(366, 144);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(211, 48);
            this.calcButton.TabIndex = 3;
            this.calcButton.Text = "Calculate Fee";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // lodgingFeeTextBox
            // 
            this.lodgingFeeTextBox.Location = new System.Drawing.Point(475, 88);
            this.lodgingFeeTextBox.Name = "lodgingFeeTextBox";
            this.lodgingFeeTextBox.ReadOnly = true;
            this.lodgingFeeTextBox.Size = new System.Drawing.Size(102, 22);
            this.lodgingFeeTextBox.TabIndex = 4;
            
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(475, 116);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(102, 22);
            this.outputTextBox.TabIndex = 5;
            // 
            // regFeeLabel
            // 
            this.regFeeLabel.AutoSize = true;
            this.regFeeLabel.Location = new System.Drawing.Point(363, 16);
            this.regFeeLabel.Name = "regFeeLabel";
            this.regFeeLabel.Size = new System.Drawing.Size(106, 16);
            this.regFeeLabel.TabIndex = 6;
            this.regFeeLabel.Text = "Registration Fee";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Location = new System.Drawing.Point(386, 88);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(83, 16);
            this.lodgingLabel.TabIndex = 7;
            this.lodgingLabel.Text = "Lodging Fee";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(431, 116);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(38, 16);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // daysTextBox
            // 
            this.daysTextBox.Location = new System.Drawing.Point(475, 43);
            this.daysTextBox.Name = "daysTextBox";
            this.daysTextBox.ReadOnly = true;
            this.daysTextBox.Size = new System.Drawing.Size(102, 22);
            this.daysTextBox.TabIndex = 9;
            
            // 
            // DaysLabel
            // 
            this.DaysLabel.AutoSize = true;
            this.DaysLabel.Location = new System.Drawing.Point(431, 43);
            this.DaysLabel.Name = "DaysLabel";
            this.DaysLabel.Size = new System.Drawing.Size(39, 16);
            this.DaysLabel.TabIndex = 10;
            this.DaysLabel.Text = "Days";
            // 
            // WorkshopSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 211);
            this.Controls.Add(this.DaysLabel);
            this.Controls.Add(this.daysTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.regFeeLabel);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.lodgingFeeTextBox);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.regFeeTextBox);
            this.Controls.Add(this.locationListBox);
            this.Controls.Add(this.workshopListBox);
            this.Name = "WorkshopSelector";
            this.Text = "Workshop Selector";
            this.Load += new System.EventHandler(this.WorkshopSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox workshopListBox;
        private System.Windows.Forms.ListBox locationListBox;
        private System.Windows.Forms.TextBox regFeeTextBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.TextBox lodgingFeeTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label regFeeLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox daysTextBox;
        private System.Windows.Forms.Label DaysLabel;
    }
}

