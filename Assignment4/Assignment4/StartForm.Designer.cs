namespace Assignment4
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.orderYourComputerLabel = new System.Windows.Forms.Label();
            this.startNewOrderButton = new System.Windows.Forms.Button();
            this.openSavedOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.orderYourPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderYourPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // orderYourComputerLabel
            // 
            this.orderYourComputerLabel.AutoSize = true;
            this.orderYourComputerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderYourComputerLabel.Location = new System.Drawing.Point(34, 28);
            this.orderYourComputerLabel.Name = "orderYourComputerLabel";
            this.orderYourComputerLabel.Size = new System.Drawing.Size(199, 18);
            this.orderYourComputerLabel.TabIndex = 0;
            this.orderYourComputerLabel.Text = "Order Your Computer Today!";
            // 
            // startNewOrderButton
            // 
            this.startNewOrderButton.Location = new System.Drawing.Point(66, 190);
            this.startNewOrderButton.Name = "startNewOrderButton";
            this.startNewOrderButton.Size = new System.Drawing.Size(128, 26);
            this.startNewOrderButton.TabIndex = 2;
            this.startNewOrderButton.Text = "Start a New Order";
            this.startNewOrderButton.UseVisualStyleBackColor = true;
            this.startNewOrderButton.Click += new System.EventHandler(this.startNewOrderButton_Click);
            // 
            // openSavedOrderButton
            // 
            this.openSavedOrderButton.Location = new System.Drawing.Point(66, 222);
            this.openSavedOrderButton.Name = "openSavedOrderButton";
            this.openSavedOrderButton.Size = new System.Drawing.Size(128, 26);
            this.openSavedOrderButton.TabIndex = 3;
            this.openSavedOrderButton.Text = "Open a Saved Order";
            this.openSavedOrderButton.UseVisualStyleBackColor = true;
            this.openSavedOrderButton.Click += new System.EventHandler(this.openSavedOrderButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(66, 254);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(128, 26);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orderYourPictureBox
            // 
            this.orderYourPictureBox.Image = global::Assignment4.Properties.Resources.coin;
            this.orderYourPictureBox.Location = new System.Drawing.Point(66, 60);
            this.orderYourPictureBox.Name = "orderYourPictureBox";
            this.orderYourPictureBox.Size = new System.Drawing.Size(128, 106);
            this.orderYourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orderYourPictureBox.TabIndex = 1;
            this.orderYourPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 292);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.openSavedOrderButton);
            this.Controls.Add(this.startNewOrderButton);
            this.Controls.Add(this.orderYourPictureBox);
            this.Controls.Add(this.orderYourComputerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollor Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.orderYourPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderYourComputerLabel;
        private System.Windows.Forms.PictureBox orderYourPictureBox;
        private System.Windows.Forms.Button startNewOrderButton;
        public System.Windows.Forms.Button openSavedOrderButton;
        private System.Windows.Forms.Button exitButton;
    }
}

