using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class OrderForm : Form
    {
        private SplashForm _splashForm; // injected - most parent form
        private SelectionForm _selectionForm; // injected - previous form
        private StreamForm _streamForm; // injected - for next step
        private bool _isLoaded = false; // to check whether this form is loaded or not

        public SplashForm splashForm { get; set; }
        public SelectionForm selectionForm { get; set; }
        public StreamForm streamForm { get; set; }
        public bool isLoaded { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }
        
        private void OrderForm_Load(object sender, EventArgs e)
        {
            refreshData();
            isLoaded = true;
        }
        public void refreshData()
        {
            // set data using data from previous form
            movieSelectedPictureBox.Image = selectionForm.image;
            titleTextBox.Text = selectionForm.title;
            categoryTextBox.Text = selectionForm.category;

            // calculate your order data
            calculateOrder();
        }
        private void calculateOrder()
        {
            // calcuate order
            double additionalCharge = additionalChargeCheckBox.Checked ? 10 : 0;
            double costWithAdditionalCharge = Math.Round(selectionForm.cost + additionalCharge, 2);
            double saleTax = Math.Round(0.13 * costWithAdditionalCharge, 2);
            costTextBox.Text = selectionForm.cost.ToString();
            subTotalTextBox.Text = costWithAdditionalCharge.ToString();
            salesTaxTextBox.Text = saleTax.ToString();
            grandTotalTextBox.Text = (costWithAdditionalCharge + saleTax).ToString();

            // show if addtional charge checkbox is checked, otherwise hide
            additionalChargeLabel.Visible = additionalChargeCheckBox.Checked;
            additionalChargeTextBox.Visible = additionalChargeCheckBox.Checked;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service !!");
            splashForm.Close();
        }

        private void streamButton_Click(object sender, EventArgs e)
        {
            Hide();
            streamForm.Show();
        }

        /// <summary>
        /// Print screen shot of this form data as a specific image file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Width, Height);
            DrawToBitmap(img, new Rectangle(0, 0, Width, Height));
            img.Save("screenshot.png"); // location: bin/debug/screenshot.png
            img.Dispose();
            MessageBox.Show("You Printed current information (into file - screenshot.png)");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void additionalChargeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            calculateOrder();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            selectionForm.Show();
        }
    }
}
