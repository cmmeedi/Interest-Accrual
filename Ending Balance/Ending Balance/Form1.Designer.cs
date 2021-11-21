namespace Ending_Balance
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
            this.StartingBalanceLabel = new System.Windows.Forms.Label();
            this.NumberOfMonthsLabel = new System.Windows.Forms.Label();
            this.EndingBalanceLabel = new System.Windows.Forms.Label();
            this.EndingBalanceResults = new System.Windows.Forms.Label();
            this.NumberOfMonthsTextBox = new System.Windows.Forms.TextBox();
            this.StartingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DetailsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // StartingBalanceLabel
            // 
            this.StartingBalanceLabel.AutoSize = true;
            this.StartingBalanceLabel.Location = new System.Drawing.Point(28, 23);
            this.StartingBalanceLabel.Name = "StartingBalanceLabel";
            this.StartingBalanceLabel.Size = new System.Drawing.Size(85, 13);
            this.StartingBalanceLabel.TabIndex = 0;
            this.StartingBalanceLabel.Text = "Starting Balance";
            // 
            // NumberOfMonthsLabel
            // 
            this.NumberOfMonthsLabel.AutoSize = true;
            this.NumberOfMonthsLabel.Location = new System.Drawing.Point(28, 52);
            this.NumberOfMonthsLabel.Name = "NumberOfMonthsLabel";
            this.NumberOfMonthsLabel.Size = new System.Drawing.Size(94, 13);
            this.NumberOfMonthsLabel.TabIndex = 1;
            this.NumberOfMonthsLabel.Text = "Number of Months";
            // 
            // EndingBalanceLabel
            // 
            this.EndingBalanceLabel.AutoSize = true;
            this.EndingBalanceLabel.Location = new System.Drawing.Point(28, 215);
            this.EndingBalanceLabel.Name = "EndingBalanceLabel";
            this.EndingBalanceLabel.Size = new System.Drawing.Size(82, 13);
            this.EndingBalanceLabel.TabIndex = 2;
            this.EndingBalanceLabel.Text = "Ending Balance";
            // 
            // EndingBalanceResults
            // 
            this.EndingBalanceResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndingBalanceResults.Location = new System.Drawing.Point(153, 214);
            this.EndingBalanceResults.Name = "EndingBalanceResults";
            this.EndingBalanceResults.Size = new System.Drawing.Size(100, 20);
            this.EndingBalanceResults.TabIndex = 3;
            this.EndingBalanceResults.Click += new System.EventHandler(this.label1_Click);
            // 
            // NumberOfMonthsTextBox
            // 
            this.NumberOfMonthsTextBox.Location = new System.Drawing.Point(153, 49);
            this.NumberOfMonthsTextBox.Name = "NumberOfMonthsTextBox";
            this.NumberOfMonthsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfMonthsTextBox.TabIndex = 4;
            // 
            // StartingBalanceTextBox
            // 
            this.StartingBalanceTextBox.Location = new System.Drawing.Point(153, 20);
            this.StartingBalanceTextBox.Name = "StartingBalanceTextBox";
            this.StartingBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartingBalanceTextBox.TabIndex = 5;
            this.StartingBalanceTextBox.TextChanged += new System.EventHandler(this.StartingBalanceTextBox_TextChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(16, 249);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(110, 249);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(204, 249);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DetailsListBox
            // 
            this.DetailsListBox.FormattingEnabled = true;
            this.DetailsListBox.Location = new System.Drawing.Point(12, 75);
            this.DetailsListBox.Name = "DetailsListBox";
            this.DetailsListBox.Size = new System.Drawing.Size(282, 134);
            this.DetailsListBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 283);
            this.Controls.Add(this.DetailsListBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.StartingBalanceTextBox);
            this.Controls.Add(this.NumberOfMonthsTextBox);
            this.Controls.Add(this.EndingBalanceResults);
            this.Controls.Add(this.EndingBalanceLabel);
            this.Controls.Add(this.NumberOfMonthsLabel);
            this.Controls.Add(this.StartingBalanceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StartingBalanceLabel;
        private System.Windows.Forms.Label NumberOfMonthsLabel;
        private System.Windows.Forms.Label EndingBalanceLabel;
        private System.Windows.Forms.Label EndingBalanceResults;
        private System.Windows.Forms.TextBox NumberOfMonthsTextBox;
        private System.Windows.Forms.TextBox StartingBalanceTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.ListBox DetailsListBox;
    }
}

