namespace Population
{
    partial class Population
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
            this.orgsLabel = new System.Windows.Forms.Label();
            this.incLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.orgsTextbox = new System.Windows.Forms.TextBox();
            this.incTextbox = new System.Windows.Forms.TextBox();
            this.daysTextbox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orgsLabel
            // 
            this.orgsLabel.AutoSize = true;
            this.orgsLabel.Location = new System.Drawing.Point(12, 19);
            this.orgsLabel.Name = "orgsLabel";
            this.orgsLabel.Size = new System.Drawing.Size(185, 16);
            this.orgsLabel.TabIndex = 0;
            this.orgsLabel.Text = "Starting Number of Organisms";
            // 
            // incLabel
            // 
            this.incLabel.AutoSize = true;
            this.incLabel.Location = new System.Drawing.Point(12, 68);
            this.incLabel.Name = "incLabel";
            this.incLabel.Size = new System.Drawing.Size(163, 16);
            this.incLabel.TabIndex = 1;
            this.incLabel.Text = "Average Daily Increase %";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(12, 117);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(104, 16);
            this.daysLabel.TabIndex = 2;
            this.daysLabel.Text = "Number of Days";
            // 
            // outputListbox
            // 
            this.outputListbox.ColumnWidth = 85;
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.ItemHeight = 16;
            this.outputListbox.Location = new System.Drawing.Point(203, 19);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.outputListbox.Size = new System.Drawing.Size(304, 212);
            this.outputListbox.TabIndex = 3;
            // 
            // orgsTextbox
            // 
            this.orgsTextbox.Location = new System.Drawing.Point(12, 38);
            this.orgsTextbox.Name = "orgsTextbox";
            this.orgsTextbox.Size = new System.Drawing.Size(185, 22);
            this.orgsTextbox.TabIndex = 4;
            this.orgsTextbox.TextChanged += new System.EventHandler(this.orgsTextbox_TextChanged);
            // 
            // incTextbox
            // 
            this.incTextbox.Location = new System.Drawing.Point(15, 87);
            this.incTextbox.Name = "incTextbox";
            this.incTextbox.Size = new System.Drawing.Size(182, 22);
            this.incTextbox.TabIndex = 5;
            this.incTextbox.TextChanged += new System.EventHandler(this.incTextbox_TextChanged);
            // 
            // daysTextbox
            // 
            this.daysTextbox.Location = new System.Drawing.Point(15, 136);
            this.daysTextbox.Name = "daysTextbox";
            this.daysTextbox.Size = new System.Drawing.Size(182, 22);
            this.daysTextbox.TabIndex = 6;
            this.daysTextbox.TextChanged += new System.EventHandler(this.daysTextbox_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(15, 164);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(182, 66);
            this.runButton.TabIndex = 7;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Population
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 242);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.daysTextbox);
            this.Controls.Add(this.incTextbox);
            this.Controls.Add(this.orgsTextbox);
            this.Controls.Add(this.outputListbox);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.incLabel);
            this.Controls.Add(this.orgsLabel);
            this.Name = "Population";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orgsLabel;
        private System.Windows.Forms.Label incLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.ListBox outputListbox;
        private System.Windows.Forms.TextBox orgsTextbox;
        private System.Windows.Forms.TextBox incTextbox;
        private System.Windows.Forms.TextBox daysTextbox;
        private System.Windows.Forms.Button runButton;
    }
}

