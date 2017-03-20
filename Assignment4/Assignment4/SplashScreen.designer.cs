namespace Assignment4
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.splashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.welcomePictureBox = new System.Windows.Forms.PictureBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.InfoText;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.welcomeLabel.Location = new System.Drawing.Point(137, 29);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(307, 42);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Dollor Computers";
            // 
            // splashFormTimer
            // 
            this.splashFormTimer.Enabled = true;
            this.splashFormTimer.Interval = 3000;
            this.splashFormTimer.Tick += new System.EventHandler(this.splashFormTimer_Tick);
            // 
            // welcomePictureBox
            // 
            this.welcomePictureBox.Image = global::Assignment4.Properties.Resources.dollor_computers_logo;
            this.welcomePictureBox.Location = new System.Drawing.Point(12, 99);
            this.welcomePictureBox.Name = "welcomePictureBox";
            this.welcomePictureBox.Size = new System.Drawing.Size(557, 355);
            this.welcomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomePictureBox.TabIndex = 1;
            this.welcomePictureBox.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(581, 466);
            this.Controls.Add(this.welcomePictureBox);
            this.Controls.Add(this.welcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash Screen";
            ((System.ComponentModel.ISupportInitialize)(this.welcomePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Timer splashFormTimer;
        private System.Windows.Forms.PictureBox welcomePictureBox;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}