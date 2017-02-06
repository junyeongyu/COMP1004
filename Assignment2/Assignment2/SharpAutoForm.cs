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
        
        public SharpAutoForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program calculates the amount due on a New or Used Vehicle based on accessories and options");
        }

        private void stereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stereoSystemCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_STEREO_SYSTEM_PRICE);
            } else
            {
                _currentAdditionalItemsPriceSet.Remove(_STEREO_SYSTEM_PRICE);
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_STEREO_SYSTEM_PRICE);
        }

        private void leatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (leatherInteriorCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_LEATHER_INTERIOR_PRICE);
            }
            else
            {
                _currentAdditionalItemsPriceSet.Remove(_LEATHER_INTERIOR_PRICE);
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_LEATHER_INTERIOR_PRICE);
        }

        private void computerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (computerNavigationCheckBox.Checked)
            {
                _currentAdditionalItemsPriceSet.Add(_COMPUTER_NAVIGATION_PRICE);
            }
            else
            {
                _currentAdditionalItemsPriceSet.Remove(_COMPUTER_NAVIGATION_PRICE);
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_COMPUTER_NAVIGATION_PRICE);
        }

        private void standardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (standardRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _STANDARD_PRICE;
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_STANDARD_PRICE);
        }

        private void pearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (pearlizedRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _PEARLIZED_PRICE;
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_PEARLIZED_PRICE);
        }

        private void customizedDetailingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (customizedDetailingRadioButton.Checked)
            {
                _currentExteriorFinishesPrice = _CUSTOMIZED_DETAILING_PRICE;
            }
            refreshAdditionalOptionsAndSubTotalTextBox(_CUSTOMIZED_DETAILING_PRICE);
        }

        private void refreshAdditionalOptionsAndSubTotalTextBox(double currentPrice)
        {
            additionalOptionsTextBox.Text = currentPrice.ToString();
            subTotalTextBox.Text = (_currentAdditionalItemsPriceSet.Sum() + _currentExteriorFinishesPrice).ToString();
        }
    }
}
