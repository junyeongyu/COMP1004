/**
 * The App name: Sharp Mail Order – SALES BONUS
 * Author's name: Junyeong Yu (200328206)
 * App Creation Date: January 16, 2017
 * App Last Modification Date: January 24, 2017
 * App description: Calulate the bonus using MailOrder Form.
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

namespace Assignment1
{
    public partial class MailOrder : System.Windows.Forms.Form
    {
        private double _currentTotalMonthlySales = 0; // Current Total Monthly Sales
        
        public MailOrder()
        {
            InitializeComponent();
        } 

        /// <summary>
        /// Initialize current culture when MailOrder Form component is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailOrder_Load(object sender, EventArgs e)
        {
            // For setting currency in TextBox
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        /// <summary>
        /// Calcuate sales bonus using total hours worked and total monthly sales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            /// Empty Check
            if (employeeNameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Messages.popupEmployeeNameNeedsToBeEntered);
                return;
            } else if (employeeIdTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Messages.popupEmployeeIdNeedsToBeEntered);
                return;
            } else if (totalHoursWorkedTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Messages.popupTotalHoursWorkedNeedsToBeEntered);
                return;
            } else if (totalMonthlySalesTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show(Messages.popupTotalMonthlySalesNeedsToBeEntered);
                return;
            }

            // sales bonus = (total hours worked / 160) * (total monthy sales * 0.02)
            double percentageOfHourWorked = Convert.ToDouble(totalHoursWorkedTextBox.Text) / 160;
            double totalBonusAmount = _currentTotalMonthlySales * 0.02;//Convert.ToDouble(totalMonthlySalesTextBox.Text) * 0.02;
            double salesBonus = percentageOfHourWorked * totalBonusAmount;
            salesBonusTextBox.Text = Convert.ToString(salesBonus);
        }

        /// <summary>
        /// Intialize TextBox components
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Text = String.Empty;
            employeeIdTextBox.Text = String.Empty;
            totalHoursWorkedTextBox.Text = String.Empty;
            salesBonusTextBox.Text = String.Empty;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Messages.popupTheFormYouFilledUpIsBeingSentToThePrinter);
        }

        /// <summary>
        /// Change current culture into English and refresh labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
                refreshLabel();
            }
        }

        /// <summary>
        /// Change current culture into French and refresh labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("fr-FR");
                refreshLabel();
            }
        }

        /// <summary>
        /// Change current culture into Spanish and refresh labels
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("es-ES");
                refreshLabel();
            }
        }

        private void refreshLabel()
        {
            languageGroupBox.Text = Messages.languageGroupBox;
            employeeNameLabel.Text = Messages.employeeNameLabel;
            employeeIdLabel.Text = Messages.employeeIdLabel;
            totalHoursWorkedLabel.Text = Messages.totalHoursWorkedLabel;
            totalMonthlySalesLabel.Text = Messages.totalMonthlySalesLabel;
            salesBonusLabel.Text = Messages.salesBonusLabel;
            calculateButton.Text = Messages.calculateButton;
            nextButton.Text = Messages.nextButton;
            printButton.Text = Messages.printButton;
            this.Text = Messages.salesBonusThisForm;
        }

        /// <summary>
        /// When total hours worked value is changed, validation is conducted
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalHoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = totalHoursWorkedTextBox.Text;
            if (text == "")
            {
                return;
            }

            double number;
            if (double.TryParse(text, out number) == false)
            {
                MessageBox.Show(Messages.popupYouNeedToPutThePositiveNumber);
                totalHoursWorkedTextBox.Text = String.Empty;
                return;
            }

            if (number > 160)
            {
                MessageBox.Show(Messages.popupYouShouldNotPutMoreThan160Hours);
                totalHoursWorkedTextBox.Text = String.Empty;
                return;
            }
        }

        /// <summary>
        /// When focus is out, validation of total monthly sales is conducted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalMonthlySalesTextBox_Leave(object sender, EventArgs e)
        {
            Double value;
            if (Double.TryParse(totalMonthlySalesTextBox.Text, out value) == false)
            {
                totalMonthlySalesTextBox.Text = getCurrency(_currentTotalMonthlySales);
                return;
            }
            if (value < 0)
            {
                MessageBox.Show(Messages.popupYouNeedToPutThePositiveNumber);
                totalMonthlySalesTextBox.Text = String.Empty;
                return;
            }

            // store data into private field from text box
            _currentTotalMonthlySales = value;
            totalMonthlySalesTextBox.Text = getCurrency(value);
        }
        private String getCurrency(Double number)
        {
            // return number.ToString("C");
            return String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", number);
        }

        /// <summary>
        /// Remove currency format when user focuses on total monthly sales field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalMonthlySalesTextBox_Enter(object sender, EventArgs e)
        {
            totalMonthlySalesTextBox.Text = String.Empty;
        }
    }
}