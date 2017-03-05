/**
 * The class name: SplashForm
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: March 5, 2017
 * Class Last Modification Date: March 5, 2017
 * Class description: Splash Form before loading main form.
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

namespace Assignment3
{
    public partial class SplashForm : Form
    {
        private SelectionForm _selectionForm; // injected

        public SelectionForm selectionForm { get; set; }

        /// <summary>
        /// Default constructor to initialize components
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is consistently called as long as timer is enabled.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splashFormTimer_Tick(object sender, EventArgs e)
        {
            splashFormTimer.Enabled = false;
            Hide();
            
            // show next form
            selectionForm.Show();
        }
    }
}
