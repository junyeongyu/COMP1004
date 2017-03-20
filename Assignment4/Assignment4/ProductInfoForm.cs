/**
* The class name: ProductInfoForm
* Author's name: Junyeong Yu (200328206)
* Class Creation Date: March 7, 2017
* Class Last Modification Date: March 20, 2017
* Class description: ProductInfoForm class shows detail information of product
*/
using Assignment4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment4
{
    public partial class ProductInfoForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private StartForm _startForm; // injected - // for start form to use productInfoForm' open file event handler
        private Product _product; // injected by previous form
        private SelectForm _selectForm; // injected - to move select form
        private OrderForm _orderForm; // injected - to move order form
        private Boolean _isLoaded = false; // to check whether form is loaded

        public SplashScreen splashScreen { get; set; }
        public StartForm startForm { get; set; }
        public Product product { get; set; }
        public SelectForm selectForm { get; set; }
        public OrderForm orderForm { get; set; }
        public Boolean isLoaded { get; set; }

        /// <summary>
        /// Default constructor to initialize component
        /// </summary>
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When form is loaded, all data are bound with all necessary components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            refreshData();
            isLoaded = true;
        }
        /// <summary>
        /// Whenever user move the form, all neccesary data are bound with components
        /// </summary>
        public void refreshData()
        {
            productIdTextBox.Text = Convert.ToString(product.productID);
            conditionTextBox.Text = product.condition;
            // add culture format for currency
            costTextBox.Text = String.Format(new CultureInfo("en-US"), "{0:C}", product.cost);
            platformTextBox.Text = product.platform;
            osTextBox.Text = product.OS;
            manufacturerTextBox.Text = product.manufacturer;
            modelTextBox.Text = product.model;
            memoryTextBox.Text = product.RAM_size;
            lcdSizeTextBox.Text = product.screensize;
            hddTextBox.Text = product.HDD_size;
            cpuBrandTextBox.Text = product.CPU_brand;
            cpuNumberTextBox.Text = product.CPU_number;
            gpuTypeTextBox.Text = product.GPU_Type;
            cpuTypeTextBox.Text = product.CPU_type;
            cpuSpeedTextBox.Text = product.CPU_speed;
            webCamTextBox.Text = product.webcam;

            nextButton.Enabled = true;
        }

        /// <summary>
        /// Move into prevous form and send current product data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAnotherProductButton_Click(object sender, EventArgs e)
        {
            Hide();
            selectForm.product = product;
            if (selectForm.isLoaded) // when form is already loaded, data needs to be refreshed
            {
                selectForm.refreshData();
            }
            selectForm.Show();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }

        /// <summary>
        /// Move to order form to finalize order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Hide();
            if (orderForm.isLoaded)
            {
                orderForm.refreshData();
            }
            orderForm.Show();
        }

        /// <summary>
        /// open the file of product information which user save before
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productOpenFileDialog.Filter = "Text Files|*.txt";
            productOpenFileDialog.Title = "Select a Your Order File.";
            if (productOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (productOpenFileDialog.FileName.Trim() != string.Empty)
                {
                    FileStream fileStream = new FileStream(productOpenFileDialog.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                    product = (Product) new BinaryFormatter().Deserialize(fileStream);
                    refreshData();
                }
                
                // When from StartForm, start form needs to be closed & show this class form
                if (sender is Button)
                {
                    Button button = sender as Button;                    
                    if (button == startForm.openSavedOrderButton)
                    {
                        startForm.Hide();
                        Show();
                    }
                }

            }
        }

        /// <summary>
        /// Save the file of information for user to load data in furture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productSaveFileDialog.Filter = "Text Files|*.txt";
            productSaveFileDialog.Title = "Save a Your Order Information.";
            productSaveFileDialog.FileName = "Product.txt";
            if (productSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (productSaveFileDialog.FileName.Trim() != string.Empty)
                {
                    FileStream fileStream = new FileStream(productSaveFileDialog.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    new BinaryFormatter().Serialize(fileStream, product);
                }
            }
        }
    }
}