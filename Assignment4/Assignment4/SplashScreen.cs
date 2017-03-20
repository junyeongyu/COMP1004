/**
 * The class name: SplashScreen
 * Author's name: Junyeong Yu (200328206)
 * Class Creation Date: March 7, 2017
 * Class Last Modification Date: March 20, 2017
 * Class description: SplashScreen Form before loading main form.
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

namespace Assignment4
{
    public partial class SplashScreen : Form
    {
        private StartForm _startForm; // injected: start form

        public StartForm startForm { get; set; }

        /// <summary>
        /// Default constructor to initialize components
        /// </summary>
        public SplashScreen()
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
            startForm.Show();
        }
    }
}