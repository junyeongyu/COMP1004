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
    public partial class StreamForm : Form
    {
        private SplashForm _splashForm; // injected - most parent form
        private OrderForm _orderForm; // injected - previous form

        public SplashForm splashForm { get; set; }
        public OrderForm orderForm { get; set; }
        public StreamForm()
        {
            InitializeComponent();
        }

        private void StreamForm_Load(object sender, EventArgs e)
        {
            creditCardLabel.Text = "Your Credit card will be charged " + orderForm.grandTotal + " dollars.";
            movieNameLabel.Text = orderForm.title + " will begin streaming shortly.";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service !!");
            splashForm.Close();
        }
    }
}
