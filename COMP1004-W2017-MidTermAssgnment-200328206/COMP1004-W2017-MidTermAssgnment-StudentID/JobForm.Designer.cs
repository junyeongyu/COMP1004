namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    partial class JobForm
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
            this.NextButton = new System.Windows.Forms.Button();
            this.jobGroupBox = new System.Windows.Forms.GroupBox();
            this.cultiestRadioButton = new System.Windows.Forms.RadioButton();
            this.magickerRadioButton = new System.Windows.Forms.RadioButton();
            this.rogueRadioButton = new System.Windows.Forms.RadioButton();
            this.soldierRadioButton = new System.Windows.Forms.RadioButton();
            this.healthPointsTextLabel = new System.Windows.Forms.Label();
            this.healthPointsValueLabel = new System.Windows.Forms.Label();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.Controls.Add(this.cultiestRadioButton);
            this.jobGroupBox.Controls.Add(this.magickerRadioButton);
            this.jobGroupBox.Controls.Add(this.rogueRadioButton);
            this.jobGroupBox.Controls.Add(this.soldierRadioButton);
            this.jobGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobGroupBox.Location = new System.Drawing.Point(168, 78);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.Size = new System.Drawing.Size(292, 269);
            this.jobGroupBox.TabIndex = 4;
            this.jobGroupBox.TabStop = false;
            this.jobGroupBox.Text = "Job";
            // 
            // cultiestRadioButton
            // 
            this.cultiestRadioButton.AutoSize = true;
            this.cultiestRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cultiestRadioButton.Location = new System.Drawing.Point(44, 212);
            this.cultiestRadioButton.Name = "cultiestRadioButton";
            this.cultiestRadioButton.Size = new System.Drawing.Size(111, 33);
            this.cultiestRadioButton.TabIndex = 3;
            this.cultiestRadioButton.TabStop = true;
            this.cultiestRadioButton.Text = "Cultiest";
            this.cultiestRadioButton.UseVisualStyleBackColor = true;
            // 
            // magickerRadioButton
            // 
            this.magickerRadioButton.AutoSize = true;
            this.magickerRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magickerRadioButton.Location = new System.Drawing.Point(44, 158);
            this.magickerRadioButton.Name = "magickerRadioButton";
            this.magickerRadioButton.Size = new System.Drawing.Size(130, 33);
            this.magickerRadioButton.TabIndex = 2;
            this.magickerRadioButton.TabStop = true;
            this.magickerRadioButton.Text = "Magicker";
            this.magickerRadioButton.UseVisualStyleBackColor = true;
            // 
            // rogueRadioButton
            // 
            this.rogueRadioButton.AutoSize = true;
            this.rogueRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rogueRadioButton.Location = new System.Drawing.Point(44, 98);
            this.rogueRadioButton.Name = "rogueRadioButton";
            this.rogueRadioButton.Size = new System.Drawing.Size(103, 33);
            this.rogueRadioButton.TabIndex = 1;
            this.rogueRadioButton.TabStop = true;
            this.rogueRadioButton.Text = "Rogue";
            this.rogueRadioButton.UseVisualStyleBackColor = true;
            // 
            // soldierRadioButton
            // 
            this.soldierRadioButton.AutoSize = true;
            this.soldierRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldierRadioButton.Location = new System.Drawing.Point(44, 38);
            this.soldierRadioButton.Name = "soldierRadioButton";
            this.soldierRadioButton.Size = new System.Drawing.Size(109, 33);
            this.soldierRadioButton.TabIndex = 0;
            this.soldierRadioButton.TabStop = true;
            this.soldierRadioButton.Text = "Soldier";
            this.soldierRadioButton.UseVisualStyleBackColor = true;
            // 
            // healthPointsTextLabel
            // 
            this.healthPointsTextLabel.AutoSize = true;
            this.healthPointsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPointsTextLabel.Location = new System.Drawing.Point(163, 376);
            this.healthPointsTextLabel.Name = "healthPointsTextLabel";
            this.healthPointsTextLabel.Size = new System.Drawing.Size(173, 29);
            this.healthPointsTextLabel.TabIndex = 5;
            this.healthPointsTextLabel.Text = "Health Points : ";
            // 
            // healthPointsValueLabel
            // 
            this.healthPointsValueLabel.AutoSize = true;
            this.healthPointsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthPointsValueLabel.Location = new System.Drawing.Point(342, 376);
            this.healthPointsValueLabel.Name = "healthPointsValueLabel";
            this.healthPointsValueLabel.Size = new System.Drawing.Size(21, 29);
            this.healthPointsValueLabel.TabIndex = 6;
            this.healthPointsValueLabel.Text = "-";
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.healthPointsValueLabel);
            this.Controls.Add(this.healthPointsTextLabel);
            this.Controls.Add(this.jobGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox jobGroupBox;
        private System.Windows.Forms.RadioButton cultiestRadioButton;
        private System.Windows.Forms.RadioButton magickerRadioButton;
        private System.Windows.Forms.RadioButton rogueRadioButton;
        private System.Windows.Forms.RadioButton soldierRadioButton;
        private System.Windows.Forms.Label healthPointsTextLabel;
        private System.Windows.Forms.Label healthPointsValueLabel;
    }
}