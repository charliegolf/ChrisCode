namespace Rnum
{
    partial class convertForm
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
            this.romanInput = new System.Windows.Forms.TextBox();
            this.arabicOutput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // romanInput
            // 
            this.romanInput.Location = new System.Drawing.Point(87, 31);
            this.romanInput.Name = "romanInput";
            this.romanInput.Size = new System.Drawing.Size(100, 20);
            this.romanInput.TabIndex = 0;
             // 
            // arabicOutput
            // 
            this.arabicOutput.Location = new System.Drawing.Point(87, 204);
            this.arabicOutput.Name = "arabicOutput";
            this.arabicOutput.Size = new System.Drawing.Size(100, 20);
            this.arabicOutput.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(87, 102);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // convertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.arabicOutput);
            this.Controls.Add(this.romanInput);
            this.Name = "convertForm";
            this.Text = "ConvertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox romanInput;
        private System.Windows.Forms.TextBox arabicOutput;
        private System.Windows.Forms.Button convertButton;
    }
}