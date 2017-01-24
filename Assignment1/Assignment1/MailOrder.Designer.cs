namespace Assignment1
{
    partial class MailOrder
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            this.totalHoursWorkedLabel = new System.Windows.Forms.Label();
            this.totalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.salesBonusLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.frenchRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.spanishRadioButton = new System.Windows.Forms.RadioButton();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.totalHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.totalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.salesBonusTextBox = new System.Windows.Forms.TextBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.languageGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.languageGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(21, 132);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(100, 13);
            this.employeeNameLabel.TabIndex = 1;
            this.employeeNameLabel.Text = "Employee\'s Name : ";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(21, 163);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(76, 13);
            this.employeeIdLabel.TabIndex = 2;
            this.employeeIdLabel.Text = "Employee ID : ";
            // 
            // totalHoursWorkedLabel
            // 
            this.totalHoursWorkedLabel.AutoSize = true;
            this.totalHoursWorkedLabel.Location = new System.Drawing.Point(21, 210);
            this.totalHoursWorkedLabel.Name = "totalHoursWorkedLabel";
            this.totalHoursWorkedLabel.Size = new System.Drawing.Size(112, 13);
            this.totalHoursWorkedLabel.TabIndex = 3;
            this.totalHoursWorkedLabel.Text = "Total Hours Worked : ";
            // 
            // totalMonthlySalesLabel
            // 
            this.totalMonthlySalesLabel.AutoSize = true;
            this.totalMonthlySalesLabel.Location = new System.Drawing.Point(21, 241);
            this.totalMonthlySalesLabel.Name = "totalMonthlySalesLabel";
            this.totalMonthlySalesLabel.Size = new System.Drawing.Size(109, 13);
            this.totalMonthlySalesLabel.TabIndex = 4;
            this.totalMonthlySalesLabel.Text = "Total Monthly Sales : ";
            // 
            // salesBonusLabel
            // 
            this.salesBonusLabel.AutoSize = true;
            this.salesBonusLabel.Location = new System.Drawing.Point(21, 274);
            this.salesBonusLabel.Name = "salesBonusLabel";
            this.salesBonusLabel.Size = new System.Drawing.Size(75, 13);
            this.salesBonusLabel.TabIndex = 5;
            this.salesBonusLabel.Text = "Sales Bonus : ";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(24, 308);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.TabStop = false;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(273, 308);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 0;
            this.printButton.TabStop = false;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(153, 308);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 0;
            this.nextButton.TabStop = false;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Checked = true;
            this.englishRadioButton.Location = new System.Drawing.Point(18, 26);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.englishRadioButton.TabIndex = 0;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            this.englishRadioButton.CheckedChanged += new System.EventHandler(this.englishRadioButton_CheckedChanged);
            // 
            // frenchRadioButton
            // 
            this.frenchRadioButton.AutoSize = true;
            this.frenchRadioButton.Location = new System.Drawing.Point(18, 48);
            this.frenchRadioButton.Name = "frenchRadioButton";
            this.frenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.frenchRadioButton.TabIndex = 0;
            this.frenchRadioButton.Text = "Français";
            this.frenchRadioButton.UseVisualStyleBackColor = true;
            this.frenchRadioButton.CheckedChanged += new System.EventHandler(this.frenchRadioButton_CheckedChanged);
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(185, 129);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(162, 20);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // spanishRadioButton
            // 
            this.spanishRadioButton.AutoSize = true;
            this.spanishRadioButton.Location = new System.Drawing.Point(18, 70);
            this.spanishRadioButton.Name = "spanishRadioButton";
            this.spanishRadioButton.Size = new System.Drawing.Size(63, 17);
            this.spanishRadioButton.TabIndex = 0;
            this.spanishRadioButton.Text = "Español";
            this.spanishRadioButton.UseVisualStyleBackColor = true;
            this.spanishRadioButton.CheckedChanged += new System.EventHandler(this.spanishRadioButton_CheckedChanged);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(185, 160);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(162, 20);
            this.employeeIdTextBox.TabIndex = 2;
            // 
            // totalHoursWorkedTextBox
            // 
            this.totalHoursWorkedTextBox.Location = new System.Drawing.Point(185, 207);
            this.totalHoursWorkedTextBox.Name = "totalHoursWorkedTextBox";
            this.totalHoursWorkedTextBox.Size = new System.Drawing.Size(162, 20);
            this.totalHoursWorkedTextBox.TabIndex = 3;
            this.totalHoursWorkedTextBox.TextChanged += new System.EventHandler(this.totalHoursWorkedTextBox_TextChanged);
            // 
            // totalMonthlySalesTextBox
            // 
            this.totalMonthlySalesTextBox.Location = new System.Drawing.Point(185, 238);
            this.totalMonthlySalesTextBox.Name = "totalMonthlySalesTextBox";
            this.totalMonthlySalesTextBox.Size = new System.Drawing.Size(162, 20);
            this.totalMonthlySalesTextBox.TabIndex = 4;
            this.totalMonthlySalesTextBox.Enter += new System.EventHandler(this.totalMonthlySalesTextBox_Enter);
            this.totalMonthlySalesTextBox.Leave += new System.EventHandler(this.totalMonthlySalesTextBox_Leave);
            // 
            // salesBonusTextBox
            // 
            this.salesBonusTextBox.Location = new System.Drawing.Point(185, 271);
            this.salesBonusTextBox.Name = "salesBonusTextBox";
            this.salesBonusTextBox.ReadOnly = true;
            this.salesBonusTextBox.Size = new System.Drawing.Size(162, 20);
            this.salesBonusTextBox.TabIndex = 0;
            this.salesBonusTextBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoPictureBox.Enabled = false;
            this.logoPictureBox.Image = global::Assignment1.Properties.Resources.Love;
            this.logoPictureBox.Location = new System.Drawing.Point(22, 13);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(90, 90);
            this.logoPictureBox.TabIndex = 9;
            this.logoPictureBox.TabStop = false;
            // 
            // languageGroupBox
            // 
            this.languageGroupBox.Controls.Add(this.englishRadioButton);
            this.languageGroupBox.Controls.Add(this.frenchRadioButton);
            this.languageGroupBox.Controls.Add(this.spanishRadioButton);
            this.languageGroupBox.Location = new System.Drawing.Point(185, 13);
            this.languageGroupBox.Name = "languageGroupBox";
            this.languageGroupBox.Size = new System.Drawing.Size(163, 100);
            this.languageGroupBox.TabIndex = 0;
            this.languageGroupBox.TabStop = false;
            this.languageGroupBox.Text = "Languages";
            // 
            // MailOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 346);
            this.Controls.Add(this.languageGroupBox);
            this.Controls.Add(this.salesBonusTextBox);
            this.Controls.Add(this.totalMonthlySalesTextBox);
            this.Controls.Add(this.totalHoursWorkedTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.salesBonusLabel);
            this.Controls.Add(this.totalMonthlySalesLabel);
            this.Controls.Add(this.totalHoursWorkedLabel);
            this.Controls.Add(this.employeeIdLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 384);
            this.MinimumSize = new System.Drawing.Size(396, 384);
            this.Name = "MailOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            this.Load += new System.EventHandler(this.MailOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.languageGroupBox.ResumeLayout(false);
            this.languageGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label employeeIdLabel;
        private System.Windows.Forms.Label totalHoursWorkedLabel;
        private System.Windows.Forms.Label totalMonthlySalesLabel;
        private System.Windows.Forms.Label salesBonusLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.RadioButton frenchRadioButton;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.RadioButton spanishRadioButton;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox totalHoursWorkedTextBox;
        private System.Windows.Forms.TextBox totalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox salesBonusTextBox;
        private System.Windows.Forms.GroupBox languageGroupBox;
    }
}

