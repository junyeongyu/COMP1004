/**
* The class name: StartForm
* Author's name: Junyeong Yu (200328206)
* Class Creation Date: March 7, 2017
* Class Last Modification Date: March 20, 2017
* Class description: Practical initial form to choose product from the database or file.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Assignment4.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment4
{
    public partial class StartForm : Form
    {
        private SplashScreen _splashScreen; // injected - to close form
        private SelectForm _selectForm; // injected - next form
        private ProductInfoForm _projectInfoForm; // injected - next form
        
        public SplashScreen splashScreen { get; set; }
        public SelectForm selectForm { get; set; }
        public ProductInfoForm productInfoForm { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// User will move to slect form to choose product based on database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startNewOrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            selectForm.Show();
        }

        /// <summary>
        /// User will load product information file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openSavedOrderButton_Click(object sender, EventArgs e)
        {
            productInfoForm.openToolStripMenuItem_Click(sender, e);
        }

        /// <summary>
        /// Use will close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            splashScreen.Close();
        }
    }
}
