/**
 * The class name: FinalForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: February 20, 2017
 * Class Last Modification Date: February 20, 2017
 * Class description: (Last Step) The page to finalized character's all information
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
    public partial class FinalForm : Form
    {
        private AbilityForm _abilityForm; // injected
        private RaceForm _raceForm; // injected
        private JobForm _jobForm; // injected

        public AbilityForm abilityForm { set; get; }
        public RaceForm raceForm { set; get; }
        public JobForm jobForm { set; get; }

        public FinalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load all data from previous forms and set data to this form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinalForm_Load(object sender, EventArgs e)
        {
            // One. Set Character Image
            CharacterPictureBox.Image = raceForm.CharacterPictureBox.Image;

            // Two. Set Abilities
            STRTextBox.Text = abilityForm.STRTextBox.Text;
            DEXTextBox.Text = abilityForm.DEXTextBox.Text;
            ENDTextBox.Text = abilityForm.ENDTextBox.Text;
            INTTextBox.Text = abilityForm.INTTextBox.Text;
            PERTextBox.Text = abilityForm.PERTextBox.Text;
            CHATextBox.Text = abilityForm.CHATextBox.Text;

            // Three. Set race
            raceTextBox.Text = raceForm.race;

            // Four. Set job & health points
            jobTextBox.Text = jobForm.job;
            healthPointsTextBox.Text = jobForm.healthPointsValueLabel.Text;
        }
        
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        /// <summary>
        /// Print screen shot of this form data as a specific image file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printButton_Click(object sender, EventArgs e)
        {
            Bitmap img = new Bitmap(Width, Height);
            DrawToBitmap(img, new Rectangle(0, 0, Width, Height));
            img.Save("screenshot.png"); // location: bin/debug/screenshot.png
            img.Dispose();
            MessageBox.Show("You Printed current information (into file - screenshot.png)");
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printButton_Click(sender, e);
        }

        /// <summary>
        /// Retrive all labels and textboxes and set font styles based on user's choice.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = FinalFormFontDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                System.Diagnostics.Debug.WriteLine(result);
                // All label & testBox are using font that user chose.
                Font font = FinalFormFontDialog.Font;

                // Add TableLayoutPanel to retrieve label & textbox
                List<Control> tableLayoutPanelList = new List<Control>();
                tableLayoutPanelList.Add(characterInformationOneTableLayoutPanel);
                tableLayoutPanelList.Add(characterInformationTwoTableLayoutPanel);
                tableLayoutPanelList.Add(abilitiesTableLayoutPanel);

                // Set font into labels and textboxes in tableLayoutPanels
                foreach (Control tableLayoutPanel in tableLayoutPanelList)
                {
                    foreach (Control control in tableLayoutPanel.Controls)
                    {
                        if (control is Label || control is TextBox) // defensive programming
                        {
                            control.Font = font;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Load about form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
