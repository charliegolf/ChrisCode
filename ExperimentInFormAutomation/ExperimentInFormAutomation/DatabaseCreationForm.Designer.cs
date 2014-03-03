namespace ExperimentInFormAutomation
{
    partial class DatabaseCreationForm
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
            this.serverSelectListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.databaseCreateButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.enterDatabaseLabel = new System.Windows.Forms.Label();
            this.databaseLabel2 = new System.Windows.Forms.Label();
            this.createLabel = new System.Windows.Forms.Label();
            this.createLabel2 = new System.Windows.Forms.Label();
            this.testLabel1 = new System.Windows.Forms.Label();
            this.testLabel2 = new System.Windows.Forms.Label();
            this.testButton = new System.Windows.Forms.Button();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // serverSelectListBox
            // 
            this.serverSelectListBox.FormattingEnabled = true;
            this.serverSelectListBox.Location = new System.Drawing.Point(129, 16);
            this.serverSelectListBox.Name = "serverSelectListBox";
            this.serverSelectListBox.Size = new System.Drawing.Size(120, 95);
            this.serverSelectListBox.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 1;
            // 
            // databaseCreateButton
            // 
            this.databaseCreateButton.Location = new System.Drawing.Point(174, 155);
            this.databaseCreateButton.Name = "databaseCreateButton";
            this.databaseCreateButton.Size = new System.Drawing.Size(75, 23);
            this.databaseCreateButton.TabIndex = 2;
            this.databaseCreateButton.Text = "Create Database";
            this.databaseCreateButton.UseVisualStyleBackColor = true;
            this.databaseCreateButton.Click += new System.EventHandler(this.databaseCreateButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Location = new System.Drawing.Point(9, 16);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(111, 13);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Please select a server";
            // 
            // enterDatabaseLabel
            // 
            this.enterDatabaseLabel.AutoSize = true;
            this.enterDatabaseLabel.Location = new System.Drawing.Point(9, 120);
            this.enterDatabaseLabel.Name = "enterDatabaseLabel";
            this.enterDatabaseLabel.Size = new System.Drawing.Size(88, 13);
            this.enterDatabaseLabel.TabIndex = 4;
            this.enterDatabaseLabel.Text = "Enter a name for ";
            // 
            // databaseLabel2
            // 
            this.databaseLabel2.AutoSize = true;
            this.databaseLabel2.Location = new System.Drawing.Point(11, 133);
            this.databaseLabel2.Name = "databaseLabel2";
            this.databaseLabel2.Size = new System.Drawing.Size(74, 13);
            this.databaseLabel2.TabIndex = 5;
            this.databaseLabel2.Text = "your database";
            // 
            // createLabel
            // 
            this.createLabel.AutoSize = true;
            this.createLabel.Location = new System.Drawing.Point(12, 165);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(129, 13);
            this.createLabel.TabIndex = 6;
            this.createLabel.Text = "Click the button to create ";
            // 
            // createLabel2
            // 
            this.createLabel2.AutoSize = true;
            this.createLabel2.Location = new System.Drawing.Point(15, 178);
            this.createLabel2.Name = "createLabel2";
            this.createLabel2.Size = new System.Drawing.Size(77, 13);
            this.createLabel2.TabIndex = 7;
            this.createLabel2.Text = "your database ";
            // 
            // testLabel1
            // 
            this.testLabel1.AutoSize = true;
            this.testLabel1.Location = new System.Drawing.Point(296, 79);
            this.testLabel1.Name = "testLabel1";
            this.testLabel1.Size = new System.Drawing.Size(129, 13);
            this.testLabel1.TabIndex = 8;
            this.testLabel1.Text = "Click the button to create ";
            // 
            // testLabel2
            // 
            this.testLabel2.AutoSize = true;
            this.testLabel2.Location = new System.Drawing.Point(296, 92);
            this.testLabel2.Name = "testLabel2";
            this.testLabel2.Size = new System.Drawing.Size(70, 13);
            this.testLabel2.TabIndex = 9;
            this.testLabel2.Text = "run your tests";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(458, 74);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 10;
            this.testButton.Text = "Test ";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(296, 16);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(106, 13);
            this.inputLabel1.TabIndex = 11;
            this.inputLabel1.Text = "Select you test input ";
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(433, 13);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTextBox.TabIndex = 12;
            // 
            // DatabaseCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.inputLabel1);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testLabel2);
            this.Controls.Add(this.testLabel1);
            this.Controls.Add(this.createLabel2);
            this.Controls.Add(this.createLabel);
            this.Controls.Add(this.databaseLabel2);
            this.Controls.Add(this.enterDatabaseLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.databaseCreateButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.serverSelectListBox);
            this.Name = "DatabaseCreationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DatabaseCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox serverSelectListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button databaseCreateButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label enterDatabaseLabel;
        private System.Windows.Forms.Label databaseLabel2;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Label createLabel2;
        private System.Windows.Forms.Label testLabel1;
        private System.Windows.Forms.Label testLabel2;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.TextBox inputTextBox;
    }
}

