namespace Assignment4
{
    partial class SelectForm
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
            this.dollorComputerLabel = new System.Windows.Forms.Label();
            this.yourSelectionLabel = new System.Windows.Forms.Label();
            this.dollorComputerDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dollorComputerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dollorComputerLabel
            // 
            this.dollorComputerLabel.AutoSize = true;
            this.dollorComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dollorComputerLabel.Location = new System.Drawing.Point(13, 10);
            this.dollorComputerLabel.Name = "dollorComputerLabel";
            this.dollorComputerLabel.Size = new System.Drawing.Size(213, 18);
            this.dollorComputerLabel.TabIndex = 0;
            this.dollorComputerLabel.Text = "Dollor Computer Hardware List";
            // 
            // yourSelectionLabel
            // 
            this.yourSelectionLabel.AutoSize = true;
            this.yourSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourSelectionLabel.Location = new System.Drawing.Point(13, 326);
            this.yourSelectionLabel.Name = "yourSelectionLabel";
            this.yourSelectionLabel.Size = new System.Drawing.Size(104, 18);
            this.yourSelectionLabel.TabIndex = 1;
            this.yourSelectionLabel.Text = "Your Selection";
            // 
            // dollorComputerDataGridView
            // 
            this.dollorComputerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dollorComputerDataGridView.Location = new System.Drawing.Point(16, 34);
            this.dollorComputerDataGridView.Name = "dollorComputerDataGridView";
            this.dollorComputerDataGridView.Size = new System.Drawing.Size(567, 277);
            this.dollorComputerDataGridView.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 327);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 3;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(415, 325);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(508, 324);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dollorComputerDataGridView);
            this.Controls.Add(this.yourSelectionLabel);
            this.Controls.Add(this.dollorComputerLabel);
            this.Name = "SelectForm";
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.dollorComputerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dollorComputerLabel;
        private System.Windows.Forms.Label yourSelectionLabel;
        private System.Windows.Forms.DataGridView dollorComputerDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
    }
}