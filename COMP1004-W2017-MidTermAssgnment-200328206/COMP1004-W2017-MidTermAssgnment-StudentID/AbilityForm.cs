using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();

        private RaceForm _raceForm; // next - injected
        private List<TextBox> _abilities;

        public RaceForm raceForm { get; set; }

        public AbilityForm()
        {
            InitializeComponent();

            // Initialize
            _abilities = new List<TextBox>();
            _initializeAbilities();
        }

        private void _initializeAbilities()
        {
            _abilities.Add(STRTextBox);
            _abilities.Add(DEXTextBox);
            _abilities.Add(ENDTextBox);
            _abilities.Add(INTTextBox);
            _abilities.Add(PERTextBox);
            _abilities.Add(CHATextBox);
        }

        private int _limitNotExcceed(int value)
        {
            if (value <3)
            {
                value = 3;
            } else if (value > 50)
            {
                value = 50;
            }
            return value;
        }

        public List<TextBox> getAbilities()
        {
            return _abilities;
        }

        public void setAbilityValue(TextBox textBox, int number)
        {
            number = _limitNotExcceed(number);
            textBox.Text = number.ToString();
        }

        public void addAbilityValue(TextBox textBox, int number)
        {
            int previousValue = int.Parse(textBox.Text);
            number += previousValue;
            setAbilityValue(textBox, number);
        }

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            // Iterate through the TextBox List (_abilities)
            for (int i = 0; i < _abilities.Count; i++)
            {
                TextBox abilitiesTextBox = _abilities[i];

                // role 3d10 and assign the value to a temp variable
                int currentRole = Roll3D10();

                // assign the urrent roll to the current ability
                setAbilityValue(abilitiesTextBox, currentRole);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (STRTextBox.Text.Equals(String.Empty))
            {
                MessageBox.Show("You need to roll dice to preceed next step.");
                return;
            }

            Hide();
            raceForm.ShowDialog();
            Close();
        }
    }
}
