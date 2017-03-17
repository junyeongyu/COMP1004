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
using System.Windows.Forms;

namespace Assignment4
{
    public partial class OrderForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private ProductInfoForm _productInfoForm; // injected - to get product information / to move back
        private Boolean _isLoaded; //  // to check whether form is loaded

        public SplashScreen splashScreen { get; set; }
        public ProductInfoForm productInfoForm { get; set; }
        public Boolean isLoaded { get; set; }

        public OrderForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            refreshData();
            isLoaded = true;
        }
        public void refreshData()
        {
            _bindData();
            _calculatePrice();
            _bindImages();
        }
        private void _bindData()
        {
            Product product = productInfoForm.product;
            StringBuilder sb = new StringBuilder();
            String doubleNewLine = Environment.NewLine + Environment.NewLine;

            conditionTextBox.Text = product.condition;
            platformTextBox.Text = product.platform;
            manufacturerTextBox.Text = product.manufacturer;
            modelTextBox.Text = product.model;

            sb.Append(product.screensize + doubleNewLine);
            sb.Append(product.RAM_size + doubleNewLine);
            sb.Append(product.CPU_brand + doubleNewLine);
            sb.Append(product.CPU_type + doubleNewLine);
            sb.Append(product.CPU_number + doubleNewLine);
            sb.Append(product.CPU_speed + doubleNewLine);
            sb.Append(product.HDD_size + doubleNewLine);
            sb.Append(product.GPU_Type + doubleNewLine);
            sb.Append(product.webcam + doubleNewLine);
            sb.Append(product.OS);
            productTextBox.Text = sb.ToString();
        }
        private void _calculatePrice()
        {
            Product product = productInfoForm.product;
            double cost = Convert.ToDouble(product.cost); // for convenience of calculation
            double saleTax = cost * 0.13;
            double total = cost + saleTax;

            priceTextBox.Text = _formatCurrency(cost);
            salesTaxTextBox.Text = _formatCurrency(saleTax);
            totalTextBox.Text = _formatCurrency(total);
        }
        private string _formatCurrency(double number)
        {
            return String.Format(new CultureInfo("en-US"), "{0:C}", number);
        }
        private void _bindImages()
        {
            Product product = productInfoForm.product;
            short id = product.productID;
            Bitmap bitmap = id == 1 ? Properties.Resources._1_Asus_G71GX_RX05 :
                            id == 2 ? Properties.Resources._2_Asus_X73SV_XR1 :
                            id == 3 ? Properties.Resources._3_Lenovo_G770 :
                            id == 4 ? Properties.Resources._4_Acer_AS7750G_9621 :
                            id == 5 ? Properties.Resources._5_Asus_G74Sx_RH71 :
                            id == 6 ? Properties.Resources._6_Asus_G74Sx_RH71 :
                            id == 7 ? Properties.Resources._7_Toshiba_X770_01J :
                            id == 8 ? Properties.Resources._8_HP_nx6125 :
                            id == 9 ? Properties.Resources._9_Lenovo_T61 :
                            id == 10 ? Properties.Resources._10_HP_630 :
                            id == 11 ? Properties.Resources._11_Acer_AS5552_7686 :
                            id == 12 ? Properties.Resources._12_Toshiba_P750_00Y :
                            id == 13 ? Properties.Resources._13_HP_HPE_h8_1010 :
                            id == 14 ? Properties.Resources._14_iBUYPOWER_968SLCK :
                            id == 15 ? Properties.Resources._15_CybertronPC_TGM2111E :
                            id == 16 ? Properties.Resources._16_iBUYPOWER_964SLCK :
                            id == 17 ? Properties.Resources._17_CybertronPC_TGM2141L :
                            id == 18 ? Properties.Resources._18_CybertronPC_TGM2171C :
                            id == 19 ? Properties.Resources._19_Gateway_FX6860_EF30P :
                            id == 20 ? Properties.Resources._20_HP_P7_1047 :
                            id == 21 ? Properties.Resources._21_Apple_iMac :
                            id == 22 ? Properties.Resources._22_Apple_Mac_Pro :
                                       Properties.Resources.dollor_computers_logo;
            productPictureBox.Image = bitmap;
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Width, Height);
            DrawToBitmap(img, new Rectangle(0, 0, Width, Height));
            img.Save("screenshot.png"); // location: bin/debug/screenshot.png
            img.Dispose();
            MessageBox.Show("You Printed current information (into file - screenshot.png)");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            productInfoForm.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            String doubleNewLine = Environment.NewLine + Environment.NewLine;
            String text = "Thank you for your order !!" + doubleNewLine;
            text += "Your order will be processed in 7 - 10 business days." + doubleNewLine;
            text += "Have a great day !!";
            MessageBox.Show(text);
            splashScreen.Close();
        }
    }
}
