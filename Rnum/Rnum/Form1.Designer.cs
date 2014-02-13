namespace Rnum
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
            this.input = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.Roman = new System.Windows.Forms.Label();
            this.Arabic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(118, 49);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 0;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(118, 101);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(118, 171);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(100, 20);
            this.output.TabIndex = 3;
            // 
            // Roman
            // 
            this.Roman.AutoSize = true;
            this.Roman.Location = new System.Drawing.Point(13, 49);
            this.Roman.Name = "Roman";
            this.Roman.Size = new System.Drawing.Size(83, 13);
            this.Roman.TabIndex = 4;
            this.Roman.Text = "Roman Numeral";
            // 
            // Arabic
            // 
            this.Arabic.AutoSize = true;
            this.Arabic.Location = new System.Drawing.Point(16, 171);
            this.Arabic.Name = "Arabic";
            this.Arabic.Size = new System.Drawing.Size(77, 13);
            this.Arabic.TabIndex = 5;
            this.Arabic.Text = "Arabic Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Rnum.Properties.Resources.Untitled;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Arabic);
            this.Controls.Add(this.Roman);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label Roman;
        private System.Windows.Forms.Label Arabic;

        
    }
}

