namespace Automobile
{
    partial class Automobile
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
            this.oilCheckbox = new System.Windows.Forms.CheckBox();
            this.lubeCheckbox = new System.Windows.Forms.CheckBox();
            this.radCheckbox = new System.Windows.Forms.CheckBox();
            this.transCheckbox = new System.Windows.Forms.CheckBox();
            this.inspectionCheckbox = new System.Windows.Forms.CheckBox();
            this.mufflerCheckbox = new System.Windows.Forms.CheckBox();
            this.tireCheckbox = new System.Windows.Forms.CheckBox();
            this.partsTextbox = new System.Windows.Forms.TextBox();
            this.laborTextbox = new System.Windows.Forms.TextBox();
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxTextbox = new System.Windows.Forms.TextBox();
            this.taxLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.laborLabel = new System.Windows.Forms.Label();
            this.clearAllButton = new System.Windows.Forms.Button();
            this.getTotalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oilCheckbox
            // 
            this.oilCheckbox.AutoSize = true;
            this.oilCheckbox.Location = new System.Drawing.Point(12, 12);
            this.oilCheckbox.Name = "oilCheckbox";
            this.oilCheckbox.Size = new System.Drawing.Size(128, 20);
            this.oilCheckbox.TabIndex = 0;
            this.oilCheckbox.Text = "€50    Oil Change";
            this.oilCheckbox.UseVisualStyleBackColor = true;
            // 
            // lubeCheckbox
            // 
            this.lubeCheckbox.AutoSize = true;
            this.lubeCheckbox.Location = new System.Drawing.Point(12, 38);
            this.lubeCheckbox.Name = "lubeCheckbox";
            this.lubeCheckbox.Size = new System.Drawing.Size(118, 20);
            this.lubeCheckbox.TabIndex = 1;
            this.lubeCheckbox.Text = "€20    Lube Job";
            this.lubeCheckbox.UseVisualStyleBackColor = true;
            // 
            // radCheckbox
            // 
            this.radCheckbox.AutoSize = true;
            this.radCheckbox.Location = new System.Drawing.Point(12, 64);
            this.radCheckbox.Name = "radCheckbox";
            this.radCheckbox.Size = new System.Drawing.Size(149, 20);
            this.radCheckbox.TabIndex = 2;
            this.radCheckbox.Text = "€60    Radiator Flush";
            this.radCheckbox.UseVisualStyleBackColor = true;
            // 
            // transCheckbox
            // 
            this.transCheckbox.AutoSize = true;
            this.transCheckbox.Location = new System.Drawing.Point(12, 90);
            this.transCheckbox.Name = "transCheckbox";
            this.transCheckbox.Size = new System.Drawing.Size(179, 20);
            this.transCheckbox.TabIndex = 3;
            this.transCheckbox.Text = "€100  Transmission Flush";
            this.transCheckbox.UseVisualStyleBackColor = true;
            // 
            // inspectionCheckbox
            // 
            this.inspectionCheckbox.AutoSize = true;
            this.inspectionCheckbox.Location = new System.Drawing.Point(12, 116);
            this.inspectionCheckbox.Name = "inspectionCheckbox";
            this.inspectionCheckbox.Size = new System.Drawing.Size(123, 20);
            this.inspectionCheckbox.TabIndex = 4;
            this.inspectionCheckbox.Text = "€10    Inspection";
            this.inspectionCheckbox.UseVisualStyleBackColor = true;
            // 
            // mufflerCheckbox
            // 
            this.mufflerCheckbox.AutoSize = true;
            this.mufflerCheckbox.Location = new System.Drawing.Point(12, 142);
            this.mufflerCheckbox.Name = "mufflerCheckbox";
            this.mufflerCheckbox.Size = new System.Drawing.Size(186, 20);
            this.mufflerCheckbox.TabIndex = 5;
            this.mufflerCheckbox.Text = "€200  Muffler Replacement";
            this.mufflerCheckbox.UseVisualStyleBackColor = true;
            // 
            // tireCheckbox
            // 
            this.tireCheckbox.AutoSize = true;
            this.tireCheckbox.Location = new System.Drawing.Point(12, 168);
            this.tireCheckbox.Name = "tireCheckbox";
            this.tireCheckbox.Size = new System.Drawing.Size(136, 20);
            this.tireCheckbox.TabIndex = 6;
            this.tireCheckbox.Text = "€30   Tire Rotation";
            this.tireCheckbox.UseVisualStyleBackColor = true;
            // 
            // partsTextbox
            // 
            this.partsTextbox.Location = new System.Drawing.Point(199, 222);
            this.partsTextbox.Name = "partsTextbox";
            this.partsTextbox.Size = new System.Drawing.Size(166, 22);
            this.partsTextbox.TabIndex = 9;
            // 
            // laborTextbox
            // 
            this.laborTextbox.Location = new System.Drawing.Point(199, 194);
            this.laborTextbox.Name = "laborTextbox";
            this.laborTextbox.Size = new System.Drawing.Size(166, 22);
            this.laborTextbox.TabIndex = 10;
            // 
            // totalTextbox
            // 
            this.totalTextbox.Enabled = false;
            this.totalTextbox.Location = new System.Drawing.Point(199, 278);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.Size = new System.Drawing.Size(166, 22);
            this.totalTextbox.TabIndex = 11;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(9, 284);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 16);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "Total €";
            // 
            // taxTextbox
            // 
            this.taxTextbox.Enabled = false;
            this.taxTextbox.Location = new System.Drawing.Point(199, 250);
            this.taxTextbox.Name = "taxTextbox";
            this.taxTextbox.Size = new System.Drawing.Size(166, 22);
            this.taxTextbox.TabIndex = 13;
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Location = new System.Drawing.Point(9, 256);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(111, 16);
            this.taxLabel.TabIndex = 14;
            this.taxLabel.Text = "Tax on Parts 10%";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Location = new System.Drawing.Point(9, 228);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(38, 16);
            this.partsLabel.TabIndex = 15;
            this.partsLabel.Text = "Parts";
            // 
            // laborLabel
            // 
            this.laborLabel.AutoSize = true;
            this.laborLabel.Location = new System.Drawing.Point(9, 200);
            this.laborLabel.Name = "laborLabel";
            this.laborLabel.Size = new System.Drawing.Size(135, 16);
            this.laborLabel.TabIndex = 16;
            this.laborLabel.Text = "Labor Hours (€30 p/h)";
            // 
            // clearAllButton
            // 
            this.clearAllButton.Location = new System.Drawing.Point(15, 313);
            this.clearAllButton.Name = "clearAllButton";
            this.clearAllButton.Size = new System.Drawing.Size(146, 23);
            this.clearAllButton.TabIndex = 17;
            this.clearAllButton.Text = "Clear All";
            this.clearAllButton.UseVisualStyleBackColor = true;
            this.clearAllButton.Click += new System.EventHandler(this.clearAllButton_Click);
            // 
            // getTotalButton
            // 
            this.getTotalButton.Location = new System.Drawing.Point(199, 313);
            this.getTotalButton.Name = "getTotalButton";
            this.getTotalButton.Size = new System.Drawing.Size(166, 23);
            this.getTotalButton.TabIndex = 18;
            this.getTotalButton.Text = "Get Total";
            this.getTotalButton.UseVisualStyleBackColor = true;
            this.getTotalButton.Click += new System.EventHandler(this.getTotalButton_Click);
            // 
            // Automobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 347);
            this.Controls.Add(this.getTotalButton);
            this.Controls.Add(this.clearAllButton);
            this.Controls.Add(this.laborLabel);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.taxTextbox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.totalTextbox);
            this.Controls.Add(this.laborTextbox);
            this.Controls.Add(this.partsTextbox);
            this.Controls.Add(this.tireCheckbox);
            this.Controls.Add(this.mufflerCheckbox);
            this.Controls.Add(this.inspectionCheckbox);
            this.Controls.Add(this.transCheckbox);
            this.Controls.Add(this.radCheckbox);
            this.Controls.Add(this.lubeCheckbox);
            this.Controls.Add(this.oilCheckbox);
            this.Name = "Automobile";
            this.Text = "Automobile";
            this.Load += new System.EventHandler(this.Automobile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox oilCheckbox;
        private System.Windows.Forms.CheckBox lubeCheckbox;
        private System.Windows.Forms.CheckBox radCheckbox;
        private System.Windows.Forms.CheckBox transCheckbox;
        private System.Windows.Forms.CheckBox inspectionCheckbox;
        private System.Windows.Forms.CheckBox mufflerCheckbox;
        private System.Windows.Forms.CheckBox tireCheckbox;
        private System.Windows.Forms.TextBox partsTextbox;
        private System.Windows.Forms.TextBox laborTextbox;
        private System.Windows.Forms.TextBox totalTextbox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox taxTextbox;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label laborLabel;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.Button getTotalButton;
    }
}

