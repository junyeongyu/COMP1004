using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class SharpAutoForm : Form
    {
        // Class Members

        // Additional Items
        private const double _STEREO_SYSTEM_PRICE = 425.76;
        private const double _LEATHER_INTERIOR_PRICE = 987.41;
        private const double _COMPUTER_NAVIGATION_PRICE = 1741.23;
        private ISet<double> _currentAdditionalItemsPriceSet = new HashSet<double>(); // Can be used when only value is different
        //private double _currentAdditionalItemsPrice; // Not Used due to Plus Minus Bug

        // Exterior Finishes
        private const double _STANDARD_PRICE = 0.0;
        private const double _PEARLIZED_PRICE = 345.72;
        private const double _CUSTOMIZED_DETAILING_PRICE = 599.99;
        private double _currentExteriorFinishesPrice = _STANDARD_PRICE;

        // Tax Rate
        private const double _TAX_RATE = 0.13;
        
        
        // Constructor

        public SharpAutoForm()
        {
            InitializeComponent();
        }


        // Private Methods

        //  Event Handlers
        
        private void _aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            //MessageBox.Show("This program calculates the amount due on a New or Used Vehicle based on accessories and options.");
        }

        private void _stereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stereoSystemCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_STEREO_SYSTEM_PRICE);
            } else
            {
                _currentAdditionalItemsPriceSet.Remove(_STEREO_SYSTEM_PRICE);
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _leatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (leatherInteriorCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_LEATHER_INTERIOR_PRICE);
            }
            else
            {
                _currentAdditionalItemsPriceSet.Remove(_LEATHER_INTERIOR_PRICE);
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _computerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (computerNavigationCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_COMPUTER_NAVIGATION_PRICE);
            }
            else
            {
                _currentAdditionalItemsPriceSet.Remove(_COMPUTER_NAVIGATION_PRICE);
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _standardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (standardRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _STANDARD_PRICE;
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _pearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pearlizedRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _PEARLIZED_PRICE;
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _customizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customizedDetailingRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _CUSTOMIZED_DETAILING_PRICE;
            }
            _refreshAdditionalOptionsTextBox();
        }

        private void _caculateButton_Click(object sender, EventArgs e)
        {
            // Validations
            string basePriceText = basePriceTextBox.Text.Trim();
            string tradeInAllowanceText = tradeInAllowanceTextBox.Text.Trim();
            
            //  Empty Check
            if (basePriceText == String.Empty)
            {
                MessageBox.Show("Base Price should be inputed.");
                return;
            }
            else if (tradeInAllowanceText == String.Empty)
            {
                MessageBox.Show("Trade-in Allowance should be inputed.");
                return;
            }

            //  Value Check
            double basePrice;
            if (double.TryParse(basePriceText, out basePrice) == false)
            {
                MessageBox.Show("Base Price needs to be number.");
                basePriceTextBox.Text = String.Empty;
                return;
            }
            if (basePrice <= 0)
            {
                MessageBox.Show("Base Price needs to be more than zero.");
                basePriceTextBox.Text = String.Empty;
                return;
            }

            double tradeInAllowance;
            if (double.TryParse(tradeInAllowanceText, out tradeInAllowance) == false)
            {
                MessageBox.Show("Trade in Allowance needs to be number.");
                tradeInAllowanceTextBox.Text = String.Empty;
                return;
            }
            if (tradeInAllowance < 0)
            {
                MessageBox.Show("Trade in Allowance needs to be positive number.");
                tradeInAllowanceTextBox.Text = String.Empty;
                return;
            }
            
            // Options Price = Additional Items Price + Exterior Finishes Price
            double additionalItemsAndExteriorFinishesPrice = _currentAdditionalItemsPriceSet.Sum() + _currentExteriorFinishesPrice;

            // Sub Total = Base Price + Options Price
            double subTotal = double.Parse(basePriceTextBox.Text) + additionalItemsAndExteriorFinishesPrice;
            subTotalTextBox.Text = subTotal.ToString();

            // Sales Tax = Sub Total * Tax Rate
            double salesTax = subTotal * _TAX_RATE;
            salesTaxTextBox.Text = salesTax.ToString();

            // Total = Sub Total * Sales Tax
            double total = subTotal + salesTax;
            totalTextBox.Text = total.ToString();

            // Amout Due = Total - Trade in allowance
            double amountDue = total - tradeInAllowance;
            amountDueTextBox.Text = amountDue.ToString();
        }

        private void _clearButton_Click(object sender, EventArgs e)
        {
            _refreshAll();
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = sharpAutoCenterFontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Font font = sharpAutoCenterFontDialog.Font;

                amountDueTextBox.Font = font;
                basePriceTextBox.Font = font;
            }
        }

        private void _colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = sharpAutoCenterColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Color color = sharpAutoCenterColorDialog.Color;
                amountDueTextBox.BackColor = amountDueTextBox.BackColor; // for fixing a bug - http://stackoverflow.com/questions/20688408/how-do-you-change-the-text-color-of-a-readonly-textbox
                amountDueTextBox.ForeColor = color;
                basePriceTextBox.ForeColor = color;
            }
        }
        
        //  General Functions

        private void _refreshAdditionalOptionsTextBox()
        {
            additionalOptionsTextBox.Text = (_currentAdditionalItemsPriceSet.Sum() + _currentExteriorFinishesPrice).ToString();
        }

        private void _refreshAll()
        {
            // Refresh Text Boxes
            basePriceTextBox.Text = String.Empty;
            additionalOptionsTextBox.Text = "0";
            subTotalTextBox.Text = String.Empty;
            salesTaxTextBox.Text = String.Empty;
            totalTextBox.Text = String.Empty;
            tradeInAllowanceTextBox.Text = "0";
            amountDueTextBox.Text = String.Empty;

            // Refresh Additional Itemds
            stereoSystemCheckBox.Checked = false;
            leatherInteriorCheckBox.Checked = false;
            computerNavigationCheckBox.Checked = false;

            // Refresh Exterior Finish
            standardRadioButton.Checked = true; // default
        }
    }
}
