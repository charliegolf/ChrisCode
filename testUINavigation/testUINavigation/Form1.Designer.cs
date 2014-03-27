namespace testUINavigation
{
    partial class testUIAutomationForm
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
            this.testDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.Label();
            this.testComboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // testDateTimePicker
            // 
            this.testDateTimePicker.Location = new System.Drawing.Point(104, 12);
            this.testDateTimePicker.Name = "testDateTimePicker";
            this.testDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.testDateTimePicker.TabIndex = 0;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(22, 18);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(66, 13);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date Control";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.AutoSize = true;
            this.textBoxLabel.Location = new System.Drawing.Point(22, 57);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(82, 13);
            this.textBoxLabel.TabIndex = 3;
            this.textBoxLabel.Text = "TextBox Control";
            // 
            // testComboBox1
            // 
            this.testComboBox1.FormattingEnabled = true;
            this.testComboBox1.Items.AddRange(new object[] {
            "Jimi",
            "Eddie",
            "Carlos",
            "Steve",
            "Jimmy",
            "Jeff",
            "Eric",
            "Billy"});
            this.testComboBox1.Location = new System.Drawing.Point(470, 12);
            this.testComboBox1.Name = "testComboBox1";
            this.testComboBox1.Size = new System.Drawing.Size(121, 21);
            this.testComboBox1.TabIndex = 5;
            // 
            // comboBoxLabel
            // 
            this.comboBoxLabel.AutoSize = true;
            this.comboBoxLabel.Location = new System.Drawing.Point(367, 19);
            this.comboBoxLabel.Name = "comboBoxLabel";
            this.comboBoxLabel.Size = new System.Drawing.Size(97, 13);
            this.comboBoxLabel.TabIndex = 6;
            this.comboBoxLabel.Text = "Combo Box Control";
            // 
            // testUIAutomationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 261);
            this.Controls.Add(this.comboBoxLabel);
            this.Controls.Add(this.testComboBox1);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.testDateTimePicker);
            this.Name = "testUIAutomationForm";
            this.Text = "Test UI Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker testDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textBoxLabel;
        private System.Windows.Forms.ComboBox testComboBox1;
        private System.Windows.Forms.Label comboBoxLabel;
    }
}

