/**
* The class name: SelectForm
* Author's name: Junyeong Yu (200328206)
* Class Creation Date: March 7, 2017
* Class Last Modification Date: March 20, 2017
* Class description: SelectForm class shows list of product and offers interface to choose product
*/
using Assignment4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class SelectForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private ProductInfoForm _productInfoForm; //injected - for next step
        private ProductContext _productContext; // injected - for loading data
        private Product _product; // injected by previous form
        private Boolean _isLoaded = false; // to check whether form is loaded already

        public SplashScreen splashScreen { get; set; }
        public ProductInfoForm productInfoForm { get; set; }
        public ProductContext productContext { get; set; }
        public Product product { get; set; }
        public Boolean isLoaded { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public SelectForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When form is load, necessary data are bound with components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectForm_Load(object sender, EventArgs e)
        {
            refreshData();
            isLoaded = true;
        }
        /// <summary>
        /// Whenever user come to this form, data is refreshed
        /// </summary>
        public void refreshData()
        {
            try
            {
                this.dollorComputerDataGridView.DataSource = (from product in productContext.products select product).ToList();
                if (product != null) // when from ProductInfoForm
                {
                    _selectRow(product.productID);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        /// <summary>
        /// Select proper row and change the color of row
        /// </summary>
        /// <param name="productID"></param>
        private void _selectRow(short productID)
        {
            // change color for selected row
            foreach (DataGridViewRow rowTemp in dollorComputerDataGridView.Rows)
            {
                if (productID != short.Parse(rowTemp.Cells[0].Value.ToString()))
                {
                    rowTemp.DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    rowTemp.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

            product = (from product in productContext.products where product.productID == productID select product).SingleOrDefault();
            nextButton.Enabled = true;

            // displays the manufacturer field, the model field and the cost field
            yourSelectionTextBox.Text = product.manufacturer + " " + product.model + " Priced at: $" + product.cost;

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
        /// Move to product information form to see detail information of product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            Hide();
            productInfoForm.product = product;
            if (productInfoForm.isLoaded) // because loading form is one time.
            {
                productInfoForm.refreshData();
            }
            productInfoForm.Show();
        }

        /// <summary>
        /// When user select any of cell, the row of the cell is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dollorComputerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dollorComputerDataGridView.CurrentRow;
            short productID = short.Parse(row.Cells[0].Value.ToString());
            _selectRow(productID);
        }
    }
}