/**
 * 
 * The App name: Sharp Mail Order – SALES BONUS
 * Author's name: Junyeong Yu
 * App Creation Date: January 16, 2017
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

        private void MailOrder_Load(object sender, EventArgs e)
        {
            // For setting currency in TextBox
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (employeeNameTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Employee Name Needs to be entered.");
                return;
            } else if (employeeIdTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Employee ID Needs to be entered.");
                return;
            } else if (totalHoursWorkedTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Total Hours Worked Needs to be entered.");
                return;
            } else if (totalMonthlySalesTextBox.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Total Monthly Sales Needs to be entered.");
                return;
            }

            double percentageOfHourWorked = Convert.ToDouble(totalHoursWorkedTextBox.Text) / 160;
            double totalBonusAmount = _currentTotalMonthlySales * 0.02;//Convert.ToDouble(totalMonthlySalesTextBox.Text) * 0.02;
            double salesBonus = percentageOfHourWorked * totalBonusAmount;
            salesBonusTextBox.Text = Convert.ToString(salesBonus);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Text = String.Empty;
            employeeIdTextBox.Text = String.Empty;
            totalHoursWorkedTextBox.Text = String.Empty;
            salesBonusTextBox.Text = String.Empty;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The form you filled up is being sent to the printer.");
        }

        private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) {
                languageGroupBox.Text = "Languages";
                employeeNameLabel.Text = "Employee's Name :";
                employeeIdLabel.Text = "Employee ID :";
                totalHoursWorkedLabel.Text = "Total Hours Worked :";
                totalMonthlySalesLabel.Text = "Total Monthly Sales :";
                salesBonusLabel.Text = "Sales Bonus :";
                calculateButton.Text = "Calculate";
                nextButton.Text = "Next";
                printButton.Text = "Print";
            }
        }

        private void frenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                languageGroupBox.Text = "Langues";
                employeeNameLabel.Text = "Le nom de l'employé :";
                employeeIdLabel.Text = "ID employé :";
                totalHoursWorkedLabel.Text = "Nombre total d'heures travaillées :";
                totalMonthlySalesLabel.Text = "Total des ventes mensuelles :";
                salesBonusLabel.Text = "Bonus de vente :";
                calculateButton.Text = "Calculer";
                nextButton.Text = "Prochain";
                printButton.Text = "Impression";
            }
        }

        private void spanishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                languageGroupBox.Text = "Idiomas";
                employeeNameLabel.Text = "Nombre del empleado :";
                employeeIdLabel.Text = "ID de empleado :";
                totalHoursWorkedLabel.Text = "Total de horas trabajadas :";
                totalMonthlySalesLabel.Text = "Total de ventas mensuales :";
                salesBonusLabel.Text = "Bono de ventas :";
                calculateButton.Text = "Calcular";
                nextButton.Text = "Siguiente";
                printButton.Text = "Impresión";
            }
        }

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
                MessageBox.Show("You need to put the positive number.");
                totalHoursWorkedTextBox.Text = String.Empty;
                return;
            }

            if (number > 160)
            {
                MessageBox.Show("You shouldn't put more than 160 hours.");
                totalHoursWorkedTextBox.Text = String.Empty;
                return;
            }
        }

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
                MessageBox.Show("You need to put the positive number.");
                totalMonthlySalesTextBox.Text = String.Empty;
                return;
            }

            _currentTotalMonthlySales = value;
            totalMonthlySalesTextBox.Text = getCurrency(value);
        }
        private String getCurrency(Double number)
        {
            // return number.ToString("C");
            return String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", number);
        }

        private void totalMonthlySalesTextBox_Enter(object sender, EventArgs e)
        {
            totalMonthlySalesTextBox.Text = String.Empty;
        }
    }
}
