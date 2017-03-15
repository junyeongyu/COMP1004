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
    public partial class OrderForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private ProductInfoForm _productInfoForm; // injected - to get product information
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
            _bindImages();
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

    }
}
