using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class RaceForm : Form
    {
        private AbilityForm _previousForm;

        public AbilityForm previousForm { get; set; }

        public RaceForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Delegate duty for checking & setting value when ability is lessor than 3 or more than 50.
        /// </summary>
        /// <param name="abilityTextBox"></param>
        /// <param name="value"></param>
        private void _addAbilityValue(TextBox abilityTextBox, int value)
        {
            previousForm.addAbilityValue(abilityTextBox, value);
        }
       
        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RacialBonusTextBox.Text = "All Ability(+5)";
        }

        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RacialBonusTextBox.Text = "STR(+20), PER(+20), CHA(-10)";
        }

        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RacialBonusTextBox.Text = "DEX(+15), CHA(+15)";
        }

        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            RacialBonusTextBox.Text = "DEX(+20), INT(+20), STR(-10)";
        }

        /// <summary>
        /// To get accurate result, adding data executes at this moment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // When user select radiobox and values are also changed at this moment,
            // there is possibility to lost data if value is lessor then 3 or more than 50.
            if (humanRadioButton.Checked)
            {
                foreach (TextBox abilityTextBox in previousForm.getAbilities())
                {
                    _addAbilityValue(abilityTextBox, 5);
                }
            } else if (dwarfRadioButton.Checked)
            {
                _addAbilityValue(previousForm.STRTextBox, 20);
                _addAbilityValue(previousForm.PERTextBox, 20);
                _addAbilityValue(previousForm.CHATextBox, -10);
            } else if (elfRadioButton.Checked)
            {
                _addAbilityValue(previousForm.DEXTextBox, 15);
                _addAbilityValue(previousForm.CHATextBox, 15);
            } else if (halflingRadioButton.Checked)
            {
                _addAbilityValue(previousForm.DEXTextBox, 20);
                _addAbilityValue(previousForm.INTTextBox, 20);
                _addAbilityValue(previousForm.STRTextBox, -10);
            } else
            {
                MessageBox.Show("You need to choose race to preceed next step.");
                return;
            }

            JobForm jobForm = new JobForm();
            jobForm.previouseForm = this;
            jobForm.ShowDialog();
            Hide();
        }
    }
}
