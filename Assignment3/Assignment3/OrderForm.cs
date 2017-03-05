/**
 * The class name: OrderForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: Feburary 13, 2017
 * Class Last Modification Date: March 5, 2017
 * Class description: Calculate grand total price of movie based on cost, dvd and tax.
 *                    Provide print & streaming functions
 */
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
        public string grandTotal { get { return grandTotalTextBox.Text; } }
        public string title { get { return titleTextBox.Text;} }

        /// <summary>
        /// Default constructor of order form
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Initial load event handler to refresh data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            refreshData();
            isLoaded = true;
        }
        /// <summary>
        /// Refresh data based on previous form information
        /// </summary>
        public void refreshData()
        {
            // set data using data from previous form
            movieSelectedPictureBox.Image = selectionForm.image;
            titleTextBox.Text = selectionForm.title;
            categoryTextBox.Text = selectionForm.category;

            // calculate your order data
            calculateOrder();
        }
        /// <summary>
        /// Calculate grand total price based on cost, dvd & tax
        /// </summary>
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

        /// <summary>
        /// Close application when cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service !!");
            splashForm.Close();
        }

        /// <summary>
        /// StreamForm is shown when stream button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Show developer information of this application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Whenever additional charge checkbox is checked, calculation takes place
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void additionalChargeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            calculateOrder();
        }

        /// <summary>
        /// Move to previous form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            selectionForm.Show();
        }
    }
}
