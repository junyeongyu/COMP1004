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
        private Product _currentProduct;

        public SplashScreen splashScreen { get; set; }
        public ProductInfoForm productInfoForm { get; set; }
        public ProductContext productContext { get; set; }

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            //this.productsTableAdapter.Fill(this._comp_1004DataSet.products);
            try
            {
                this.dollorComputerDataGridView.DataSource = (from product in productContext.products select product).ToList();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            Hide();
            productInfoForm.Show();
        }

        private void dollorComputerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            DataGridViewRow row = dataGridView.CurrentRow;

            // change color for selected row
            row.DefaultCellStyle.BackColor = Color.Yellow; // for ui performance
            foreach (DataGridViewRow rowTemp in dataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString() != rowTemp.Cells[0].Value.ToString())
                {
                    rowTemp.DefaultCellStyle.BackColor = Color.White;
                }
            }

            short productID = short.Parse(row.Cells[0].Value.ToString());
            Product productOne = (from product in productContext.products where product.productID == productID select product).SingleOrDefault();
            _currentProduct = productOne;
            nextButton.Enabled = true;

            // displays the manufacturer field, the model field and the cost field
            yourSelectionTextBox.Text = productOne.manufacturer + " " + productOne.model + " Priced at: $" + productOne.cost;
        }
    }
}