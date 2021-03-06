﻿/**
 * The class name: RaceForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: February 20, 2017
 * Class Last Modification Date: February 20, 2017
 * Class description: (Second Step) The page to decide character's race by choosing
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
    public partial class RaceForm : Form
    {
        private AbilityForm _abilityForm; // previouse -- injected
        private JobForm _jobForm; // next -- injected
        private string _race;

        public AbilityForm abilityForm { get; set; }
        public JobForm jobForm { get; set; }
        public string race { get; set; }

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
            abilityForm.addAbilityValue(abilityTextBox, value);
        }
       
        /// <summary>
        /// When human is selected, all abilities are added as much as 5 points
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void humanRadioButton_CheckedChanged(object sender, EventArgs e)
        {

            CharacterPictureBox.Image = Properties.Resources.M_Human1;
            RacialBonusTextBox.Text = "All Ability(+5)";
            race = "Human";
        }

        /// <summary>
        /// When dwarf is selected, STR and PER are added as 20, and CHA is deducted as 10.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dwarfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Dwarf1;
            RacialBonusTextBox.Text = "STR(+20), PER(+20), CHA(-10)";
            race = "Dwarf";
        }

        /// <summary>
        /// When elf is selected, DEX and CHA are added as much as 15.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void elfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Elf1;
            RacialBonusTextBox.Text = "DEX(+15), CHA(+15)";
            race = "Elf";
        }

        /// <summary>
        /// When halfling is selected, DEX and INT are added as much as 20, but STR is deducted as 10.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void halflingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharacterPictureBox.Image = Properties.Resources.M_Halfling2;
            RacialBonusTextBox.Text = "DEX(+20), INT(+20), STR(-10)";
            race = "Halfling";
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
                foreach (TextBox abilityTextBox in abilityForm.getAbilities())
                {
                    _addAbilityValue(abilityTextBox, 5);
                }
            } else if (dwarfRadioButton.Checked)
            {
                _addAbilityValue(abilityForm.STRTextBox, 20);
                _addAbilityValue(abilityForm.PERTextBox, 20);
                _addAbilityValue(abilityForm.CHATextBox, -10);
            } else if (elfRadioButton.Checked)
            {
                _addAbilityValue(abilityForm.DEXTextBox, 15);
                _addAbilityValue(abilityForm.CHATextBox, 15);
            } else if (halflingRadioButton.Checked)
            {
                _addAbilityValue(abilityForm.DEXTextBox, 20);
                _addAbilityValue(abilityForm.INTTextBox, 20);
                _addAbilityValue(abilityForm.STRTextBox, -10);
            } else
            {
                MessageBox.Show("You need to choose race to preceed next step.");
                return;
            }

            Hide();
            jobForm.ShowDialog();
            Close();
        }
    }
}
