namespace Assignment3
{
    partial class SelectionForm
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
            this.yourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.chooseTheMovieLabel = new System.Windows.Forms.Label();
            this.currentMoviesListBox = new System.Windows.Forms.ListBox();
            this.currentMoviesLabel = new System.Windows.Forms.Label();
            this.yourSelectionPictureBox = new System.Windows.Forms.PictureBox();
            this.yourSelectionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourSelectionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // yourSelectionGroupBox
            // 
            this.yourSelectionGroupBox.Controls.Add(this.costTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.categoryTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.titleTextBox);
            this.yourSelectionGroupBox.Controls.Add(this.costLabel);
            this.yourSelectionGroupBox.Controls.Add(this.categoryLabel);
            this.yourSelectionGroupBox.Controls.Add(this.titleLabel);
            this.yourSelectionGroupBox.Controls.Add(this.yourSelectionPictureBox);
            this.yourSelectionGroupBox.Location = new System.Drawing.Point(149, 60);
            this.yourSelectionGroupBox.Name = "yourSelectionGroupBox";
            this.yourSelectionGroupBox.Size = new System.Drawing.Size(404, 156);
            this.yourSelectionGroupBox.TabIndex = 0;
            this.yourSelectionGroupBox.TabStop = false;
            this.yourSelectionGroupBox.Text = "Your Selection";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(321, 95);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(77, 20);
            this.costTextBox.TabIndex = 6;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(136, 95);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(179, 20);
            this.categoryTextBox.TabIndex = 5;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(136, 36);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(262, 20);
            this.titleTextBox.TabIndex = 4;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(337, 75);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(146, 75);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Category";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(146, 16);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // nextButton
            // 
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(458, 275);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(95, 30);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // chooseTheMovieLabel
            // 
            this.chooseTheMovieLabel.AutoSize = true;
            this.chooseTheMovieLabel.Location = new System.Drawing.Point(18, 13);
            this.chooseTheMovieLabel.Name = "chooseTheMovieLabel";
            this.chooseTheMovieLabel.Size = new System.Drawing.Size(283, 13);
            this.chooseTheMovieLabel.TabIndex = 2;
            this.chooseTheMovieLabel.Text = "Choose the movie you wish to STREAM from the list below";
            // 
            // currentMoviesListBox
            // 
            this.currentMoviesListBox.FormattingEnabled = true;
            this.currentMoviesListBox.Location = new System.Drawing.Point(21, 60);
            this.currentMoviesListBox.Name = "currentMoviesListBox";
            this.currentMoviesListBox.Size = new System.Drawing.Size(111, 238);
            this.currentMoviesListBox.Sorted = true;
            this.currentMoviesListBox.TabIndex = 3;
            this.currentMoviesListBox.SelectedIndexChanged += new System.EventHandler(this.currentMoviesListBox_SelectedIndexChanged);
            // 
            // currentMoviesLabel
            // 
            this.currentMoviesLabel.AutoSize = true;
            this.currentMoviesLabel.Location = new System.Drawing.Point(27, 43);
            this.currentMoviesLabel.Name = "currentMoviesLabel";
            this.currentMoviesLabel.Size = new System.Drawing.Size(78, 13);
            this.currentMoviesLabel.TabIndex = 4;
            this.currentMoviesLabel.Text = "Current Movies";
            // 
            // yourSelectionPictureBox
            // 
            this.yourSelectionPictureBox.Image = global::Assignment3.Properties.Resources.No_Image;
            this.yourSelectionPictureBox.Location = new System.Drawing.Point(15, 19);
            this.yourSelectionPictureBox.Name = "yourSelectionPictureBox";
            this.yourSelectionPictureBox.Size = new System.Drawing.Size(104, 124);
            this.yourSelectionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yourSelectionPictureBox.TabIndex = 0;
            this.yourSelectionPictureBox.TabStop = false;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 317);
            this.ControlBox = false;
            this.Controls.Add(this.currentMoviesLabel);
            this.Controls.Add(this.currentMoviesListBox);
            this.Controls.Add(this.chooseTheMovieLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.yourSelectionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movie Bonanza - Your Online Streaming Service";
            this.Load += new System.EventHandler(this.SelectionForm_Load);
            this.yourSelectionGroupBox.ResumeLayout(false);
            this.yourSelectionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yourSelectionPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox yourSelectionGroupBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox yourSelectionPictureBox;
        private System.Windows.Forms.Label chooseTheMovieLabel;
        private System.Windows.Forms.ListBox currentMoviesListBox;
        private System.Windows.Forms.Label currentMoviesLabel;
    }
}

