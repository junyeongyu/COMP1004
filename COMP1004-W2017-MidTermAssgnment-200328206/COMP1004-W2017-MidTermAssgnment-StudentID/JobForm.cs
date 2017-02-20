/**
 * The class name: JobForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: February 20, 2017
 * Class Last Modification Date: February 20, 2017
 * Class description: (Third Step) The page to decide character's job by choosing
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

namespace COMP1004_W2017_MidTermAssgnment_200328206
{
    public partial class JobForm : Form
    {
        private AbilityForm _abilityForm; // previous -- injected
        private FinalForm _finalForm; // next -- injected
        private string _job;

        public AbilityForm abilityForm { get; set; }
        public FinalForm finalForm { get; set; }
        public string job { get; set; }

        public JobForm()
        {
            InitializeComponent();
            job = String.Empty;
        }

        /// <summary>
        /// When soldier is chose, health points are 30 points + END Ability Score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void soldierRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Soldier: 30 points + END Ability Score
            healthPointsValueLabel.Text = (30 + int.Parse(abilityForm.ENDTextBox.Text)).ToString();
            job = "Soldier";
        }

        /// <summary>
        /// When rogue is chose, health points are 28 points + DEX Ability Score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rogueRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Rogue: 28 points + DEX Ability Score
            healthPointsValueLabel.Text = (28 + int.Parse(abilityForm.DEXTextBox.Text)).ToString();
            job = "Rogue";
        }

        /// <summary>
        /// When magicker is chose, health points are 15 points + INT Ability Score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void magickerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Magicker: 15 points + INT Ability Score
            healthPointsValueLabel.Text = (15 + int.Parse(abilityForm.INTTextBox.Text)).ToString();
            job = "Magicker";
        }

        /// <summary>
        /// When cultiest is chose, health points are 24 points + CHA Ability Score
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cultiestRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Cultist: 24 points + CHA Ability Score
            healthPointsValueLabel.Text = (24 + int.Parse(abilityForm.CHATextBox.Text)).ToString();
            job = "Cultiest";
        }

        /// <summary>
        /// After proper validation, move to the final step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (job.Equals(String.Empty))
            {
                MessageBox.Show("You need to choose job to preceed next step.");
                return;
            }
            
            // Go to the final form
            Hide();
            finalForm.ShowDialog();
            Close();
        }
    }
}
