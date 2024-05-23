namespace ChargeAccountValidation
{
    partial class Form1
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
            this.entryTextbox = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.entryLabel = new System.Windows.Forms.Label();
            this.outputListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // entryTextbox
            // 
            this.entryTextbox.Location = new System.Drawing.Point(15, 32);
            this.entryTextbox.Name = "entryTextbox";
            this.entryTextbox.Size = new System.Drawing.Size(192, 22);
            this.entryTextbox.TabIndex = 0;
            this.entryTextbox.TextChanged += new System.EventHandler(this.entryTextbox_TextChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(15, 60);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(192, 41);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Validate Code";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 3;
            // 
            // entryLabel
            // 
            this.entryLabel.AutoSize = true;
            this.entryLabel.Location = new System.Drawing.Point(18, 13);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(189, 16);
            this.entryLabel.TabIndex = 5;
            this.entryLabel.Text = "Enter Your Account Code Here";
            // 
            // outputListbox
            // 
            this.outputListbox.Enabled = false;
            this.outputListbox.FormattingEnabled = true;
            this.outputListbox.ItemHeight = 16;
            this.outputListbox.Location = new System.Drawing.Point(213, 12);
            this.outputListbox.Name = "outputListbox";
            this.outputListbox.Size = new System.Drawing.Size(338, 84);
            this.outputListbox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 117);
            this.Controls.Add(this.outputListbox);
            this.Controls.Add(this.entryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.entryTextbox);
            this.Name = "Form1";
            this.Text = "Account Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox entryTextbox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label entryLabel;
        private System.Windows.Forms.ListBox outputListbox;
    }
}

