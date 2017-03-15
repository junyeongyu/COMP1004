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
        private Product _product;
        private Boolean _isLoaded = false;

        public SplashScreen splashScreen { get; set; }
        public ProductInfoForm productInfoForm { get; set; }
        public ProductContext productContext { get; set; }
        public Product product { get; set; }
        public Boolean isLoaded { get; set; }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            //this.productsTableAdapter.Fill(this._comp_1004DataSet.products);
            refreshData();
            isLoaded = true;
        }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }

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

        private void dollorComputerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dollorComputerDataGridView.CurrentRow;
            short productID = short.Parse(row.Cells[0].Value.ToString());
            _selectRow(productID);
        }
    }
}