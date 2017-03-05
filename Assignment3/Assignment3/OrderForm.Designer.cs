namespace Assignment3
{
    partial class OrderForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieSelectedGroupBox = new System.Windows.Forms.GroupBox();
            this.movieSelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.yourOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.additionalChargeCheckBox = new System.Windows.Forms.CheckBox();
            this.yourOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.costLabel = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.salesTaxLabel = new System.Windows.Forms.Label();
            this.grandTotalLabel = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.salesTaxTextBox = new System.Windows.Forms.TextBox();
            this.grandTotalTextBox = new System.Windows.Forms.TextBox();
            this.dividerLabel = new System.Windows.Forms.Label();
            this.additionalChargeLabel = new System.Windows.Forms.Label();
            this.additionalChargeTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.streamButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.movieSelectedGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieSelectedPictureBox)).BeginInit();
            this.yourOrderGroupBox.SuspendLayout();
            this.yourOrderTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(531, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.streamToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // streamToolStripMenuItem
            // 
            this.streamToolStripMenuItem.Name = "streamToolStripMenuItem";
            this.streamToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.streamToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.streamToolStripMenuItem.Text = "Strea&m";
            this.streamToolStripMenuItem.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelToolStripMenuItem.Text = "Canc&el";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // movieSelectedGroupBox
            // 
            this.movieSelectedGroupBox.Controls.Add(this.movieSelectedPictureBox);
            this.movieSelectedGroupBox.Controls.Add(this.categoryTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.titleTextBox);
            this.movieSelectedGroupBox.Controls.Add(this.categoryLabel);
            this.movieSelectedGroupBox.Controls.Add(this.titleLabel);
            this.movieSelectedGroupBox.Location = new System.Drawing.Point(12, 36);
            this.movieSelectedGroupBox.Name = "movieSelectedGroupBox";
            this.movieSelectedGroupBox.Size = new System.Drawing.Size(179, 315);
            this.movieSelectedGroupBox.TabIndex = 1;
            this.movieSelectedGroupBox.TabStop = false;
            this.movieSelectedGroupBox.Text = "Movie Selected";
            // 
            // movieSelectedPictureBox
            // 
            this.movieSelectedPictureBox.Location = new System.Drawing.Point(10, 112);
            this.movieSelectedPictureBox.Name = "movieSelectedPictureBox";
            this.movieSelectedPictureBox.Size = new System.Drawing.Size(163, 186);
            this.movieSelectedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.movieSelectedPictureBox.TabIndex = 4;
            this.movieSelectedPictureBox.TabStop = false;
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(10, 85);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.ReadOnly = true;
            this.categoryTextBox.Size = new System.Drawing.Size(163, 20);
            this.categoryTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(10, 36);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.ReadOnly = true;
            this.titleTextBox.Size = new System.Drawing.Size(163, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(7, 68);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(7, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(27, 13);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Title";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(207, 328);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // yourOrderGroupBox
            // 
            this.yourOrderGroupBox.Controls.Add(this.additionalChargeCheckBox);
            this.yourOrderGroupBox.Controls.Add(this.yourOrderTableLayoutPanel);
            this.yourOrderGroupBox.Location = new System.Drawing.Point(207, 36);
            this.yourOrderGroupBox.Name = "yourOrderGroupBox";
            this.yourOrderGroupBox.Size = new System.Drawing.Size(312, 268);
            this.yourOrderGroupBox.TabIndex = 3;
            this.yourOrderGroupBox.TabStop = false;
            this.yourOrderGroupBox.Text = "Your Order";
            // 
            // additionalChargeCheckBox
            // 
            this.additionalChargeCheckBox.AutoSize = true;
            this.additionalChargeCheckBox.Location = new System.Drawing.Point(7, 237);
            this.additionalChargeCheckBox.Name = "additionalChargeCheckBox";
            this.additionalChargeCheckBox.Size = new System.Drawing.Size(226, 17);
            this.additionalChargeCheckBox.TabIndex = 1;
            this.additionalChargeCheckBox.Text = "Order the DVD (adds $10.00 to your order)";
            this.additionalChargeCheckBox.UseVisualStyleBackColor = true;
            this.additionalChargeCheckBox.CheckedChanged += new System.EventHandler(this.additionalChargeCheckBox_CheckedChanged);
            // 
            // yourOrderTableLayoutPanel
            // 
            this.yourOrderTableLayoutPanel.ColumnCount = 2;
            this.yourOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.07018F));
            this.yourOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.92982F));
            this.yourOrderTableLayoutPanel.Controls.Add(this.costLabel, 0, 0);
            this.yourOrderTableLayoutPanel.Controls.Add(this.subTotalLabel, 0, 2);
            this.yourOrderTableLayoutPanel.Controls.Add(this.salesTaxLabel, 0, 4);
            this.yourOrderTableLayoutPanel.Controls.Add(this.grandTotalLabel, 0, 5);
            this.yourOrderTableLayoutPanel.Controls.Add(this.costTextBox, 1, 0);
            this.yourOrderTableLayoutPanel.Controls.Add(this.subTotalTextBox, 1, 2);
            this.yourOrderTableLayoutPanel.Controls.Add(this.salesTaxTextBox, 1, 4);
            this.yourOrderTableLayoutPanel.Controls.Add(this.grandTotalTextBox, 1, 5);
            this.yourOrderTableLayoutPanel.Controls.Add(this.dividerLabel, 1, 3);
            this.yourOrderTableLayoutPanel.Controls.Add(this.additionalChargeLabel, 0, 1);
            this.yourOrderTableLayoutPanel.Controls.Add(this.additionalChargeTextBox, 1, 1);
            this.yourOrderTableLayoutPanel.Location = new System.Drawing.Point(38, 28);
            this.yourOrderTableLayoutPanel.Name = "yourOrderTableLayoutPanel";
            this.yourOrderTableLayoutPanel.RowCount = 6;
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.yourOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.yourOrderTableLayoutPanel.Size = new System.Drawing.Size(229, 194);
            this.yourOrderTableLayoutPanel.TabIndex = 0;
            // 
            // costLabel
            // 
            this.costLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(90, 11);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 0;
            this.costLabel.Text = "Cost";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.subTotalLabel.AutoSize = true;
            this.subTotalLabel.Location = new System.Drawing.Point(65, 83);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(53, 13);
            this.subTotalLabel.TabIndex = 1;
            this.subTotalLabel.Text = "Sub Total";
            // 
            // salesTaxLabel
            // 
            this.salesTaxLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.salesTaxLabel.AutoSize = true;
            this.salesTaxLabel.Location = new System.Drawing.Point(35, 129);
            this.salesTaxLabel.Name = "salesTaxLabel";
            this.salesTaxLabel.Size = new System.Drawing.Size(83, 13);
            this.salesTaxLabel.TabIndex = 2;
            this.salesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // grandTotalLabel
            // 
            this.grandTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grandTotalLabel.AutoSize = true;
            this.grandTotalLabel.Location = new System.Drawing.Point(55, 167);
            this.grandTotalLabel.Name = "grandTotalLabel";
            this.grandTotalLabel.Size = new System.Drawing.Size(63, 13);
            this.grandTotalLabel.TabIndex = 3;
            this.grandTotalLabel.Text = "Grand Total";
            // 
            // costTextBox
            // 
            this.costTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.costTextBox.Location = new System.Drawing.Point(124, 8);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.ReadOnly = true;
            this.costTextBox.Size = new System.Drawing.Size(84, 20);
            this.costTextBox.TabIndex = 4;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.subTotalTextBox.Location = new System.Drawing.Point(124, 80);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(84, 20);
            this.subTotalTextBox.TabIndex = 5;
            // 
            // salesTaxTextBox
            // 
            this.salesTaxTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.salesTaxTextBox.Location = new System.Drawing.Point(124, 126);
            this.salesTaxTextBox.Name = "salesTaxTextBox";
            this.salesTaxTextBox.ReadOnly = true;
            this.salesTaxTextBox.Size = new System.Drawing.Size(84, 20);
            this.salesTaxTextBox.TabIndex = 6;
            // 
            // grandTotalTextBox
            // 
            this.grandTotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.grandTotalTextBox.Location = new System.Drawing.Point(124, 164);
            this.grandTotalTextBox.Name = "grandTotalTextBox";
            this.grandTotalTextBox.ReadOnly = true;
            this.grandTotalTextBox.Size = new System.Drawing.Size(84, 20);
            this.grandTotalTextBox.TabIndex = 7;
            // 
            // dividerLabel
            // 
            this.dividerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dividerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dividerLabel.Location = new System.Drawing.Point(124, 112);
            this.dividerLabel.Name = "dividerLabel";
            this.dividerLabel.Size = new System.Drawing.Size(84, 2);
            this.dividerLabel.TabIndex = 8;
            // 
            // additionalChargeLabel
            // 
            this.additionalChargeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.additionalChargeLabel.AutoSize = true;
            this.additionalChargeLabel.Location = new System.Drawing.Point(28, 47);
            this.additionalChargeLabel.Name = "additionalChargeLabel";
            this.additionalChargeLabel.Size = new System.Drawing.Size(90, 13);
            this.additionalChargeLabel.TabIndex = 9;
            this.additionalChargeLabel.Text = "Additional Charge";
            this.additionalChargeLabel.Visible = false;
            // 
            // additionalChargeTextBox
            // 
            this.additionalChargeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.additionalChargeTextBox.Location = new System.Drawing.Point(124, 44);
            this.additionalChargeTextBox.Name = "additionalChargeTextBox";
            this.additionalChargeTextBox.ReadOnly = true;
            this.additionalChargeTextBox.Size = new System.Drawing.Size(84, 20);
            this.additionalChargeTextBox.TabIndex = 10;
            this.additionalChargeTextBox.Text = "10";
            this.additionalChargeTextBox.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(349, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // streamButton
            // 
            this.streamButton.Location = new System.Drawing.Point(444, 328);
            this.streamButton.Name = "streamButton";
            this.streamButton.Size = new System.Drawing.Size(75, 23);
            this.streamButton.TabIndex = 5;
            this.streamButton.Text = "Stream";
            this.streamButton.UseVisualStyleBackColor = true;
            this.streamButton.Click += new System.EventHandler(this.streamButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 366);
            this.ControlBox = false;
            this.Controls.Add(this.streamButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.yourOrderGroupBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.movieSelectedGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 404);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 404);
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Order";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.movieSelectedGroupBox.ResumeLayout(false);
            this.movieSelectedGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieSelectedPictureBox)).EndInit();
            this.yourOrderGroupBox.ResumeLayout(false);
            this.yourOrderGroupBox.PerformLayout();
            this.yourOrderTableLayoutPanel.ResumeLayout(false);
            this.yourOrderTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox movieSelectedGroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.GroupBox yourOrderGroupBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button streamButton;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox additionalChargeCheckBox;
        private System.Windows.Forms.TableLayoutPanel yourOrderTableLayoutPanel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label salesTaxLabel;
        private System.Windows.Forms.Label grandTotalLabel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox salesTaxTextBox;
        private System.Windows.Forms.TextBox grandTotalTextBox;
        private System.Windows.Forms.PictureBox movieSelectedPictureBox;
        private System.Windows.Forms.Label dividerLabel;
        private System.Windows.Forms.Label additionalChargeLabel;
        private System.Windows.Forms.TextBox additionalChargeTextBox;
    }
}